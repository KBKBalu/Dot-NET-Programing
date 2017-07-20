alter PROC sp_EmpRecord 
 (
  @Name varchar(250),
  @Address varchar(250),
  @Designation varchar(50)
 )
 As
	Begin

		if exists(select ID from Employee WHERE Name=@Name)
		BEGIN
		PRINT 'Name already exists'
		END

	ELSE

		BEGIN
		insert into Employee (NAME,Address,Designation) VALUES(@Name,@Address,@Designation)	
		END
		

	End

	


	--sp_EmpRecord 'Balu','Hyd','ASE','KK'
	--select Address from Employee WHERE Name='Balu'

	--if exists(Select * from Employee Where Name=@Name)
	--		Begin
	--		Set @Name='Name Already Exist!'
	--		Print @Name
	--		End
	--	else
	--		Begin
	--		insert into Employee (NAME,Address,Designation) VALUES(@Name,@Address,@Designation)
	--		Set @Name='No Record found'
	--		Print @Name
	--		End
