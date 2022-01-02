CREATE PROCEDURE DeleteTheEntireClient (@IdClient INT)
AS
BEGIN
DECLARE @IdCAcc INT, @IdSAcc INT;

SET @IdCAcc = (select CurrentAccountIdAccount from Clients where IdClient = @IdClient);
SET @IdSAcc = (select SavingsAccountIdAccount from Clients where IdClient = @IdClient);

delete from TransactionHistory where IdAccount in (@IdCAcc, @IdSAcc);
delete from Clients where IdClient = @IdClient;
delete from Accounts where IdAccount in (@IdCAcc, @IdSAcc);
END;