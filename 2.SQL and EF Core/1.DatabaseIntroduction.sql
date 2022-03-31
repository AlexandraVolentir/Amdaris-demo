DROP TABLE Internship.dbo.Client;
DROP TABLE Internship.dbo.Account;
DROP TABLE Internship.dbo.Loan;
DROP TABLE Internship.dbo.LoanUnderwriting;
DROP TABLE Internship.dbo.AcademicRecord;
DROP TABLE Internship.dbo.Balance;
DROP TABLE Internship.dbo.CreditHistory;


-- if you delete tables, delete them all at once, not to have errors with foreign key contraints


CREATE TABLE Internship.dbo.CreditHistory(
    CreditHistoryID INT PRIMARY KEY,
	PayingTime DATETIME,
	SumOfMoneyReturned INT
)

CREATE TABLE Internship.dbo.AcademicRecord (
  AcademicRecordID INT PRIMARY KEY,
  NrOfDiplomas INT, 
  AvgMarkUniversity float, 
  AvgMarkSchool float
);

CREATE TABLE Internship.dbo.Balance (
  BalanceID INT PRIMARY KEY,
  InstallmentYear INT,
  InstallmentMonth INT,
  InstallmentSum INT,
);

CREATE TABLE Internship.dbo.LoanUnderwriting (
  LoanUnderwritingID INT PRIMARY KEY,
  IsAproved VARCHAR(20) NULL, 
  ApprovalDate DATE, 
  CreditHistoryID INT FOREIGN KEY REFERENCES  Internship.dbo.CreditHistory(CreditHistoryID) ON DELETE SET NULL,
  AcademicRecordID INT FOREIGN KEY REFERENCES  Internship.dbo.AcademicRecord(AcademicRecordID) ON DELETE SET NULL
);

CREATE TABLE Internship.dbo.Loan (
  LoanID INT NOT NULL PRIMARY KEY, 
  LoanType VARCHAR(30), 
  LoanSum INT,
  LoanReturnRate VARCHAR(30), 
  MontlhyAnalysis VARCHAR(30), 
);

CREATE TABLE Internship.dbo.Account (
  AccountID INT PRIMARY KEY, 
  BalanceID INT FOREIGN KEY REFERENCES Internship.dbo.Balance(BalanceID) ON DELETE SET NULL,
  LoanUnderWritingID INT FOREIGN KEY REFERENCES Internship.dbo.LoanUnderwriting(LoanUnderwritingID) ON DELETE SET NULL,
  LoanID INT FOREIGN KEY REFERENCES Internship.dbo.Loan(LoanID) ON DELETE SET NULL,
  AccountStatus VARCHAR(30) NOT NULL DEFAULT 'Unactivated', 
  RecoveryPassword VARCHAR(30), 
  CreationDate DATETIME, 
);

CREATE TABLE Internship.dbo.Client (
  ClientID INT PRIMARY KEY,
  AccountID INT FOREIGN KEY REFERENCES Internship.dbo.Account(AccountID) ON DELETE SET NULL, 
  ClientName VARCHAR(30) NOT NULL, 
  ClientSurname VARCHAR(30) NOT NULL, 
  Gender CHAR NOT NULL, 
  NationalID VARCHAR(30) NOT NULL UNIQUE,
  Country VARCHAR(30) DEFAULT 'Moldova', 
  HomeAddress VARCHAR(200), 
  EmailAddress VARCHAR(30), 
  Remarks VARCHAR(30), 
  CreationDate DATETIME
);

select * from Internship.dbo.Client;
select * from Internship.dbo.Account;
select * from Internship.dbo.AcademicRecord;
SELECT * FROM Internship.dbo.LoanUnderwriting;
SELECT * FROM Internship.dbo.CreditHistory;
SELECT * FROM Internship.dbo.Balance;
SELECT * FROM Internship.dbo.Loan;

DELETE FROM Internship.dbo.Client;
DELETE FROM Internship.dbo.Account;
DELETE FROM Internship.dbo.Balance;
DELETE FROM Internship.dbo.AcademicRecord;
DELETE FROM Internship.dbo.CreditHistory;
DELETE FROM Internship.dbo.Loan;
DELETE FROM Internship.dbo.LoanUnderwriting;


