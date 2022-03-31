select * from Internship.dbo.Client;
select * from Internship.dbo.Account;
select * from Internship.dbo.AcademicRecord;
SELECT * FROM Internship.dbo.LoanUnderwriting;
--SELECT * FROM Internship.dbo.CreditHistory;
--SELECT * FROM Internship.dbo.Balance;
SELECT * FROM Internship.dbo.Loan;

SELECT TOP 2 ClientID, AccountID, ClientName, ClientSurname FROM Internship.dbo.Client;

SELECT LoanUnderwritingID, AcademicRecordID FROM Internship.dbo.LoanUnderwriting;

SELECT * FROM Internship.dbo.AcademicRecord
WHERE NrOfDiplomas > 2 AND AvgMarkUniversity >8;

SELECT * FROM Internship.dbo.Account WHERE RecoveryPassword IS NULL;

SELECT c.ClientName, c.ClientSurname, c.EmailAddress AS 'Client Registered Email Address', a.CreationDate AS 'Account Creation Date ', l.LoanSum FROM Internship.dbo.Client c
JOIN Internship.dbo.Account a ON c.AccountID = a.AccountID
JOIN Internship.dbo.Loan l ON a.LoanID = l.LoanID;


SELECT c.ClientName, c.ClientSurname, c.EmailAddress AS 'Client Registered Email Address', a.CreationDate AS 'Account Creation Date ', l.LoanSum FROM Internship.dbo.Client c
RIGHT JOIN Internship.dbo.Account a ON c.AccountID = a.AccountID
RIGHT JOIN Internship.dbo.Loan l ON a.LoanID = l.LoanID;

SELECT c.ClientSurname, c.ClientName, c.EmailAddress AS 'Client Registered Email Address', a.CreationDate AS 'Account Creation Date ', l.LoanSum FROM Internship.dbo.Client c
LEFT JOIN Internship.dbo.Account a ON c.AccountID = a.AccountID
LEFT JOIN Internship.dbo.Loan l ON a.LoanID = l.LoanID
ORDER BY 1,2;

SELECT c.ClientName, c.ClientSurname, c.EmailAddress AS 'Client Registered Email Address', a.CreationDate AS 'Account Creation Date ', l.LoanSum FROM Internship.dbo.Client c
JOIN Internship.dbo.Account a ON c.AccountID = a.AccountID
JOIN Internship.dbo.Loan l ON a.LoanID = l.LoanID
WHERE c.ClientSurname LIKE '%o%';


SELECT * FROM Internship.dbo.AcademicRecord 
ORDER BY 4 DESC,3 DESC,2 DESC;
