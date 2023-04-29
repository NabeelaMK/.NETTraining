USE [EmpDB]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[ShowEmpWithId]
		@empid = 103

SELECT	'Return Value' = @return_value

GO
