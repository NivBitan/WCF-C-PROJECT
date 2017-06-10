using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

/* Service Contract – An interface for stating which operations a given service supports. 
   This component is known to both client and server as it is an agreement 
   of what operations a service will provide to a client. */
   
namespace WcfDuplexServiceInterface
{
    /* One-Way operations help prevent deadlock scenarios in duplex services.
      you can think of One-Way operations as fire-and-forget operations where the 
      sender simply makes the request and does not wait for a response  */

    /* FaultContract operations specify an OperationContract that can throw a FaultException */

    [ServiceContract(CallbackContract = typeof(IDuplexCallBack))]
    public interface IDuplexService
    {
        /// <summary>
        /// The Connect operation grabs the Callback Channel of the client and 
        /// checks if it is not already stored in the Callback Channel list – 
        /// if not then it is added to the list.  
        /// </summary>
        [OperationContract(IsOneWay = true)]
        void Connect();

        /// <summary>
        /// the connectDB operation connects to the data base using the 
        /// connection string. if data base does not exists creates a new one.
        /// </summary>
        [OperationContract(IsOneWay = true)]
        void connectDB();

        /// <summary>
        /// The Disconnect operation just grabs the Callback Channel of the 
        /// client and attempts to remove the channel from the list
        /// </summary>
        [OperationContract(IsOneWay = true)]
        void Disconnect();

        /// <summary>
        /// returns true if user exists in data base, else returns false.
        /// </summary>
        /// <param name="userName"></param>
        /// <returns>True - if found a user, False - if not</returns>
        [OperationContract(IsOneWay = false)]
        [FaultContract(typeof(InvalidUserException))]
        bool CheckContainingUser(string userName);

        /// <summary>
        /// the CheckPassword operation returns true if given password to the username 
        /// is correct, else false.
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        [OperationContract(IsOneWay = false)]
        bool CheckPassword(string userName, string password);

        /// <summary>
        /// the CheckAdmin operation returns true if username is admin, else false.
        /// </summary>
        /// <param name="userName"></param>
        /// <returns>True - found admin, False - not</returns>
        [OperationContract(IsOneWay = false)]
        bool CheckAdmin(string userName);

        /// <summary>
        /// returns IEnumerable<string> of all teams in data base.
        /// </summary>
        /// <returns>set of teams</returns>
        [OperationContract(IsOneWay = false)]
        IEnumerable<string> UploadTeam();

        /// <summary>
        /// returns IEnumerable<string> of all agents in data base.
        /// </summary>
        /// <returns>set of all agents</returns>
        [OperationContract(IsOneWay = false)]
        IEnumerable<string> UploadAgents();

        /// <summary>
        /// returns IEnumerable<string> of all players in "homeTeam" and "awayTeam".
        /// </summary>
        /// <param name="homeTeam"></param>
        /// <param name="awayTeam"></param>
        /// <returns>set of players</returns>
        [OperationContract(IsOneWay = false)]
        IEnumerable<string> UploadPlayers(string homeTeam, string awayTeam);

        /// <summary>
        /// returns IEnumerable<string> of all players in data base.
        /// </summary>
        /// <returns>set of players</returns>
        [OperationContract(IsOneWay = false)]
        IEnumerable<string> UploadPlayersNoArg();

        /// <summary>
        /// returns IEnumerable<string> of players in descending order of NumberOfTitles.
        /// </summary>
        /// <returns>set of players</returns>
        [OperationContract(IsOneWay = false)]
        IEnumerable<string[]> UploadPlayersWinners();

        /// <summary>
        /// returns IEnumerable<string> of managers in descending order of NumberOfTitles.
        /// </summary>
        /// <returns>set of managers</returns>
        [OperationContract(IsOneWay = false)]
        IEnumerable<string[]> UploadManagersWinners();

        /// <summary>
        /// returns IEnumerable<string> of teams in descending order of Championships.
        /// </summary>
        /// <returns>set of teams</returns>
        [OperationContract(IsOneWay = false)]
        IEnumerable<string[]> UploadTeamsWinners();

        /// <summary>
        /// returns IEnumerable<string> of players or manager in teamName
        /// </summary>
        /// <param name="str">indicate if manager or player</param>
        /// <param name="teamName"></param>
        /// <returns>set players or managers</returns>
        [OperationContract(IsOneWay = false)]
        IEnumerable<string> UploadByString(string str, string teamName);

