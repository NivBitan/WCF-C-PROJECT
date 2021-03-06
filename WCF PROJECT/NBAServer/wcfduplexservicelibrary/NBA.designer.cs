﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFDuplexServiceLibrary
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="NBA_DBase13")]
	public partial class NBADataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertManagers(Managers instance);
    partial void UpdateManagers(Managers instance);
    partial void DeleteManagers(Managers instance);
    partial void InsertTeams(Teams instance);
    partial void UpdateTeams(Teams instance);
    partial void DeleteTeams(Teams instance);
    partial void InsertGames(Games instance);
    partial void UpdateGames(Games instance);
    partial void DeleteGames(Games instance);
    partial void InsertUsers(Users instance);
    partial void UpdateUsers(Users instance);
    partial void DeleteUsers(Users instance);
    partial void InsertPlayers(Players instance);
    partial void UpdatePlayers(Players instance);
    partial void DeletePlayers(Players instance);
    partial void InsertAgents(Agents instance);
    partial void UpdateAgents(Agents instance);
    partial void DeleteAgents(Agents instance);
    #endregion
		
		public NBADataContext() : 
				base(global::WCFDuplexServiceLibrary.Properties.Settings.Default.NBA_DBase13ConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public NBADataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public NBADataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public NBADataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public NBADataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Managers> Managers
		{
			get
			{
				return this.GetTable<Managers>();
			}
		}
		
		public System.Data.Linq.Table<Teams> Teams
		{
			get
			{
				return this.GetTable<Teams>();
			}
		}
		
		public System.Data.Linq.Table<Games> Games
		{
			get
			{
				return this.GetTable<Games>();
			}
		}
		
		public System.Data.Linq.Table<Users> Users
		{
			get
			{
				return this.GetTable<Users>();
			}
		}
		
		public System.Data.Linq.Table<Players> Players
		{
			get
			{
				return this.GetTable<Players>();
			}
		}
		
		public System.Data.Linq.Table<Agents> Agents
		{
			get
			{
				return this.GetTable<Agents>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="")]
	public partial class Managers : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _ManagerName;
		
		private string _TeamName;
		
		private int _Age;
		
		private int _ExperienceYears;
		
		private int _NumberOfTitles;
		
		private EntityRef<Teams> _Teams;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnManagerNameChanging(string value);
    partial void OnManagerNameChanged();
    partial void OnTeamNameChanging(string value);
    partial void OnTeamNameChanged();
    partial void OnAgeChanging(int value);
    partial void OnAgeChanged();
    partial void OnExperienceYearsChanging(int value);
    partial void OnExperienceYearsChanged();
    partial void OnNumberOfTitlesChanging(int value);
    partial void OnNumberOfTitlesChanged();
    #endregion
		
		public Managers()
		{
			this._Teams = default(EntityRef<Teams>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ManagerName", CanBeNull=false)]
		public string ManagerName
		{
			get
			{
				return this._ManagerName;
			}
			set
			{
				if ((this._ManagerName != value))
				{
					this.OnManagerNameChanging(value);
					this.SendPropertyChanging();
					this._ManagerName = value;
					this.SendPropertyChanged("ManagerName");
					this.OnManagerNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TeamName", CanBeNull=false, IsPrimaryKey=true)]
		public string TeamName
		{
			get
			{
				return this._TeamName;
			}
			set
			{
				if ((this._TeamName != value))
				{
					if (this._Teams.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnTeamNameChanging(value);
					this.SendPropertyChanging();
					this._TeamName = value;
					this.SendPropertyChanged("TeamName");
					this.OnTeamNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Age")]
		public int Age
		{
			get
			{
				return this._Age;
			}
			set
			{
				if ((this._Age != value))
				{
					this.OnAgeChanging(value);
					this.SendPropertyChanging();
					this._Age = value;
					this.SendPropertyChanged("Age");
					this.OnAgeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ExperienceYears")]
		public int ExperienceYears
		{
			get
			{
				return this._ExperienceYears;
			}
			set
			{
				if ((this._ExperienceYears != value))
				{
					this.OnExperienceYearsChanging(value);
					this.SendPropertyChanging();
					this._ExperienceYears = value;
					this.SendPropertyChanged("ExperienceYears");
					this.OnExperienceYearsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NumberOfTitles")]
		public int NumberOfTitles
		{
			get
			{
				return this._NumberOfTitles;
			}
			set
			{
				if ((this._NumberOfTitles != value))
				{
					this.OnNumberOfTitlesChanging(value);
					this.SendPropertyChanging();
					this._NumberOfTitles = value;
					this.SendPropertyChanged("NumberOfTitles");
					this.OnNumberOfTitlesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Teams_Managers", Storage="_Teams", ThisKey="TeamName", OtherKey="TeamName", IsForeignKey=true)]
		public Teams Teams
		{
			get
			{
				return this._Teams.Entity;
			}
			set
			{
				Teams previousValue = this._Teams.Entity;
				if (((previousValue != value) 
							|| (this._Teams.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Teams.Entity = null;
						previousValue.Managers = null;
					}
					this._Teams.Entity = value;
					if ((value != null))
					{
						value.Managers = this;
						this._TeamName = value.TeamName;
					}
					else
					{
						this._TeamName = default(string);
					}
					this.SendPropertyChanged("Teams");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="")]
	public partial class Teams : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _TeamName;
		
		private string _Region;
		
		private string _Arena;
		
		private string _Color;
		
		private int _Championships;
		
		private int _Wins;
		
		private int _Losses;
		
		private EntityRef<Managers> _Managers;
		
		private EntitySet<Games> _Games;
		
		private EntitySet<Games> _Games1;
		
		private EntitySet<Players> _Players;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTeamNameChanging(string value);
    partial void OnTeamNameChanged();
    partial void OnRegionChanging(string value);
    partial void OnRegionChanged();
    partial void OnArenaChanging(string value);
    partial void OnArenaChanged();
    partial void OnColorChanging(string value);
    partial void OnColorChanged();
    partial void OnChampionshipsChanging(int value);
    partial void OnChampionshipsChanged();
    partial void OnWinsChanging(int value);
    partial void OnWinsChanged();
    partial void OnLossesChanging(int value);
    partial void OnLossesChanged();
    #endregion
		
		public Teams()
		{
			this._Managers = default(EntityRef<Managers>);
			this._Games = new EntitySet<Games>(new Action<Games>(this.attach_Games), new Action<Games>(this.detach_Games));
			this._Games1 = new EntitySet<Games>(new Action<Games>(this.attach_Games1), new Action<Games>(this.detach_Games1));
			this._Players = new EntitySet<Players>(new Action<Players>(this.attach_Players), new Action<Players>(this.detach_Players));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TeamName", CanBeNull=false, IsPrimaryKey=true)]
		public string TeamName
		{
			get
			{
				return this._TeamName;
			}
			set
			{
				if ((this._TeamName != value))
				{
					this.OnTeamNameChanging(value);
					this.SendPropertyChanging();
					this._TeamName = value;
					this.SendPropertyChanged("TeamName");
					this.OnTeamNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Region", CanBeNull=false)]
		public string Region
		{
			get
			{
				return this._Region;
			}
			set
			{
				if ((this._Region != value))
				{
					this.OnRegionChanging(value);
					this.SendPropertyChanging();
					this._Region = value;
					this.SendPropertyChanged("Region");
					this.OnRegionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Arena", CanBeNull=false)]
		public string Arena
		{
			get
			{
				return this._Arena;
			}
			set
			{
				if ((this._Arena != value))
				{
					this.OnArenaChanging(value);
					this.SendPropertyChanging();
					this._Arena = value;
					this.SendPropertyChanged("Arena");
					this.OnArenaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Color", CanBeNull=false)]
		public string Color
		{
			get
			{
				return this._Color;
			}
			set
			{
				if ((this._Color != value))
				{
					this.OnColorChanging(value);
					this.SendPropertyChanging();
					this._Color = value;
					this.SendPropertyChanged("Color");
					this.OnColorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Championships")]
		public int Championships
		{
			get
			{
				return this._Championships;
			}
			set
			{
				if ((this._Championships != value))
				{
					this.OnChampionshipsChanging(value);
					this.SendPropertyChanging();
					this._Championships = value;
					this.SendPropertyChanged("Championships");
					this.OnChampionshipsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Wins")]
		public int Wins
		{
			get
			{
				return this._Wins;
			}
			set
			{
				if ((this._Wins != value))
				{
					this.OnWinsChanging(value);
					this.SendPropertyChanging();
					this._Wins = value;
					this.SendPropertyChanged("Wins");
					this.OnWinsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Losses")]
		public int Losses
		{
			get
			{
				return this._Losses;
			}
			set
			{
				if ((this._Losses != value))
				{
					this.OnLossesChanging(value);
					this.SendPropertyChanging();
					this._Losses = value;
					this.SendPropertyChanged("Losses");
					this.OnLossesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Teams_Managers", Storage="_Managers", ThisKey="TeamName", OtherKey="TeamName", IsUnique=true, IsForeignKey=false)]
		public Managers Managers
		{
			get
			{
				return this._Managers.Entity;
			}
			set
			{
				Managers previousValue = this._Managers.Entity;
				if (((previousValue != value) 
							|| (this._Managers.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Managers.Entity = null;
						previousValue.Teams = null;
					}
					this._Managers.Entity = value;
					if ((value != null))
					{
						value.Teams = this;
					}
					this.SendPropertyChanged("Managers");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Teams_Games", Storage="_Games", ThisKey="TeamName", OtherKey="HomeTeam")]
		public EntitySet<Games> Games
		{
			get
			{
				return this._Games;
			}
			set
			{
				this._Games.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Teams_Games1", Storage="_Games1", ThisKey="TeamName", OtherKey="AwayTeam")]
		public EntitySet<Games> Games1
		{
			get
			{
				return this._Games1;
			}
			set
			{
				this._Games1.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Teams_Players", Storage="_Players", ThisKey="TeamName", OtherKey="TeamName")]
		public EntitySet<Players> Players
		{
			get
			{
				return this._Players;
			}
			set
			{
				this._Players.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Games(Games entity)
		{
			this.SendPropertyChanging();
			entity.Teams = this;
		}
		
		private void detach_Games(Games entity)
		{
			this.SendPropertyChanging();
			entity.Teams = null;
		}
		
		private void attach_Games1(Games entity)
		{
			this.SendPropertyChanging();
			entity.Teams1 = this;
		}
		
		private void detach_Games1(Games entity)
		{
			this.SendPropertyChanging();
			entity.Teams1 = null;
		}
		
		private void attach_Players(Players entity)
		{
			this.SendPropertyChanging();
			entity.Teams = this;
		}
		
		private void detach_Players(Players entity)
		{
			this.SendPropertyChanging();
			entity.Teams = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="")]
	public partial class Games : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _HomeTeam;
		
		private string _AwayTeam;
		
		private int _HomeTeamScore;
		
		private int _AwayTeamScore;
		
		private int _Fixture;
		
		private System.DateTime _GameDate;
		
		private string _MVP;
		
		private EntityRef<Teams> _Teams;
		
		private EntityRef<Teams> _Teams1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnHomeTeamChanging(string value);
    partial void OnHomeTeamChanged();
    partial void OnAwayTeamChanging(string value);
    partial void OnAwayTeamChanged();
    partial void OnHomeTeamScoreChanging(int value);
    partial void OnHomeTeamScoreChanged();
    partial void OnAwayTeamScoreChanging(int value);
    partial void OnAwayTeamScoreChanged();
    partial void OnFixtureChanging(int value);
    partial void OnFixtureChanged();
    partial void OnGameDateChanging(System.DateTime value);
    partial void OnGameDateChanged();
    partial void OnMVPChanging(string value);
    partial void OnMVPChanged();
    #endregion
		
		public Games()
		{
			this._Teams = default(EntityRef<Teams>);
			this._Teams1 = default(EntityRef<Teams>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HomeTeam", CanBeNull=false, IsPrimaryKey=true)]
		public string HomeTeam
		{
			get
			{
				return this._HomeTeam;
			}
			set
			{
				if ((this._HomeTeam != value))
				{
					if (this._Teams.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnHomeTeamChanging(value);
					this.SendPropertyChanging();
					this._HomeTeam = value;
					this.SendPropertyChanged("HomeTeam");
					this.OnHomeTeamChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AwayTeam", CanBeNull=false, IsPrimaryKey=true)]
		public string AwayTeam
		{
			get
			{
				return this._AwayTeam;
			}
			set
			{
				if ((this._AwayTeam != value))
				{
					if (this._Teams1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnAwayTeamChanging(value);
					this.SendPropertyChanging();
					this._AwayTeam = value;
					this.SendPropertyChanged("AwayTeam");
					this.OnAwayTeamChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HomeTeamScore")]
		public int HomeTeamScore
		{
			get
			{
				return this._HomeTeamScore;
			}
			set
			{
				if ((this._HomeTeamScore != value))
				{
					this.OnHomeTeamScoreChanging(value);
					this.SendPropertyChanging();
					this._HomeTeamScore = value;
					this.SendPropertyChanged("HomeTeamScore");
					this.OnHomeTeamScoreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AwayTeamScore")]
		public int AwayTeamScore
		{
			get
			{
				return this._AwayTeamScore;
			}
			set
			{
				if ((this._AwayTeamScore != value))
				{
					this.OnAwayTeamScoreChanging(value);
					this.SendPropertyChanging();
					this._AwayTeamScore = value;
					this.SendPropertyChanged("AwayTeamScore");
					this.OnAwayTeamScoreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fixture", IsPrimaryKey=true)]
		public int Fixture
		{
			get
			{
				return this._Fixture;
			}
			set
			{
				if ((this._Fixture != value))
				{
					this.OnFixtureChanging(value);
					this.SendPropertyChanging();
					this._Fixture = value;
					this.SendPropertyChanged("Fixture");
					this.OnFixtureChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GameDate")]
		public System.DateTime GameDate
		{
			get
			{
				return this._GameDate;
			}
			set
			{
				if ((this._GameDate != value))
				{
					this.OnGameDateChanging(value);
					this.SendPropertyChanging();
					this._GameDate = value;
					this.SendPropertyChanged("GameDate");
					this.OnGameDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MVP", CanBeNull=false)]
		public string MVP
		{
			get
			{
				return this._MVP;
			}
			set
			{
				if ((this._MVP != value))
				{
					this.OnMVPChanging(value);
					this.SendPropertyChanging();
					this._MVP = value;
					this.SendPropertyChanged("MVP");
					this.OnMVPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Teams_Games", Storage="_Teams", ThisKey="HomeTeam", OtherKey="TeamName", IsForeignKey=true)]
		public Teams Teams
		{
			get
			{
				return this._Teams.Entity;
			}
			set
			{
				Teams previousValue = this._Teams.Entity;
				if (((previousValue != value) 
							|| (this._Teams.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Teams.Entity = null;
						previousValue.Games.Remove(this);
					}
					this._Teams.Entity = value;
					if ((value != null))
					{
						value.Games.Add(this);
						this._HomeTeam = value.TeamName;
					}
					else
					{
						this._HomeTeam = default(string);
					}
					this.SendPropertyChanged("Teams");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Teams_Games1", Storage="_Teams1", ThisKey="AwayTeam", OtherKey="TeamName", IsForeignKey=true)]
		public Teams Teams1
		{
			get
			{
				return this._Teams1.Entity;
			}
			set
			{
				Teams previousValue = this._Teams1.Entity;
				if (((previousValue != value) 
							|| (this._Teams1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Teams1.Entity = null;
						previousValue.Games1.Remove(this);
					}
					this._Teams1.Entity = value;
					if ((value != null))
					{
						value.Games1.Add(this);
						this._AwayTeam = value.TeamName;
					}
					else
					{
						this._AwayTeam = default(string);
					}
					this.SendPropertyChanged("Teams1");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="")]
	public partial class Users : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _UserName;
		
		private string _Password;
		
		private bool _Admin;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnAdminChanging(bool value);
    partial void OnAdminChanged();
    #endregion
		
		public Users()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", CanBeNull=false, IsPrimaryKey=true)]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this.OnUserNameChanging(value);
					this.SendPropertyChanging();
					this._UserName = value;
					this.SendPropertyChanged("UserName");
					this.OnUserNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Admin")]
		public bool Admin
		{
			get
			{
				return this._Admin;
			}
			set
			{
				if ((this._Admin != value))
				{
					this.OnAdminChanging(value);
					this.SendPropertyChanging();
					this._Admin = value;
					this.SendPropertyChanged("Admin");
					this.OnAdminChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Players")]
	public partial class Players : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _PlayerName;
		
		private string _TeamName;
		
		private int _NumberOfTitles;
		
		private double _Age;
		
		private double _Height;
		
		private double _Weight;
		
		private string _Position;
		
		private int _ExeperienceYears;
		
		private int _MVP;
		
		private System.Data.Linq.Binary _Picture;
		
		private string _AgentName;
		
		private EntityRef<Teams> _Teams;
		
		private EntityRef<Agents> _Agents;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPlayerNameChanging(string value);
    partial void OnPlayerNameChanged();
    partial void OnTeamNameChanging(string value);
    partial void OnTeamNameChanged();
    partial void OnNumberOfTitlesChanging(int value);
    partial void OnNumberOfTitlesChanged();
    partial void OnAgeChanging(double value);
    partial void OnAgeChanged();
    partial void OnHeightChanging(double value);
    partial void OnHeightChanged();
    partial void OnWeightChanging(double value);
    partial void OnWeightChanged();
    partial void OnPositionChanging(string value);
    partial void OnPositionChanged();
    partial void OnExeperienceYearsChanging(int value);
    partial void OnExeperienceYearsChanged();
    partial void OnMVPChanging(int value);
    partial void OnMVPChanged();
    partial void OnPictureChanging(System.Data.Linq.Binary value);
    partial void OnPictureChanged();
    partial void OnAgentNameChanging(string value);
    partial void OnAgentNameChanged();
    #endregion
		
		public Players()
		{
			this._Teams = default(EntityRef<Teams>);
			this._Agents = default(EntityRef<Agents>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PlayerName", DbType="NVarChar(4000) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string PlayerName
		{
			get
			{
				return this._PlayerName;
			}
			set
			{
				if ((this._PlayerName != value))
				{
					this.OnPlayerNameChanging(value);
					this.SendPropertyChanging();
					this._PlayerName = value;
					this.SendPropertyChanged("PlayerName");
					this.OnPlayerNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TeamName", DbType="NVarChar(4000) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string TeamName
		{
			get
			{
				return this._TeamName;
			}
			set
			{
				if ((this._TeamName != value))
				{
					if (this._Teams.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnTeamNameChanging(value);
					this.SendPropertyChanging();
					this._TeamName = value;
					this.SendPropertyChanged("TeamName");
					this.OnTeamNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NumberOfTitles", DbType="Int NOT NULL")]
		public int NumberOfTitles
		{
			get
			{
				return this._NumberOfTitles;
			}
			set
			{
				if ((this._NumberOfTitles != value))
				{
					this.OnNumberOfTitlesChanging(value);
					this.SendPropertyChanging();
					this._NumberOfTitles = value;
					this.SendPropertyChanged("NumberOfTitles");
					this.OnNumberOfTitlesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Age", DbType="Float NOT NULL")]
		public double Age
		{
			get
			{
				return this._Age;
			}
			set
			{
				if ((this._Age != value))
				{
					this.OnAgeChanging(value);
					this.SendPropertyChanging();
					this._Age = value;
					this.SendPropertyChanged("Age");
					this.OnAgeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Height", DbType="Float NOT NULL")]
		public double Height
		{
			get
			{
				return this._Height;
			}
			set
			{
				if ((this._Height != value))
				{
					this.OnHeightChanging(value);
					this.SendPropertyChanging();
					this._Height = value;
					this.SendPropertyChanged("Height");
					this.OnHeightChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Weight", DbType="Float NOT NULL")]
		public double Weight
		{
			get
			{
				return this._Weight;
			}
			set
			{
				if ((this._Weight != value))
				{
					this.OnWeightChanging(value);
					this.SendPropertyChanging();
					this._Weight = value;
					this.SendPropertyChanged("Weight");
					this.OnWeightChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Position", DbType="NVarChar(4000) NOT NULL", CanBeNull=false)]
		public string Position
		{
			get
			{
				return this._Position;
			}
			set
			{
				if ((this._Position != value))
				{
					this.OnPositionChanging(value);
					this.SendPropertyChanging();
					this._Position = value;
					this.SendPropertyChanged("Position");
					this.OnPositionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ExeperienceYears", DbType="Int NOT NULL")]
		public int ExeperienceYears
		{
			get
			{
				return this._ExeperienceYears;
			}
			set
			{
				if ((this._ExeperienceYears != value))
				{
					this.OnExeperienceYearsChanging(value);
					this.SendPropertyChanging();
					this._ExeperienceYears = value;
					this.SendPropertyChanged("ExeperienceYears");
					this.OnExeperienceYearsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MVP", DbType="Int NOT NULL")]
		public int MVP
		{
			get
			{
				return this._MVP;
			}
			set
			{
				if ((this._MVP != value))
				{
					this.OnMVPChanging(value);
					this.SendPropertyChanging();
					this._MVP = value;
					this.SendPropertyChanged("MVP");
					this.OnMVPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="Image", Storage="_Picture", DbType="Image", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary Picture
		{
			get
			{
				return this._Picture;
			}
			set
			{
				if ((this._Picture != value))
				{
					this.OnPictureChanging(value);
					this.SendPropertyChanging();
					this._Picture = value;
					this.SendPropertyChanged("Picture");
					this.OnPictureChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AgentName", CanBeNull=false, IsPrimaryKey=true)]
		public string AgentName
		{
			get
			{
				return this._AgentName;
			}
			set
			{
				if ((this._AgentName != value))
				{
					if (this._Agents.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnAgentNameChanging(value);
					this.SendPropertyChanging();
					this._AgentName = value;
					this.SendPropertyChanged("AgentName");
					this.OnAgentNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Teams_Players", Storage="_Teams", ThisKey="TeamName", OtherKey="TeamName", IsForeignKey=true)]
		public Teams Teams
		{
			get
			{
				return this._Teams.Entity;
			}
			set
			{
				Teams previousValue = this._Teams.Entity;
				if (((previousValue != value) 
							|| (this._Teams.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Teams.Entity = null;
						previousValue.Players.Remove(this);
					}
					this._Teams.Entity = value;
					if ((value != null))
					{
						value.Players.Add(this);
						this._TeamName = value.TeamName;
					}
					else
					{
						this._TeamName = default(string);
					}
					this.SendPropertyChanged("Teams");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Agents_Players", Storage="_Agents", ThisKey="AgentName", OtherKey="AgentName", IsForeignKey=true)]
		public Agents Agents
		{
			get
			{
				return this._Agents.Entity;
			}
			set
			{
				Agents previousValue = this._Agents.Entity;
				if (((previousValue != value) 
							|| (this._Agents.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Agents.Entity = null;
						previousValue.Players.Remove(this);
					}
					this._Agents.Entity = value;
					if ((value != null))
					{
						value.Players.Add(this);
						this._AgentName = value.AgentName;
					}
					else
					{
						this._AgentName = default(string);
					}
					this.SendPropertyChanged("Agents");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="")]
	public partial class Agents : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _AgentName;
		
		private string _Age;
		
		private string _Popularity;
		
		private string _City;
		
		private string _Phone;
		
		private EntitySet<Players> _Players;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAgentNameChanging(string value);
    partial void OnAgentNameChanged();
    partial void OnAgeChanging(string value);
    partial void OnAgeChanged();
    partial void OnPopularityChanging(string value);
    partial void OnPopularityChanged();
    partial void OnCityChanging(string value);
    partial void OnCityChanged();
    partial void OnPhoneChanging(string value);
    partial void OnPhoneChanged();
    #endregion
		
		public Agents()
		{
			this._Players = new EntitySet<Players>(new Action<Players>(this.attach_Players), new Action<Players>(this.detach_Players));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AgentName", CanBeNull=false, IsPrimaryKey=true)]
		public string AgentName
		{
			get
			{
				return this._AgentName;
			}
			set
			{
				if ((this._AgentName != value))
				{
					this.OnAgentNameChanging(value);
					this.SendPropertyChanging();
					this._AgentName = value;
					this.SendPropertyChanged("AgentName");
					this.OnAgentNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Age", CanBeNull=false)]
		public string Age
		{
			get
			{
				return this._Age;
			}
			set
			{
				if ((this._Age != value))
				{
					this.OnAgeChanging(value);
					this.SendPropertyChanging();
					this._Age = value;
					this.SendPropertyChanged("Age");
					this.OnAgeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Popularity", CanBeNull=false)]
		public string Popularity
		{
			get
			{
				return this._Popularity;
			}
			set
			{
				if ((this._Popularity != value))
				{
					this.OnPopularityChanging(value);
					this.SendPropertyChanging();
					this._Popularity = value;
					this.SendPropertyChanged("Popularity");
					this.OnPopularityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_City", CanBeNull=false)]
		public string City
		{
			get
			{
				return this._City;
			}
			set
			{
				if ((this._City != value))
				{
					this.OnCityChanging(value);
					this.SendPropertyChanging();
					this._City = value;
					this.SendPropertyChanged("City");
					this.OnCityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", CanBeNull=false)]
		public string Phone
		{
			get
			{
				return this._Phone;
			}
			set
			{
				if ((this._Phone != value))
				{
					this.OnPhoneChanging(value);
					this.SendPropertyChanging();
					this._Phone = value;
					this.SendPropertyChanged("Phone");
					this.OnPhoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Agents_Players", Storage="_Players", ThisKey="AgentName", OtherKey="AgentName")]
		public EntitySet<Players> Players
		{
			get
			{
				return this._Players;
			}
			set
			{
				this._Players.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Players(Players entity)
		{
			this.SendPropertyChanging();
			entity.Agents = this;
		}
		
		private void detach_Players(Players entity)
		{
			this.SendPropertyChanging();
			entity.Agents = null;
		}
	}
}
#pragma warning restore 1591
