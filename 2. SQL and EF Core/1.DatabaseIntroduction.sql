DROP TABLE Internship.dbo.Client;
DROP TABLE Internship.dbo.Account;
DROP TABLE Internship.dbo.Loan;
DROP TABLE Internship.dbo.LoanUnderwriting;
DROP TABLE Internship.dbo.AcademicRecord;
DROP TABLE Internship.dbo.Balance;

EXEC sp_fkeys Client

CREATE TABLE Internship.dbo.Client (
  ClientID INT PRIMARY KEY,
  ClientName VARCHAR NOT NULL, 
  ClientSurname VARCHAR NOT NULL, 
  Gender char NOT NULL, 
  NationalID VARCHAR NOT NULL UNIQUE,
  Country VARCHAR, 
  HomeAddress VARCHAR, 
  EmailAddress VARCHAR, 
  Remarks VARCHAR, 
  CreationDate DATETIME
);

CREATE TABLE Internship.dbo.Account (
  AccountID INT PRIMARY KEY, 
  ClientID INT FOREIGN KEY REFERENCES Internship.dbo.Client(ClientID) ON DELETE SET NULL, 
  AccountStatus VARCHAR NOT NULL, 
  RecoveryPassword VARCHAR, 
  CreationDate DATETIME, 
);

CREATE TABLE Internship.dbo.AcademicRecord (
  AcademicRecordID INT PRIMARY KEY,
  NrOfDiplomas INT, 
  avgMarkUniversity float, 
  avgMarkSchool float
);


CREATE TABLE Internship.dbo.Balance (
  BalanceID INT PRIMARY KEY,
  InstallmentYear INT,
  InstallmentMonth INT,
  InstallmentSum INT,
);

CREATE TABLE Internship.dbo.Loan (
  LoanID INT NOT NULL, 
  LoanType VARCHAR, 
  LoanSum VARCHAR,
  LoanReturnRate VARCHAR, 
  MontlhyAnalysisID VARCHAR, 
  BalanceID INT FOREIGN KEY REFERENCES Internship.dbo.Balance(BalanceID) ON DELETE SET NULL
);

CREATE TABLE Internship.dbo.CreditHistory(
    CreditHistoryID INT PRIMARY KEY,
	PayingTime DATETIME,
	SumOfMoneyReturned INT
)

CREATE TABLE Internship.dbo.LoanUnderwriting (
  LoanUnderwritingID INT PRIMARY KEY,
  AccountID INT FOREIGN KEY REFERENCES Internship.dbo.Account(AccountID) ON DELETE SET NULL, 
  IsAproved INT NULL, 
  ApprovalDate DATE, 
  CreditHistoryID INT FOREIGN KEY REFERENCES  Internship.dbo.CreditHistory(CreditHistoryID) ON DELETE SET NULL,
  AcademicRecordID INT FOREIGN KEY REFERENCES  Internship.dbo.AcademicRecord(AcademicRecordID) ON DELETE SET NULL
);
