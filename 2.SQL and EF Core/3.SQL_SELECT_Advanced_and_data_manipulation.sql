select * from Internship.dbo.AcademicRecord;

select * from Internship.dbo.Client;
select * from Internship.dbo.Account;
select * from Internship.dbo.AcademicRecord;
SELECT * FROM Internship.dbo.LoanUnderwriting;
--SELECT * FROM Internship.dbo.CreditHistory;
--SELECT * FROM Internship.dbo.Balance;
SELECT * FROM Internship.dbo.Loan;


-- select the number of diplomas of each client
SELECT c.ClientSurname, c.ClientName, ar.NrOfDiplomas FROM Internship.dbo.Client c
JOIN Internship.dbo.Account a ON a.AccountID = c.AccountID
JOIN Internship.dbo.LoanUnderwriting l ON l.LoanUnderwritingID = a.LoanUnderWritingID
JOIN Internship.dbo.AcademicRecord ar ON l.AcademicRecordID = ar.AcademicRecordID;


-- Write several grouping queries, include HAVING clause
-- average of diplomas per country
SELECT c.Country AS 'Country of origin', AVG(ar.NrOfDiplomas) AS 'Average of diplomas per country' FROM Internship.dbo.Client c
JOIN Internship.dbo.Account a ON a.AccountID = c.AccountID
JOIN Internship.dbo.LoanUnderwriting l ON l.LoanUnderwritingID = a.LoanUnderWritingID
JOIN Internship.dbo.AcademicRecord ar ON l.AcademicRecordID = ar.AcademicRecordID
GROUP BY c.Country
HAVING AVG(ar.NrOfDiplomas)>=2;

-- insert select statement
DROP TABLE Internship.dbo.NewAccount;
SELECT AccountID, LoanUnderWritingID, LoanID INTO Internship.dbo.NewAccount FROM Internship.dbo.Account WHERE 1 = 0;


INSERT INTO Internship.dbo.NewAccount(AccountID, LoanUnderWritingID, LoanID)
SELECT AccountID, LoanUnderWritingID, LoanID 
FROM Internship.dbo.Account;

SELECT * FROM Internship.dbo.NewAccount;

-- truncate statement - used to remove all record from the table
TRUNCATE TABLE Internship.dbo.NewAccount;

INSERT INTO Internship.dbo.NewAccount(AccountID, LoanUnderWritingID, LoanID)
SELECT AccountID, LoanUnderWritingID, LoanID 
FROM Internship.dbo.Account;

-- delete based join - delete operations in multiple tables
DELETE a
FROM Internship.dbo.Account AS a LEFT JOIN Internship.dbo.Loan l
ON a.LoanID = l.LoanID
WHERE l.LoanSum < 500;


-- update based join
	
UPDATE Internship.dbo.LoanUnderwriting
SET 
	Internship.dbo.LoanUnderwriting.IsAproved = 'True'
FROM 
	Internship.dbo.LoanUnderwriting u
	INNER JOIN Internship.dbo.AcademicRecord a
	ON u.AcademicRecordID = a.AcademicRecordID
	WHERE a.AvgMarkUniversity > 8;
	

	
SELECT *  FROM Internship.dbo.Account
-- consider rewriting an update based on join with merge command

--MERGE target_table_name AS TARGET  

-- you can use any other name in place of source 
CREATE TABLE Internship.dbo.LoanTestMerge (
  LoanID INT NOT NULL PRIMARY KEY, 
  LoanType VARCHAR(30), 
  LoanSum INT,
  LoanReturnRate VARCHAR(30), 
  MontlhyAnalysis VARCHAR(30), 
);

CREATE TABLE Internship.dbo.LoanTest2Merge (
  LoanID INT NOT NULL PRIMARY KEY, 
  LoanType VARCHAR(30), 
  LoanSum INT,
  LoanReturnRate VARCHAR(30), 
  MontlhyAnalysis VARCHAR(30), 
);

-- MERGE statement combines INSERT, UPDATE, and DELETE operations into a single statement
-- target table + source_table

MERGE Internship.dbo.LoanTestMerge AS l1
USING  Internship.dbo.LoanTest2Merge AS  l2
ON l1.LoanID = l2.LoanID 
WHEN NOT MATCHED  
    THEN 
	INSERT (LoanType, LoanSum, LoanReturnRate)
	VALUES (l2.LoanType, l2.LoanSum, l2.LoanReturnRate);