        /// <summary>
        /// returns IEnumerable<object[]> contaning rows of the leaugues table.
        /// </summary>
        /// <param name="region"></param>
        /// <returns>set of teams</returns>
        [OperationContract(IsOneWay = false)]
        IEnumerable<object[]> UploadTableLeague(string region);

        /// <summary>
        /// returns a Player from data base by player name.
        /// </summary>
        /// <param name="playerToFind"></param>
        /// <returns>if found return a player, else - null</returns>
        [OperationContract(IsOneWay = false)]
        Player FindPlayers(string playerToFind);

        /// <summary>
        /// returns IEnumerable<string> of player name and team according to given paramaters.
        /// </summary>
        /// <param name="age1">lowest age</param>
        /// <param name="age2">highest age</param>
        /// <param name="wins1">lowest wins amount</param>
        /// <param name="wins2">highest wins amount</param>
        /// <param name="managerAge1">lowest age manager</param>
        /// <param name="managerAge2">highest age manager</param>
        /// <returns>set of players</returns>
        [OperationContract(IsOneWay = false)]
        IEnumerable<string> AdvanceSearchPlayers(int age1, int age2, int wins1, int wins2, int managerAge1, int managerAge2);

        /// <summary>
        /// returns IEnumerable<string> of team name according to given paramaters.
        /// </summary>
        /// <param name="squadAmount1">lowest squad amount</param>
        /// <param name="squadAmount2">highest squad amount</param>
        /// <param name="managerExp1">lowest manager experience</param>
        /// <param name="managerExp2">highest manager experience</param>
        /// <param name="region">team's region</param>
        /// <returns>set of teams</returns>
        [OperationContract(IsOneWay = false)]
        IEnumerable<string> AdvanceSearchTeams(int squadAmount1, int squadAmount2, int managerExp1, int managerExp2, string region);

        /// <summary>
        /// returns IEnumerable<Player> of Player for each player in teamName.
        /// </summary>
        /// <param name="teamName"></param>
        /// <returns>set of players</returns>
        [OperationContract(IsOneWay = false)]
        IEnumerable<Player> GetSquad(string teamName);

        /// <summary>
        /// returns a Player by playerName and teamName
        /// </summary>
        /// <param name="playerName"></param>
        /// <param name="teamName"></param>
        /// <returns></returns>
        [OperationContract(IsOneWay = false)]
        Player getPlayer(string playerName, string teamName);


        //DATA BASE GLOBAL

        /// <summary>
        /// Inserts a user to data base, with userName and password
        ///  - can throw FaultContract exception
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        [OperationContract]
        [FaultContract(typeof(DataBaseException))]
        void InsertUser(string userName, string password);

        /// <summary>
        /// Inserts a player to data base, with all of a players fields.
        /// - can throw FaultContract exception
        /// </summary>
        /// <param name="playerName"></param>
        /// <param name="teamName"></param>
        /// <param name="age"></param>
        /// <param name="height"></param>
        /// <param name="weight"></param>
        /// <param name="position"></param>
        /// <param name="expYears"></param>
        /// <param name="titles"></param>
        /// <param name="file_byte"></param>
        /// <param name="agent"></param>
        [OperationContract]
        [FaultContract(typeof(DataBaseException))]
        void InsertPlayer(string playerName, string teamName, int age, double height, double weight, string position, int expYears, int titles, byte[] file_byte, string agent);

        /// <summary>
        /// Inserts a manager to data base, with all of a managers fields.
        /// - can throw FaultContract exception
        /// </summary>
        /// <param name="managerName"></param>
        /// <param name="team"></param>
        /// <param name="age"></param>
        /// <param name="expYears"></param>
        /// <param name="titles"></param>
        [OperationContract]
        [FaultContract(typeof(DataBaseException))]
        void InsertManager(string managerName, string team, int age, int expYears, int titles);

        /// <summary>
        /// Inserts a game to data base, with all of a games fields.
        /// - can throw FaultContract exception
        /// </summary>
        /// <param name="homeTeam"></param>
        /// <param name="awayTeam"></param>
        /// <param name="MVP"></param>
        /// <param name="gameDate"></param>
        /// <param name="homeScore"></param>
        /// <param name="awayScore"></param>
        /// <param name="fixtures"></param>
        [OperationContract(IsOneWay = false)]
        [FaultContract(typeof(DataBaseException))]
        void InsertGame(string homeTeam, string awayTeam, string MVP, DateTime gameDate, int homeScore, int awayScore, int fixtures);

