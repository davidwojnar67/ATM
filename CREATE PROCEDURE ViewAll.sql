CREATE PROCEDURE ViewAll
AS
BEGIN
select * from Clients;
select * from Accounts;
select * from TransactionHistory;
select * from Cdl_Movements;
END;