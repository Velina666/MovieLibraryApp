CREATE DATABASE MLibraryDB
GO
 USE MLibraryDB
 GO

 CREATE TABLE Accounts
 (
	Id INT IDENTITY PRIMARY KEY,
	Username VARCHAR(25) NOT NULL,
	Password VARCHAR(50) NOT NULL,
	FirstName VARCHAR(50) NOT NULL,
	LastName VARCHAR(50) NOT NULL,
	RecoveryKey INT NOT NULL
 );

 INSERT INTO Accounts
 VALUES('Admin','Admin','Konstantin', 'Balabanov',123456);
