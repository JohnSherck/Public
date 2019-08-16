USE SmalltownCinema;
GO

BEGIN TRANSACTION;
-- Directors
INSERT INTO director (name)
			VALUES ('Gary Dauberman');
DECLARE @annibelleDirector AS int
SET @annibelleDirector = @@IDENTITY;
INSERT INTO director (name)
			VALUES ('Josh Cooley');
DECLARE @toyStoryDirector AS int
SET @toyStoryDirector = @@IDENTITY;
INSERT INTO director (name)
			VALUES ('Todd Douglas Miller');
DECLARE @apollo11Director AS int
SET @apollo11Director = @@IDENTITY;

-- FIlms
INSERT INTO films (title, synopsis, releaseDate, rating, runtime, linkToSite, imageLink, directorId, startDate, endDate)
			VALUES('Annabelle Comes Home', 'While babysitting the daughter of Ed and Lorraine Warren, a teenager and her friend unknowingly awaken an evil spirit trapped in a doll.', '6-26-2019', 'R', 106, 'https://www.annabellemovie.com/', '/images/movieposters/1.jpg', @annibelleDirector, GETDATE()+1, GETDATE() + 21);
DECLARE @annabelleFilmID AS int
SET @annabelleFilmID = @@IDENTITY;
INSERT INTO films (title, synopsis, releaseDate, rating, runtime, linkToSite, imageLink, directorId, startDate, endDate)
			VALUES('Apollo 11', 'A look at the Apollo 11 mission to land on the moon led by commander Neil Armstrong and pilots Buzz Aldrin and Michael Collins.', '6-26-2019', 'G', 93, 'https://www.apollo11movie.com/', '/images/movieposters/2.jpg', @apollo11Director, GETDATE(), GETDATE() + 2);
DECLARE @apollo11FilmID AS int
SET @apollo11FilmID = @@IDENTITY;
INSERT INTO films (title, synopsis, releaseDate, rating, runtime, linkToSite, imageLink, directorId, startDate, endDate)
			VALUES('Toy Story 4', 'When a new toy called "Forky" joins Woody and the gang, a road trip alongside old and new friends reveals how big the world can be for a toy.', '6-21-2019', 'G', 100, 'https://movies.disney.com/toy-story-4', '/images/movieposters/3.jpg', @toyStoryDirector, GETDATE(), GETDATE() + 5);
DECLARE @toyStoryFilmID AS int
SET @toyStoryFilmID = @@IDENTITY;

-- Toy Story 4 Actors
INSERT INTO actors (name)
			VALUES ('Tom Hanks');
DECLARE @tomHanksID AS int
SET @tomHanksID = @@IDENTITY;
INSERT INTO actors (name)
			VALUES ('Tim Allen');
DECLARE @timAllenID AS int
SET @timAllenID = @@IDENTITY;
INSERT INTO actors (name)
			VALUES ('Annie Potts');
DECLARE @anniePottsID AS int
SET @anniePottsID = @@IDENTITY;
-- Apollo 11 Actors
INSERT INTO actors (name)
			VALUES ('Buzz Aldrin');
DECLARE @buzzAldrinID AS int
SET @buzzAldrinID = @@IDENTITY;
INSERT INTO actors (name)
			VALUES ('Joan Ann Archer');
DECLARE @joanAnnArcherID AS int
SET @joanAnnArcherID = @@IDENTITY;
INSERT INTO actors (name)
			VALUES ('Janet Armstrong');
DECLARE @janetArmstrongID AS int
SET @janetArmstrongID = @@IDENTITY;
-- Annabelle Actors
INSERT INTO actors (name)
			VALUES ('Vera Farmiga');
DECLARE @veraFarmigaID AS int
SET @veraFarmigaID = @@IDENTITY;
INSERT INTO actors (name)
			VALUES ('Patrick Wilson');
DECLARE @patrickWilsonID AS int
SET @patrickWilsonID = @@IDENTITY;
INSERT INTO actors (name)
			VALUES ('Mckenna Grace');
