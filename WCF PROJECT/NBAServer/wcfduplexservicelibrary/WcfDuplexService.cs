using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using WcfDuplexServiceInterface;
using System.Data.SqlClient;
using System.IO;



/* Service Library – This is the implementation of the service contract. 
* This is the code that the service executes when the client makes 
* a request and as such it is known only to the service. */

namespace WCFDuplexServiceLibrary
{  
        /* The service object is a Singleton meaning that all service calls are handled by  
        the same service instance and this behavior is controlled by InstanceContextMode 
        being set to Single */

        /*  the service instance is multithreaded so that each call be handled in parallel by 
        the service and this is controlled by ConcurrencyMode being set to Multiple. 
        WCF requires us to handle the synchronization of the service object ourselves
        this is handled by the SyncRoot pattern */

        /* MORE DOCUMENTATION IN THE SERVICE INTERFACE*/

    [ServiceBehavior(
    InstanceContextMode = InstanceContextMode.Single,
    ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class WcfDuplexService : IDuplexService
    {
        private static List<IDuplexCallBack> _callbackChannels = new List<IDuplexCallBack>();
        private static List<string> _groceryList = new List<string>();
        private static readonly object _sycnRoot = new object();
        public static NBADataContext dc;
        public const string path = @"c:\databases\Dor&Niv_NBADBase.mdf";
        public const string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
            @"AttachDbFilename=" + path + @";Integrated Security=True";

        /// <summary>
        /// Update, Insert or Delete actions write to a log file 'NbaLog'
        /// </summary>
        /// <param name="logMessage"> message of the action</param>
        /// <param name="w"> the text writer, to write the message</param>
        public static void Log(string logMessage, TextWriter w)
        {
            w.Write("\r\nLog Entry : ");
            w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
                DateTime.Now.ToLongDateString());
            w.WriteLine("  :");
            w.WriteLine("  :{0}", logMessage);
            w.WriteLine("-------------------------------");
        }


        public void connectDB()
        {
            dc = new NBADataContext(connectionString);

            try
            {
                if (!dc.DatabaseExists())
                {
                    dc.CreateDatabase();
                }

            }
            catch (SqlException ex)
            {
                DataBaseException fault = new DataBaseException();
                fault.Message = "Unable to connect data base: " + ex.Message;
                throw new FaultException<DataBaseException>(fault, new FaultReason("Unable to connect data base: " + ex.Message));
            }
            catch (Exception ex)
            {
                DataBaseException fault = new DataBaseException();
                fault.Message = "Unable to connect data base: " + ex.Message;
                throw new FaultException<DataBaseException>(fault, new FaultReason("Unable to connect data base: " + ex.Message));
            }
        }

        /// <summary>
        /// send a broadcast message from the user to all the connected user.
        /// inform the user about new changes on the database
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="caption"></param>
        public void broadCast(string msg,string caption)
        {
            for (int i = _callbackChannels.Count - 1; i >= 0; i--)
            {
                if (((ICommunicationObject)_callbackChannels[i]).State != CommunicationState.Opened)
                {
                    /* If the state of the channel is no longer opened or if the channel throws 
                       any sort of exception it is removed from the Callback Channel list. */
                    Console.WriteLine("Detected Non-Open Callback Channel: {0}", _callbackChannels[i].GetHashCode());
                    _callbackChannels.RemoveAt(i);
                    continue;
                }

                try
                {
                    _callbackChannels[i].broadcastUpdate(msg, caption);               
                    Console.WriteLine("Broad casted update on Channel: {0}", _callbackChannels[i].GetHashCode());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Service threw exception while communicating on Callback Channel: {0}", _callbackChannels[i].GetHashCode());
                    Console.WriteLine("Exception Type: {0} Description: {1}", ex.GetType(), ex.Message);
                    _callbackChannels.RemoveAt(i);
                }
            }
        }
        /// <summary>
        /// The Connect operation grabs the Callback Channel of the client and 
        /// checks if it is not already stored in the Callback Channel list – 
        /// if not then it is added to the list.  
        /// </summary>

        public void Connect()
        {
            try
            {
                IDuplexCallBack callbackChannel =
                    OperationContext.Current.GetCallbackChannel<IDuplexCallBack>();

                lock (_sycnRoot)
                {
                    if (!_callbackChannels.Contains(callbackChannel))
                    {
                        _callbackChannels.Add(callbackChannel);
                        Console.WriteLine("Added Callback Channel: {0}", callbackChannel.GetHashCode());
                    }
                }
            }
            catch
            {
            }
        }

        /// <summary>
        /// The Disconnect operation just grabs the Callback Channel of the 
        /// client and attempts to remove the channel from the list
        /// </summary>
        public void Disconnect()
        {
            IDuplexCallBack callbackChannel =
        OperationContext.Current.GetCallbackChannel<IDuplexCallBack>();

            try
            {
                lock (_sycnRoot)
                {
                    if (_callbackChannels.Remove(callbackChannel))
                    {
                        Console.WriteLine("Removed Callback Channel: {0}", callbackChannel.GetHashCode());
                    }
                }
            }
            catch
            {
            }
        }


        //QUERIES


        public bool CheckContainingUser(string userName)
        {
            lock (_sycnRoot)
            {
                    var users = from u in dc.Users
                                where u.UserName == userName
                                select u;

                    if (users.Count() != 0)
                    {
                        return true;
                    }
                return false;         
            }
        }

        public bool CheckPassword(string userName, string password)
        {
            lock (_sycnRoot)
            {
                var user = from u in dc.Users
                           where u.UserName == userName && u.Password == password
                           select u;
                if (user.Count() != 0)
                    return true;
                else
                    return false;
            }
        }


        public bool CheckAdmin(string userName)
        {
            lock (_sycnRoot)
            {
                var user = from u in dc.Users
                           where u.UserName == userName && u.Admin == true
                           select u;
                if (user.Count() != 0)
                    return true;
                else
                    return false;
            }
        }

        public IEnumerable<string> UploadTeam()
        {
            lock (_sycnRoot)
            {
                var teams = from t in dc.Teams
                            select new
                            {
                                t.TeamName
                            };

                foreach (var team in teams)
                {
                    yield return team.TeamName;
                }
            }
        }

        public IEnumerable<string> UploadAgents()
        {
            lock (_sycnRoot)
            {
                var agents = from a in dc.Agents
                            select new
                            {
                                a.AgentName
                            };

                foreach (var agent in agents)
                {
                    yield return agent.AgentName;
                }
            }
        }

        public IEnumerable<string> UploadPlayers(string homeTeam, string awayTeam)
        {
            lock (_sycnRoot)
            {
                var players = from t in dc.Teams
                              from p in t.Players
                              where t.TeamName == homeTeam || t.TeamName == awayTeam
                              select new
                              {
                                  name = p.PlayerName,
                                  team = p.TeamName
                              };
                foreach (var player in players)
                {
                    yield return player.name + " " + player.team;
                }
            }
        }

        public IEnumerable<string> UploadPlayersNoArg()
        {
            lock (_sycnRoot)
            {
                var players = from p in dc.Players
                              orderby p.PlayerName ascending
                              select new
                              {
                                  p.PlayerName,
                                  p.TeamName
                              };
                foreach (var player in players)
                {
                    yield return player.PlayerName + " " + player.TeamName;
                }
            }
        }

        public IEnumerable<string[]> UploadPlayersWinners()
        {
            lock (_sycnRoot)
            {
                var players = from p in dc.Players
                              orderby p.NumberOfTitles descending
                              select p;
                foreach (var player in players)
                {
                    yield return new string[] { player.PlayerName, player.TeamName, Convert.ToString(player.NumberOfTitles) };
                }
            }
        }

        public IEnumerable<string[]> UploadManagersWinners()
        {
            lock (_sycnRoot)
            {
                var managers = from m in dc.Managers
                               orderby m.NumberOfTitles descending
                               select m;
                foreach (var manager in managers)
                {
                    yield return new string[] { manager.ManagerName, manager.TeamName, Convert.ToString(manager.NumberOfTitles) };
                }
            }
        }

        public IEnumerable<string[]> UploadTeamsWinners()
        {
            lock (_sycnRoot)
            {
                var teams = from t in dc.Teams
                            orderby t.Championships descending
                            select t;
                foreach (var team in teams)
                {
                    yield return new string[] { team.TeamName, Convert.ToString(team.Championships) };
                }
            }
        }

        public IEnumerable<string> UploadByString(string str, string teamName)
        {
            lock (_sycnRoot)
            {
                if (str == "Manager")
                {
                    var managers = from m in dc.Managers
                                   where m.TeamName == teamName
                                   select new
                                   {
                                       m.ManagerName,
                                   };
                    foreach (var manager in managers)
                    {
                        yield return manager.ManagerName;
                    }
                }
                else
                {
                    var palyers = from p in dc.Players
                                  where p.TeamName == teamName
                                  select new
                                  {
                                      p.PlayerName,
                                  };
                    foreach (var player in palyers)
                    {
                        yield return player.PlayerName;
                    }
                }
            }
        }

        public IEnumerable<object[]> UploadTableLeague(string region)
        {
            lock (_sycnRoot)
            {
                object[] rowReturn = new object[5];
                var teams = from t in dc.Teams
                            where t.Region == region
                            select new
                            {
                                t.TeamName,
                                t.Wins,
                                t.Losses
                            };
                foreach (var team in teams)
                {
                    rowReturn[0] = team.TeamName;
                    rowReturn[1] = team.Losses + team.Wins;
                    rowReturn[2] = team.Wins;
                    rowReturn[3] = team.Losses;
                    rowReturn[4] = team.Wins * 2 + team.Losses;
                    yield return rowReturn;

                }
            }
        }

        public Players FindPlayers(string playerToFind)
        {
            lock (_sycnRoot)
            {
                var players = from p in dc.Players
                              where p.PlayerName == playerToFind.Substring(0, p.PlayerName.Length) &&
                              p.TeamName == playerToFind.Substring(p.PlayerName.Length + 1, (p.PlayerName.Length + playerToFind.Length))
                              select p;
                foreach (var player in players)
                {
                    return (Players)player;
                }
                return null;
            }
        }

        public IEnumerable<string> AdvanceSearchPlayers(int age1, int age2, int wins1, int wins2, int managerAge1, int managerAge2)
        {
            var players = from t in dc.Teams
                          from p in t.Players
                          where t.Wins >= wins1 && t.Wins <= wins2 &&
                                p.Age >= age1 && p.Age <= age2 &&
                                t.Managers.Age >= managerAge1 && t.Managers.Age <= managerAge2
                          select new
                          {
                              p.PlayerName,
                              p.TeamName
                          };
            foreach (var player in players)
            {
                yield return player.PlayerName + " " + player.TeamName;

            }

        }

        public IEnumerable<string> AdvanceSearchTeams(int squadAmount1, int squadAmount2, int managerExp1, int managerExp2, string region)
        {
            var teams = from t in dc.Teams
                        where t.Players.Count >= squadAmount1 && t.Players.Count <= squadAmount2 &&
                              t.Managers.ExperienceYears >= managerExp1 && t.Managers.ExperienceYears <= managerExp2 &&
                              t.Region == region
                        select new
                        {
                            t.TeamName
                        };

            foreach (var team in teams)
            {
                yield return team.TeamName;
            }
        }

        public IEnumerable<Player> GetSquad(string teamName)
        {
            var players = from p in dc.Players
                        where p.TeamName == teamName
                        select p;
            foreach (var player in players)
            {

                yield return new Player
                {
                    Age = player.Age,
                    ExeperienceYears = player.ExeperienceYears,
                    Height = player.Height,
                    Weight = player.Weight,
                    MVP = player.MVP,
                    NumberOfTitles = player.NumberOfTitles,
                    PlayerName = player.PlayerName,
                    Position = player.Position,
                    TeamName = player.TeamName
                };
            }
        }


        //DATA BASE GLOBAL
        public void InsertUser(string userName, string password)
        {
            lock (_sycnRoot)
            {
                dc.GetTable<Users>().InsertOnSubmit(new Users
                {
                    UserName = userName,
                    Password = password
                });

                /* save the changes on the data base */
                try
                {
                    dc.SubmitChanges();
                    using (StreamWriter w = File.AppendText("NbaLog.txt"))
                    {
                        Log("New user insert: " + userName, w);
                    }
                }
                catch (SqlException ex)
                {
                    DataBaseException fault = new DataBaseException();
                    fault.Message = "Unable to insert user: " + ex.Message;
                    throw new FaultException<DataBaseException>(fault, new FaultReason("Unable to insert user: " + ex.Message));
                }
                catch (Exception ex)
                {
                    DataBaseException fault = new DataBaseException();
                    fault.Message = "Unable to insert user: " + ex.Message;
                    throw new FaultException<DataBaseException>(fault, new FaultReason("Unable to insert user: " + ex.Message));
                }
            }
        }

        public void InsertPlayer(string playerName, string teamName, int age, double height, double weight, string position, int expYears, int titles, byte[] file_byte, string agent)
        {
            lock (_sycnRoot)
            {
                var playersTable = dc.GetTable<Players>();
                try
                {
                    System.Data.Linq.Binary file_binary = new System.Data.Linq.Binary(file_byte);
                    playersTable.InsertOnSubmit(new Players()
                    {
                        PlayerName = playerName,
                        TeamName = teamName,
                        Age = age,
                        Height = height,
                        Weight = weight,
                        Position = position,
                        ExeperienceYears = expYears,
                        NumberOfTitles = titles,
                        Picture = file_binary,
                        AgentName = agent,
                        MVP = 0
                    });
                    dc.SubmitChanges();
                    using (StreamWriter w = File.AppendText("NbaLog.txt"))
                    {
                        Log("New player insert: " + playerName, w);
                    }
                }
                catch (SqlException ex)
                {
                    DataBaseException fault = new DataBaseException();
                    fault.Message = "Unable to insert player: " + ex.Message;
                    throw new FaultException<DataBaseException>(fault, new FaultReason("Unable to insert player: " + ex.Message));
                }
                catch (Exception ex)
                {
                    DataBaseException fault = new DataBaseException();
                    fault.Message = "Unable to insert player: " + ex.Message;
                    throw new FaultException<DataBaseException>(fault, new FaultReason("Unable to insert player: " + ex.Message));
                }
                broadCast("player " + playerName + " was added to data base!", "Add Player");
            }
        }

        public void InsertManager(string managerName, string team, int age, int expYears, int titles)
        {
            lock (_sycnRoot)
            {
                var managersTable = dc.GetTable<Managers>();
                try
                {
                    managersTable.InsertOnSubmit(new Managers()
                    {
                        ManagerName = managerName,
                        TeamName = team,
                        Age = age,
                        ExperienceYears = expYears,
                        NumberOfTitles = titles

                    });
                    dc.SubmitChanges();
                    using (StreamWriter w = File.AppendText("NbaLog.txt"))
                    {
                        Log("New manager insert: " + managerName, w);
                    }
                }
                catch (SqlException ex)
                {
                    DataBaseException fault = new DataBaseException();
                    fault.Message = "Manager insertion exception: " + ex.Message;
                    throw new FaultException<DataBaseException>(fault, new FaultReason("Manager insertion exception: " + ex.Message));
                }
                catch (Exception ex)
                {
                    DataBaseException fault = new DataBaseException();
                    fault.Message = "Manager insertion exception: " + ex.Message;
                    throw new FaultException<DataBaseException>(fault, new FaultReason("Manager insertion exception: " + ex.Message));
                }
                broadCast("manager " + managerName + " was added to data base!","Add Manager");
            }
        }

        public void InsertGame(string homeTeam, string awayTeam, string MVP, DateTime gameDate, int homeScore, int awayScore, int fixtures)
        {
            lock (_sycnRoot)
            {
                var gamesTable = dc.GetTable<Games>();
                try
                {
                    gamesTable.InsertOnSubmit(new Games()
                    {
                        HomeTeam = homeTeam,
                        AwayTeam = awayTeam,
                        MVP = MVP,
                        GameDate = gameDate,
                        AwayTeamScore = homeScore,
                        HomeTeamScore = awayScore,
                        Fixture = fixtures
                    });

                    dc.SubmitChanges();
                    using (StreamWriter w = File.AppendText("NbaLog.txt"))
                    {
                        Log("New game insert: " + homeTeam + " - " + awayTeam + ", fixture: " + fixtures , w);
                    }

                }
                catch (SqlException ex)
                {
                    DataBaseException fault = new DataBaseException();
                    fault.Message = "Manager insertion exception: " + ex.Message;
                    throw new FaultException<DataBaseException>(fault, new FaultReason("Game insertion exception: " + ex.Message));
                }
                catch (Exception ex)
                {
                    DataBaseException fault = new DataBaseException();
                    fault.Message = "Manager insertion exception: " + ex.Message;
                    throw new FaultException<DataBaseException>(fault, new FaultReason("Game insertion exception: " + ex.Message));
                }
                broadCast("game " + homeTeam + " vs " + awayTeam + " was added to data base!","Add Game");
            }

        }

        public void UpdateWinAndLose(string win, string lose)
        {
            lock (_sycnRoot)
            {
                try
                {
                    var teamWin = from t in dc.Teams
                                  where t.TeamName == win
                                  select t;
                    foreach (var team in teamWin)
                    {
                        team.Wins++;
                        using (StreamWriter w = File.AppendText("NbaLog.txt"))
                        {
                            Log("Update team " + team.TeamName + " wins" , w);
                        }
                    }
                    var teamLost = from t in dc.Teams
                                   where t.TeamName == lose
                                   select t;
                    foreach (var team in teamLost)
                    {
                        team.Losses++;
                        using (StreamWriter w = File.AppendText("NbaLog.txt"))
                        {
                            Log("Update team " + team.TeamName + " losses", w);
                        }
                    }
                    dc.SubmitChanges();
                }
                catch (SqlException ex)
                {
                    DataBaseException fault = new DataBaseException();
                    fault.Message = "Update win and losses exception: " + ex.Message;
                    throw new FaultException<DataBaseException>(fault, new FaultReason("Update win and losses exception: " + ex.Message));
                }
                catch (Exception ex)
                {
                    DataBaseException fault = new DataBaseException();
                    fault.Message = "Update win and losses exception: " + ex.Message;
                    throw new FaultException<DataBaseException>(fault, new FaultReason("Update win and losses exception: " + ex.Message));
                }
            }
        }

        public void UpdateMVP(string playerMVP)
        {
            lock (_sycnRoot)
            {
                try
                {
                    var players = from p in dc.Players
                                  where p.PlayerName == playerMVP.Substring(0, p.PlayerName.Length) &&
                                  p.TeamName == playerMVP.Substring(p.PlayerName.Length + 1, p.TeamName.Length)

                                  select p;

                    foreach (var player in players)
                    {
                        player.MVP++;
                        dc.SubmitChanges();
                        using (StreamWriter w = File.AppendText("NbaLog.txt"))
                        {
                            Log("Update player: " + player.PlayerName, w);
                        }
                    }

                }
                catch (SqlException ex)
                {
                    DataBaseException fault = new DataBaseException();
                    fault.Message = "Update MVP exception: " + ex.Message;
                    throw new FaultException<DataBaseException>(fault, new FaultReason("Update MVP exception: " + ex.Message));
                }
                catch (Exception ex)
                {
                    DataBaseException fault = new DataBaseException();
                    fault.Message = "Update MVP exception: " + ex.Message;
                    throw new FaultException<DataBaseException>(fault, new FaultReason("Update MVP exception: " + ex.Message));
                }
            }
        }

        public void DeletePlayer(string playerName, string team)
        {
            lock (_sycnRoot)
            {
                var deletePlayer = from t in dc.Teams
                                   from p in t.Players
                                   where t.TeamName == team && p.PlayerName == playerName
                                   select p;

                foreach (var player in deletePlayer)
                {
                    try
                    {
                        dc.Players.DeleteOnSubmit(player);
                        dc.SubmitChanges();
                        using (StreamWriter w = File.AppendText("NbaLog.txt"))
                        {
                            Log("Delete player: " + player.PlayerName, w);
                        }
                    }
                    catch (SqlException ex)
                    {
                        DataBaseException fault = new DataBaseException();
                        fault.Message = "Delete player exception: " + ex.Message;
                        throw new FaultException<DataBaseException>(fault, new FaultReason("Delete player exception: " + ex.Message));
                    }
                    catch (Exception ex)
                    {
                        DataBaseException fault = new DataBaseException();
                        fault.Message = "Delete player exception: " + ex.Message;
                        throw new FaultException<DataBaseException>(fault, new FaultReason("Delete player exception: " + ex.Message));
                    }
                }
                broadCast(playerName + " was deleted!","Delete Player");
            }
        }

        public void DeleteManager(string managerName, string team)
        {
            lock (_sycnRoot)
            {
                var deleteManager = from t in dc.Teams
                                    where t.TeamName == team && t.Managers.ManagerName == managerName
                                    select t.Managers;

                foreach (var manager in deleteManager)
                {
                    try
                    {
                        dc.Managers.DeleteOnSubmit(manager);
                        dc.SubmitChanges();
                        using (StreamWriter w = File.AppendText("NbaLog.txt"))
                        {
                            Log("Delete manager: " + manager.ManagerName, w);
                        }
                    }
                    catch (SqlException ex)
                    {
                        DataBaseException fault = new DataBaseException();
                        fault.Message = "Delete player exception: " + ex.Message;
                        throw new FaultException<DataBaseException>(fault, new FaultReason("Delete player exception: " + ex.Message));
                    }
                    catch (Exception ex)
                    {
                        DataBaseException fault = new DataBaseException();
                        fault.Message = "Delete player exception: " + ex.Message;
                        throw new FaultException<DataBaseException>(fault, new FaultReason("Delete player exception: " + ex.Message));
                    }
                }
                broadCast(managerName + " was deleted!","Delete Manager");
            }
        }

        public Player getPlayer(string playerName, string teamName)
        {
            lock (_sycnRoot)
            {
                var players = from t in dc.Teams
                             from p in t.Players
                             where t.TeamName == teamName && p.PlayerName == playerName
                             select p;
                foreach (var nbaPlayer in players)
                {
                    return new Player
                    {
                        Age = nbaPlayer.Age,
                        ExeperienceYears = nbaPlayer.ExeperienceYears,
                        Height = nbaPlayer.Height,
                        Weight = nbaPlayer.Weight,
                        MVP = nbaPlayer.MVP,
                        NumberOfTitles = nbaPlayer.NumberOfTitles,
                        PlayerName = nbaPlayer.PlayerName,
                        Position = nbaPlayer.Position,
                        TeamName = nbaPlayer.TeamName                      
                    };
                }
                return null;
            }
        }

        Player IDuplexService.FindPlayers(string playerToFind)
        {
            lock (_sycnRoot)
            {
                var players = from p in dc.Players
                              where p.PlayerName == playerToFind.Substring(0, p.PlayerName.Length) &&
                              p.TeamName == playerToFind.Substring(p.PlayerName.Length + 1, (p.PlayerName.Length + playerToFind.Length))
                              select p;
                foreach (var nbaPlayer in players)
                {              
                    return new Player
                    {
                        Age = nbaPlayer.Age,
                        ExeperienceYears = nbaPlayer.ExeperienceYears,
                        Height = nbaPlayer.Height,
                        Weight = nbaPlayer.Weight,
                        MVP = nbaPlayer.MVP,
                        NumberOfTitles = nbaPlayer.NumberOfTitles,
                        PlayerName = nbaPlayer.PlayerName,
                        Position = nbaPlayer.Position,
                        TeamName = nbaPlayer.TeamName
                    };
                }
                return null;
            }
        }

        public byte[] retireveImageFromDb(string playerName)
        {

            lock (_sycnRoot)
            {
                // Get as single image from the database
                var img = (from player in dc.Players
                           where player.PlayerName == playerName
                           select player.Picture).Single();
                return img.ToArray();
            }
        }


    }
}

