-- Switch to the system (aka master) database
USE master;
GO

-- Delete the DemoDB Database (IF EXISTS)
IF EXISTS(select * from sys.databases where name='SmalltownCinema')
DROP DATABASE SmalltownCinema;
GO

-- Create a new DemoDB Database
CREATE DATABASE SmalltownCinema;
GO

-- Switch to the DemoDB Database
USE SmalltownCinema
GO

BEGIN TRANSACTION;

CREATE TABLE users
(
	id			int			identity(1,1),
	username	varchar(50)	not null,
	password	varchar(50)	not null,
	salt		varchar(50)	not null,
	role		varchar(50)	default('user'),
	firstName	varchar(100),
	lastName	varchar(100),
	city		varchar(50),
	state		varchar(75),
	zipCode		varchar(50),
	address		varchar(100),
	email		varchar(100),

	constraint pk_users primary key (id)
);

CREATE TABLE films
(
	id int IDENTITY(1,1),
	title varchar(500) NOT NULL,
	synopsis varchar(500) NOT NULL,
	releaseDate DATETIME NOT NULL,
	rating varchar(10),
	runtime int NOT NULL,
	linkToSite varchar(250),
	imageLink varchar(250),
	directorId int,
	startDate DATE NOT NULL,
	endDate DATE NOT NULL,
	screenId int,

	CONSTRAINT filmId PRIMARY KEY (id)
);


CREATE TABLE actors
(
	id int IDENTITY (1,1),
	name varchar(100),
	
	CONSTRAINT actorId PRIMARY KEY (id)
);

CREATE TABLE actor_film 
(
	filmId int NOT NULL,
	actorId int NOT NULL,

	CONSTRAINT aId FOREIGN KEY (actorId) REFERENCES actors (id),
	CONSTRAINT fId FOREIGN KEY (filmId) REFERENCES films (id),
);

CREATE TABLE genre 
(
	id int IDENTITY (1,1),
	title varchar(50),

	CONSTRAINT genreId PRIMARY KEY (id),
);

CREATE TABLE film_genre
(
	filmId int NOT NULL,
	genreId int NOT NULL,

	CONSTRAINT Id FOREIGN KEY (filmId) REFERENCES films (id),
	CONSTRAINT gId FOREIGN KEY (genreId) REFERENCES genre (id),
);

CREATE TABLE director
(
	id int IDENTITY (1,1),
	name varchar(200) NOT NULL,
	CONSTRAINT directorId PRIMARY KEY (id),
);
CREATE TABLE theatres
(
	id int IDENTITY (1,1),
	name varchar(50) NOT NULL,

	CONSTRAINT theatreId PRIMARY KEY (id),
);

CREATE TABLE showtimes 
(
	Id int IDENTITY (1,1),
	--filmId int NOT NULL,
	theatreId int NOT NULL,
	showtime TIME NOT NULL,
	price decimal NOT NULL,
	--CONSTRAINT fffId FOREIGN KEY (filmId) REFERENCES films (id),
	CONSTRAINT  tId FOREIGN KEY (theatreId) REFERENCES theatres (id),
	CONSTRAINT showId PRIMARY KEY (id),
);

CREATE TABLE reservations
(
	id int IDENTITY (1,1),
	showingId int NOT NULL,
	date DATE NOT NULL,
	seatId int NOT NULL,
	userId int NOT NULL,
	confirmNum varchar(50),

	CONSTRAINT sID FOREIGN KEY (showingId) REFERENCES showtimes (Id),
	CONSTRAINT uID FOREIGN KEY (userId) REFERENCES users (id),
	CONSTRAINT rId PRIMARY KEY (id),
);

ALTER TABLE films ADD CONSTRAINT directorFilm FOREIGN KEY (directorId) REFERENCES director (id);
ALTER TABLE films ADD CONSTRAINT theatrescreenID FOREIGN KEY (screenId) REFERENCES theatres (id);

COMMIT TRANSACTION;