DECLARE @mckennaGraceID AS int
SET @mckennaGraceID = @@IDENTITY;


-- Annibelle Actors
INSERT INTO actor_film (filmId, actorId)
			   VALUES (@annabelleFilmID, @veraFarmigaID);
INSERT INTO actor_film (filmId, actorId)
			   VALUES (@annabelleFilmID, @patrickWilsonID);
INSERT INTO actor_film (filmId, actorId)
			   VALUES (@annabelleFilmID, @mckennaGraceID);
-- Apollo 11 Actors
INSERT INTO actor_film (filmId, actorId)
			   VALUES (@apollo11FilmID, @buzzAldrinID);
INSERT INTO actor_film (filmId, actorId)
			   VALUES (@apollo11FilmID, @joanAnnArcherID);
INSERT INTO actor_film (filmId, actorId)
			   VALUES (@apollo11FilmID, @janetArmstrongID);
-- Toy Story 4 Actors
INSERT INTO actor_film (filmId, actorId)
			   VALUES (@toyStoryFilmID, @tomHanksID);
INSERT INTO actor_film (filmId, actorId)
			   VALUES (@toyStoryFilmID, @anniePottsID);
INSERT INTO actor_film (filmId, actorId)
			   VALUES (@toyStoryFilmID, @timAllenID);

-- Genre Data
INSERT INTO genre (title)
		   VALUES ('Horror');
DECLARE @horror as int
SET @horror = @@IDENTITY;
INSERT INTO genre (title)
		   VALUES ('Mystery');
DECLARE @mystery as int
SET @mystery = @@IDENTITY;
INSERT INTO genre (title)
		   VALUES ('Thriller');
DECLARE @thriller as int
SET @thriller = @@IDENTITY;
INSERT INTO genre (title)
		   VALUES ('Animation');
DECLARE @animation as int
SET @animation = @@IDENTITY;
INSERT INTO genre (title)
		   VALUES ('Adventure');
DECLARE @adventure as int
SET @adventure = @@IDENTITY;
INSERT INTO genre (title)
		   VALUES ('Comedy');
DECLARE @comedy as int
SET @comedy = @@IDENTITY;
INSERT INTO genre (title)
		   VALUES ('Documentary');
DECLARE @documentary as int
SET @documentary = @@IDENTITY;
INSERT INTO genre (title)
		   VALUES ('History');
DECLARE @history as int
SET @history = @@IDENTITY;


-- Film Genre Data
INSERT INTO film_genre (filmId, genreId)
				VALUES (@annabelleFilmID, @horror),
					   (@annabelleFilmID, @mystery),
					   (@annabelleFilmID, @thriller),
					   (@apollo11FilmID, @history),
					   (@apollo11FilmID, @documentary),
					   (@toyStoryFilmID, @animation),
					   (@toyStoryFilmID, @adventure),
					   (@toyStoryFilmID, @comedy);


-- Theatre Data
INSERT INTO theatres (name)
			VALUES ('Holodeck 1')
DECLARE @screen1 AS varchar(20)
SET @screen1 = @@IDENTITY
INSERT INTO theatres (name)
			VALUES ('Holodeck 2')
DECLARE @screen2 AS varchar(20)
SET @screen2 = @@IDENTITY
INSERT INTO theatres (name)
			VALUES ('Holodeck 3')
DECLARE @screen3 AS varchar(20)
SET @screen3 = @@IDENTITY


UPDATE films SET screenId = @screen1
	WHERE id = @annabelleFilmID;
UPDATE films SET screenId = @screen2
	WHERE id = @apollo11FilmID;
UPDATE films SET screenId = @screen3
	WHERE id = @toyStoryFilmID;