        /// <summary>
        /// updates number of wins and loses of a team.
        /// - can throw FaultContract exception
        /// </summary>
        /// <param name="win"></param>
        /// <param name="lose"></param>
        [OperationContract(IsOneWay = false)]
        [FaultContract(typeof(DataBaseException))]
        void UpdateWinAndLose(string win, string lose);

        /// <summary>
        /// updates number of mvp's for a player.
        /// - can throw FaultContract exception
        /// </summary>
        /// <param name="playerMVP"></param>
        [OperationContract]
        [FaultContract(typeof(DataBaseException))]
        void UpdateMVP(string playerMVP);

        /// <summary>
        /// removes a players from database by player name and team.
        /// - can throw FaultContract exception
        /// </summary>
        /// <param name="playerName"></param>
        /// <param name="team"></param>
        [OperationContract]
        [FaultContract(typeof(DataBaseException))]
        void DeletePlayer(string playerName, string team);

        /// <summary>
        /// removes a manager from database by manager name and team.
        /// - can throw FaultContract exception
        /// </summary>
        /// <param name="managerName"></param>
        /// <param name="team"></param>
        [OperationContract]
        [FaultContract(typeof(DataBaseException))]
        void DeleteManager(string managerName, string team);



        //[OperationContract(IsOneWay = true)]
        //void storeImageToDb(byte[] img, string imgName);

        /// <summary>
        /// returns a byte[] of a image by playerName.
        /// </summary>
        /// <param name="playerName"></param>
        /// <returns></returns>
        [OperationContract(IsOneWay = false)]
        byte[] retireveImageFromDb(string playerName);

    }

    /* The DataContract is a formal definition of a type that can be 
       understood on both sides of the service boundary. */


    /// <summary>
    /// generic FaultExcpetions: InvalidUserException & DataBaseException thrown by the service.
    /// </summary>
    [DataContract]
    public class InvalidUserException
    {
        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public string Reason { get; set; }
    }

    [DataContract]
    public class DataBaseException
    {
        [DataMember]
        public string Message { get; set; }
    }

    [DataContract]
    public class Player
    {
        [DataMember]
        private string _PlayerName;

        [DataMember]
        private string _TeamName;

        [DataMember]
        private int _NumberOfTitles;

        [DataMember]
        private double _Age;

        [DataMember]
        private double _Height;

        [DataMember]
        private double _Weight;

        [DataMember]
        private string _Position;

        [DataMember]
        private int _ExeperienceYears;

        [DataMember]
        private int _MVP;

        [DataMember]
        private string _imageName;

        [DataMember]
        private byte[] _Image;

        //GETTERS & SETTERS

        public byte[] Image
        {
            get
            {
                return _Image;
            }

            set
            {
                _Image = value;
            }
        }

        public string PlayerName
        {
            get
            {
                return _PlayerName;
            }

            set
            {
                _PlayerName = value;
            }
        }

        public string TeamName
        {
            get
            {
                return _TeamName;
            }

            set
            {
                _TeamName = value;
            }
        }

        public int NumberOfTitles
        {
            get
            {
                return _NumberOfTitles;
            }

            set
            {
                _NumberOfTitles = value;
            }
        }

        public double Age
        {
            get
            {
                return _Age;
            }

            set
            {
                _Age = value;
            }
        }

        public double Height
        {
            get
            {
                return _Height;
            }

            set
            {
                _Height = value;
            }
        }

        public double Weight
        {
            get
            {
                return _Weight;
            }

            set
            {
                _Weight = value;
            }
        }

        public string Position
        {
            get
            {
                return _Position;
            }

            set
            {
                _Position = value;
            }
        }

        public int ExeperienceYears
        {
            get
            {
                return _ExeperienceYears;
            }

            set
            {
                _ExeperienceYears = value;
            }
        }

        public int MVP
        {
            get
            {
                return _MVP;
            }

            set
            {
                _MVP = value;
            }
        }

        public string imageName
        {
            get
            {
                return _imageName;
            }

            set
            {
                _imageName = value;
            }
        }
    }
}
