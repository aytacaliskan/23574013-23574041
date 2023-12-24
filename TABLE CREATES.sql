create table Seasons(
SeasonsID int primary key  identity(1,1),
SeasonsName nvarchar(255)
)

create table Teams(
TeamID int primary key identity(1,1),
TeamName nvarchar(255),
Coach nvarchar(255),
SeasonsID int,
   FOREIGN KEY (SeasonsID) REFERENCES Seasons(SeasonsID)
)

create table Players(
PlayerID int primary key  identity(1,1),
FirstName nvarchar(255),
LastName nvarchar(255),
Position nvarchar(255),
TeamID int,
   FOREIGN KEY (TeamID) REFERENCES Teams(TeamID)
)

create table Matches(
MatchID int primary key identity(1,1),
Date datetime2(7),
Opponent nvarchar(255),
Venue nvarchar(255),
TeamID int,
   FOREIGN KEY (TeamID) REFERENCES Teams(TeamID),
PlayerID int,
   FOREIGN KEY (PlayerID) REFERENCES Players(PlayerID)
)

create table Scores(
ScoreID int primary key identity(1,1),
GoalsScored int,
Assists int,
TeamID int,
   FOREIGN KEY (TeamID) REFERENCES Teams(TeamID),
 MatchID int,
   FOREIGN KEY (MatchID) REFERENCES Matches(MatchID),
PlayerID int,
   FOREIGN KEY (PlayerID) REFERENCES Players(PlayerID),

)