-- Showtime Data
INSERT INTO showtimes ( theatreId, showtime, price)
				VALUES ( @screen1, '10:00', '8.00'),
					   ( @screen2, '10:15', '8.50'),
					   ( @screen3, '10:30', '9.00'),
					   ( @screen1, '13:00', '10.00'),
					   ( @screen2, '13:15', '10.50'),
					   ( @screen3, '13:30', '11.00'),
					   ( @screen1, '16:00', '12.00'),
					   ( @screen2, '16:15', '12.50'),
					   ( @screen3, '16:30', '13.00'),
					   ( @screen1, '19:00', '15.00'),
					   ( @screen2, '19:15', '16.00'),
					   ( @screen3, '19:30', '16.00'),
					   ( @screen1, '22:00', '20.00'),
					   ( @screen2, '22:15', '20.00'),
					   ( @screen3, '22:30', '16.00');


-- Sample User Data
INSERT INTO users (username, password, salt, role)
			VALUES('dev@gmail.com', 'NVuwSQOhqBnQQsi4/LhfWryqEp0=', 'EURBgKfr0NQ=', 'admin');
INSERT INTO users (username, password, salt, role)
			VALUES('user@gmail.com', 'NVuwSQOhqBnQQsi4/LhfWryqEp0=', 'EURBgKfr0NQ=', 'user');
DECLARE @userId AS INT
SET @userId = @@IDENTITY

-- Sample Reservation Data
INSERT INTO reservations (showingId, date, seatId, userId)
				VALUES	(15, GETDATE(), 3, @userId),
						(15, GETDATE(), 4, @userId),
						(15, GETDATE(), 5, @userId),
						(15, GETDATE(), 88, @userId),
						(15, GETDATE(), 89, @userId),
						(15, GETDATE(), 69, @userId),
						(14, GETDATE(), 3, @userId),
						(14, GETDATE(), 4, @userId),
						(14, GETDATE(), 5, @userId),
						(14, GETDATE(), 88, @userId),
						(14, GETDATE(), 89, @userId),
						(14, GETDATE(), 69, @userId),
						(13, GETDATE(), 3, @userId),
						(13, GETDATE(), 4, @userId),
						(13, GETDATE(), 5, @userId),
						(13, GETDATE(), 88, @userId),
						(13, GETDATE(), 89, @userId),
						(13, GETDATE(), 69, @userId),
						(12, GETDATE(), 3, @userId),
						(12, GETDATE(), 4, @userId),
						(12, GETDATE(), 5, @userId),
						(12, GETDATE(), 88, @userId),
						(12, GETDATE(), 89, @userId),
						(11, GETDATE(), 69, @userId),
						(9, GETDATE(), 3, @userId),
						(9, GETDATE(), 4, @userId),
						(10, GETDATE(), 5, @userId),
						(10, GETDATE(), 88, @userId),
						(10, GETDATE(), 89, @userId),
						(10, GETDATE(), 69, @userId),
						(7, GETDATE(), 88, @userId),
						(7, GETDATE(), 89, @userId),
						(7, GETDATE(), 69, @userId),
						(6, GETDATE(), 3, @userId),
						(6, GETDATE(), 4, @userId),
						(6, GETDATE(), 5, @userId),
						(5, GETDATE(), 88, @userId),
						(5, GETDATE(), 89, @userId),
						(5, GETDATE(), 69, @userId),
						(4, GETDATE(), 3, @userId),
						(4, GETDATE(), 4, @userId),
						(4, GETDATE(), 5, @userId),
						(3, GETDATE(), 88, @userId),
						(3, GETDATE(), 89, @userId),
						(2, GETDATE(), 69, @userId),
						(2, GETDATE(), 70, @userId);


COMMIT TRANSACTION;

--DROP DATABASE SmalltownCinema;

--SELECT * FROM films

--SELECT * FROM showtimes

--SELECT * FROM users


--SELECT * FROM showtimes s JOIN theatres t ON s.theatreId = t.id JOIN films f ON t.id = f.screenId;

--SELECT * FROM showtimes s JOIN theatres t ON s.theatreId = t.id JOIN films f ON t.id = f.screenId WHERE f.id = 1