alter procedure sp_UpdPass
--declare
@Usuario varchar(30),
@Password varchar(30)
as
Update [dbo].[Cre_Cat_Usuario]
set     Pass = @Password
where   Usuario = @Usuario



select*from [dbo].[Cre_Cat_Usuario]