-- one client
INSERT INTO Internship.dbo.Client VALUES(1, NULL, 'Ioan', 'Moruz', 'M', '4555555555555', 'Ucraina', 'Ginta Latina 13/2', 'moruz@yahoo.com', 'No current remarks', SYSDATETIME());
INSERT INTO Internship.dbo.AcademicRecord VALUES(1, 4, 5.8, 9.2);
INSERT INTO Internship.dbo.LoanUnderwriting VALUES(1, 'FALSE',  NULL, NULL, 1);
INSERT INTO Internship.dbo.Loan VALUES(1, 'NORMAL RATE STUDENT LOAN', 10000, 5, 'Set up');
INSERT INTO Internship.dbo.Account VALUES(1, NULL, 1, 1, 'APROVED', 'GINGER', SYSDATETIME());

UPDATE  Internship.dbo.Client 
SET AccountID = 1
WHERE ClientID = 1;

UPDATE Internship.dbo.LoanUnderwriting
SET IsAproved = 'Aproved',
ApprovalDate = SYSDATETIME()
WHERE LoanUnderwritingID = 1;

-- second client

INSERT INTO Internship.dbo.Client VALUES(2, NULL, 'Vasile', 'Ionescu', 'M', '45498459749944', 'Romania', 'Buevardul Moscovei 11', 'vionescu@yahoo.com', 'Orphan', SYSDATETIME());
INSERT INTO Internship.dbo.AcademicRecord VALUES(2, 2, 7.9, 10.0);
INSERT INTO Internship.dbo.LoanUnderwriting VALUES(2, 'FALSE',  NULL, NULL, 2);
INSERT INTO Internship.dbo.Loan VALUES(2, 'NORMAL RATE STUDENT LOAN', 23590, 5, 'Set up');
INSERT INTO Internship.dbo.Account VALUES(2, NULL, 2, 2, 'APROVED', 'FREYA', SYSDATETIME());

UPDATE  Internship.dbo.Client 
SET AccountID = 2
WHERE ClientID = 2;

UPDATE Internship.dbo.LoanUnderwriting
SET IsAproved = 'Aproved',
ApprovalDate = SYSDATETIME()
WHERE LoanUnderwritingID = 2;

-- third client

INSERT INTO Internship.dbo.Client VALUES(3, NULL, 'Ana-Maria', 'Techerea', 'F', '34433434343', 'Republica Moldova', 'Strada Studentilor 28', 'ana_maria.mail.ru', 'No current remarks', SYSDATETIME());
INSERT INTO Internship.dbo.AcademicRecord VALUES(3,3, 8.5, 7.88);
INSERT INTO Internship.dbo.LoanUnderwriting VALUES(3, 'FALSE',  NULL, NULL, 3);
INSERT INTO Internship.dbo.Loan VALUES(3, 'ERASMUS FACILITY STUDENT LOAN', 45000, 7, 'Set up');
INSERT INTO Internship.dbo.Account VALUES(3, NULL, 3, 3, 'PENDING', 'SAND', SYSDATETIME());

UPDATE  Internship.dbo.Client 
SET AccountID = 3
WHERE ClientID = 3;

UPDATE Internship.dbo.LoanUnderwriting
SET IsAproved = 'Aproved',
ApprovalDate = SYSDATETIME()
WHERE LoanUnderwritingID = 3;


-- fourth client

INSERT INTO Internship.dbo.Client VALUES(4, NULL, 'Patricia', 'Hodorogea', 'F', '4545485794', 'Republica Moldova', 'Strada Stejarilor 18', 'p.techerea@gmail.com', 'No current remarks', SYSDATETIME());
INSERT INTO Internship.dbo.AcademicRecord VALUES(4,0, 7.8, 6.55);
INSERT INTO Internship.dbo.LoanUnderwriting VALUES(4, 'FALSE',  NULL, NULL, 4);
INSERT INTO Internship.dbo.Loan VALUES(4, 'NORMAL RATE STUDENT LOAN', 10000, 5, 'Set up');
INSERT INTO Internship.dbo.Account VALUES(3, NULL, 3, 3, 'PENDING', 'SAND', SYSDATETIME());

UPDATE  Internship.dbo.Client 
SET AccountID = 4
WHERE ClientID = 4;

UPDATE Internship.dbo.LoanUnderwriting
SET IsAproved = 'Not Aproved',
ApprovalDate = SYSDATETIME()
WHERE LoanUnderwritingID = 4;
