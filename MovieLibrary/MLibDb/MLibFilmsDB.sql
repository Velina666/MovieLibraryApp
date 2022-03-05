CREATE DATABASE MLibFilmsDB
GO
USE MLibFilmsDB
GO

USE MLibFilmsDB

CREATE TABLE Films
(
	Id INT IDENTITY PRIMARY KEY,
	Title VARCHAR(50) NOT NULL,
	Publisher VARCHAR(50) NOT NULL,
	FilmYear DATE NOT NULL,
	FilmType VARCHAR(50) NOT NULL,
	Stars INT NOT NULL,
	Rate DOUBLE NOT NULL
);

INSERT INTO Films(Id, Title, Publisher, FilmYear, FilmType, Stars, Rate)
VALUES('Admin','Encanto', 'USA','2021','Animation',5,7.3);
