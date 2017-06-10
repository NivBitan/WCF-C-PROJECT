using System;
using System.Collections.Generic;
using WcfDuplexServiceInterface;
using System.ServiceModel;

namespace WcfDuplexServiceClient
{
    internal class WcfDuplexServiceClient : DuplexClientBase<IDuplexService>, IDuplexService
    {
        public WcfDuplexServiceClient(InstanceContext callbackInstance, WSDualHttpBinding binding, EndpointAddress endpointAddress)
            : base(callbackInstance, binding, endpointAddress) { }

        public void Connect()
        {
            Channel.Connect();
        }

        public void connectDB()
        {
            Channel.connectDB();
        }

        public void Disconnect()
        {
            Channel.Disconnect();
        }


        //QUERIES
        public bool CheckContainingUser(string userName)
        {
            return Channel.CheckContainingUser(userName);
        }

        public bool CheckPassword(string userName, string password)
        {
            return Channel.CheckPassword(userName, password);
        }

        public bool CheckAdmin(string userName)
        {
            return Channel.CheckAdmin(userName);
        }

        public IEnumerable<string> AdvanceSearchTeams(int squadAmount1, int squadAmount2, int managerExp1, int managerExp2, string region)
        {
            return Channel.AdvanceSearchTeams(squadAmount1, squadAmount2, managerExp1, managerExp2, region);
        }

        public IEnumerable<string> UploadTeam()
        {
            return Channel.UploadTeam();
        }

        public IEnumerable<string> UploadAgents()
        {
            return Channel.UploadAgents();
        }

        public IEnumerable<string> UploadPlayers(string homeTeam, string awayTeam)
        {
            return Channel.UploadPlayers(homeTeam, awayTeam);
        }

        public IEnumerable<string> UploadPlayersNoArg()
        {
            return Channel.UploadPlayersNoArg();
        }

        public IEnumerable<string[]> UploadPlayersWinners()
        {
            return Channel.UploadPlayersWinners();
        }

        public IEnumerable<string[]> UploadManagersWinners()
        {
            return Channel.UploadManagersWinners();
        }

        public IEnumerable<string[]> UploadTeamsWinners()
        {
            return Channel.UploadTeamsWinners();
        }

        public IEnumerable<string> UploadByString(string str, string teamName)
        {
            return Channel.UploadByString(str, teamName);
        }

        public IEnumerable<object[]> UploadTableLeague(string region)
        {
            return Channel.UploadTableLeague(region);
        }


        public IEnumerable<string> AdvanceSearchPlayers(int age1, int age2, int wins1, int wins2, int managerAge1, int managerAge2)
        {
            return Channel.AdvanceSearchPlayers(age1, age2, wins1, wins2, managerAge1, managerAge2);
        }


        public Player getPlayer(string playerName, string teamName)
        {
            return Channel.getPlayer(playerName, teamName);
        }

        public Player FindPlayers(string playerToFind)
        {
            return Channel.FindPlayers(playerToFind);
        }

        public IEnumerable<Player> GetSquad(string teamName)
        {
            return Channel.GetSquad(teamName);
        } 

        //DATA BASE GLOBAL
        public void InsertUser(string userName, string password)
        {
            try
            {
                Channel.InsertUser(userName, password);
            }
            catch (FaultException<DataBaseException> ex)
            {
                throw ex;
            }
            
        }

        public void InsertPlayer(string playerName, string teamName, int age, double height, double weight, string position, int expYears, int titles, byte[] file_byte, string agent)
        {
            try
            {
                Channel.InsertPlayer(playerName, teamName, age, height, weight, position, expYears, titles, file_byte, agent);
            }
            catch (FaultException<DataBaseException> ex)
            {
                throw ex;
            }
           
        }

        public void InsertManager(string managerName, string team, int age, int expYears, int titles)
        {
            try
            {
                Channel.InsertManager(managerName, team, age, expYears, titles);
            }
            catch(FaultException<DataBaseException> ex)
            {
                throw ex;
            }
        }

        public void InsertGame(string homeTeam, string awayTeam, string MVP, DateTime gameDate, int homeScore, int awayScore, int fixtures)
        {
            try
            {
                Channel.InsertGame(homeTeam, awayTeam, MVP, gameDate, homeScore, awayScore, fixtures);
            }
            catch (FaultException<DataBaseException> ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }

        public void UpdateWinAndLose(string win, string lose)
        {
            try
            {
                Channel.UpdateWinAndLose(win, lose);
            }
            catch (FaultException<DataBaseException> ex)
            {
                throw ex;
            }
           
        }

        public void UpdateMVP(string playerMVP)
        {
            try
            {
                Channel.UpdateMVP(playerMVP);
            }
            catch (FaultException<DataBaseException> ex)
            {
                throw ex;
            }
            
        }

        public void DeletePlayer(string playerName, string team)
        {
            try
            {
                Channel.DeletePlayer(playerName, team);
            }
            catch (FaultException<DataBaseException> ex)
            {
                throw ex;
            }
            
        }

        public void DeleteManager(string managerName, string team)
        {
            try
            {
                Channel.DeleteManager(managerName, team);
            }
            catch (FaultException<DataBaseException> ex)
            {
                throw ex;
            }
            
        }



        public byte[] retireveImageFromDb(string playerName)
        {
            return Channel.retireveImageFromDb(playerName);
        }

    }
}

