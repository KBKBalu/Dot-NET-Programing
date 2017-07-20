Alter PROC sp_EditEmpRecord 
 (
  @Name varchar(250),
  @Address varchar(250),
  @Designation varchar(50),
  @Id int
 )
 As
	Begin

		if exists(select Address from Employee WHERE Name=@Name)
		BEGIN
		PRINT 'Name already exists'
		END

	ELSE

		BEGIN
		UPDATE Employee SET NAME = @Name,ADDRESS = @Address, DESIGNATION=@Designation WHERE Id = @Id;	
		END
	End


	sp_EditEmpRecord 'iit','Hyd','FLMC',5