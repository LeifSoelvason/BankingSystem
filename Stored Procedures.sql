
/*SSMS: CRUD:  */

/*
CREATE TABLE Kunde (
    kundeNummer INT IDENTITY(1,1) PRIMARY KEY,
    forNavn VARCHAR(50) NOT NULL,
    efterNavn VARCHAR(50) NOT NULL,
	opretDato DATETIME NOT NULL,
	brugerNavn VARCHAR(50) NOT NULL,
    passWord VARCHAR(50) NOT NULL
);
*/




/*
CREATE TABLE Konto (
    kontoNummer INT IDENTITY(1,1) PRIMARY KEY,
	forNavn VARCHAR(50) NOT NULL,
    efterNavn VARCHAR(50) NOT NULL,
	opretDato DATETIME NOT NULL,
    Saldo DECIMAL(18,2) DEFAULT 0,
	kundeNummer INT NOT NULL,
    FOREIGN KEY (kundeNummer) REFERENCES Kunde(kundeNummer)
);
*/

/*
INSERT INTO Kunde (forNavn, efterNavn, opretDato, brugerNavn, passWord)
VALUES ('Palle', 'Westermann', GETDATE(), 'Palle', '123')
*/

/*
INSERT INTO Kunde (forNavn, efterNavn, opretDato, brugerNavn, passWord)
VALUES ('Mike', 'Tyson', GETDATE(), 'Mike', 'Knockout')
*/

/*
INSERT INTO Kunde (forNavn, efterNavn, opretDato, brugerNavn, passWord)
VALUES ('Bubber', 'Bub', GETDATE(), 'Bubber', 'Slambert')
*/

/*
SELECT * FROM Kunde
*/

/*
DELETE FROM Kunde WHERE forNavn = 'Bubber'
*/

/*
SELECT * FROM Kunde
*/

/*
INSERT INTO Kunde (forNavn, efterNavn, opretDato, brugerNavn, passWord)
VALUES ('Bubber', 'Bub', GETDATE(), 'Bubber', 'Slambert')
*/

/*
SELECT * FROM Kunde
*/

/*
INSERT INTO Kunde (forNavn, efterNavn, opretDato, brugerNavn, passWord)
VALUES ('Ahmed', 'Abdul', GETDATE(), 'Ahmed', '123')
*/

/*
INSERT INTO Kunde (forNavn, efterNavn, opretDato, brugerNavn, passWord)
VALUES ('Bjarne', 'Riis', GETDATE(), 'Bjarne', 'epo')
*/

/*
INSERT INTO Kunde (forNavn, efterNavn, opretDato, brugerNavn, passWord)
VALUES ('Justin', 'Bieber', GETDATE(), 'Justin', 'hvemRinger')
*/

/*
SELECT * FROM Kunde
*/

/*
DELETE FROM Kunde WHERE efterNavn LIKE '%ii%'
*/

/*
DELETE FROM Kunde WHERE password LIKE '%r'
*/

/*
UPDATE Kunde SET forNavn = 'Bilal' WHERE forNavn = 'Ahmed'
*/

/*
DELETE FROM Kunde WHERE forNavn LIKE 'Bi%';
*/

/*
DROP TABLE Konto;
*/

/*
DROP TABLE Kunde;
*/




/*
CREATE TABLE Kunde (
    kundeNummer INT IDENTITY(1,1) PRIMARY KEY,
    forNavn VARCHAR(50) NOT NULL,
    efterNavn VARCHAR(50) NOT NULL,
	opretDato DATETIME NOT NULL,
	brugerNavn VARCHAR(50) NOT NULL,
    passWord VARCHAR(50) NOT NULL
);
*/

/*
CREATE TABLE Konto (
    kontoNummer INT IDENTITY(1,1) PRIMARY KEY,
	forNavn VARCHAR(50) NOT NULL,
    efterNavn VARCHAR(50) NOT NULL,
	opretDato DATETIME NOT NULL,
    Saldo DECIMAL(18,2) NOT NULL DEFAULT 0,
	kundeNummer INT NOT NULL,
    FOREIGN KEY (kundeNummer) REFERENCES Kunde(kundeNummer)
	);
*/

/*
INSERT INTO Kunde (forNavn, efterNavn, opretDato, brugerNavn, passWord)
VALUES ('Leif', 'Soelvason', GETDATE(), 'Admin', 'admin')
*/

/*
CREATE PROCEDURE [dbo].[sp_NyKonto]
    @forNavn VARCHAR(50),
    @efterNavn VARCHAR(50)
	
AS
BEGIN
    INSERT INTO Konto (forNavn, efterNavn)
    VALUES (@forNavn, @efterNavn);
END;
*/

/*
CREATE PROCEDURE [dbo].[sp_ValidateBruger]
    @brugerNavn VARCHAR(50),
    @passWord VARCHAR(50)
AS
BEGIN
    SELECT *
    FROM Kunde
    WHERE brugerNavn = @brugerNavn AND passWord = @passWord;
END;
*/



/*
CREATE PROCEDURE [dbo].[spBank_OpretKunde]
    @forNavn VARCHAR(50),
    @efterNavn VARCHAR(50),
	@brugerNavn VARCHAR(50),
    @passWord VARCHAR(50)
AS
BEGIN
    INSERT INTO Kunde (forNavn, efterNavn, brugerNavn, passWord)
    VALUES (@forNavn, @efterNavn,@brugerNavn, @passWord);
END;
*/





/*
CREATE PROCEDURE sp_ValidateKunde
    @Username VARCHAR(50),
    @Password VARCHAR(50)
AS
BEGIN
    SELECT *
    FROM Kunder
    WHERE Username = @Username AND Password = @Password;
END;
*/



/*
CREATE PROCEDURE sp_NyKonto
    @KundeID INT,
    @Fornavn VARCHAR(50),
    @Efternavn VARCHAR(50)
AS
BEGIN
    INSERT INTO Konti (KundeID)
    VALUES (@KundeID);
    
    SELECT *
    FROM Konti
    WHERE Kontonummer = SCOPE_IDENTITY() AND KundeID = @KundeID;
END;
*/


/*
CREATE PROCEDURE [dbo].[sp_MineKonti]
		
	@Kundenummer int
as
begin	
	SET NOCOUNT ON;

	SELECT Kontonummer, Fornavn, Efternavn, Dato, Saldo, Kundenummer
	FROM dbo.Konto
	WHERE Kundenummer = @Kundenummer

end 
*/