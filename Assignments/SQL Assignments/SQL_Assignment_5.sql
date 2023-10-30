
create or alter proc employeepayslip(@employeename varchar(15))
as
begin
	declare @basic_sal decimal, @hra decimal,@da decimal,@pf decimal,@it decimal,@deduction decimal,@grosssal decimal,@netsal decimal

	select @basic_sal=sal from employee where ename=@employeename

	if @basic_sal is null
	begin 
		print 'Salary not found'
		return
	end
	set @HRA = 0.10 * @basic_sal
    set @DA = 0.20 * @basic_sal
    set @PF = 0.08 * @basic_sal
    set @IT = 0.05 * @basic_sal

	set @deduction=@pf+@it

	set @grosssal=@basic_sal+@hra+@da

	set @netsal=@grosssal-@deduction
   print 'Employee Name: ' + @employeeName
    print 'Basic Salary: ' + CAST(@Basic_Sal AS VARCHAR)
    print 'HRA: ' + CAST(@HRA AS VARCHAR)
    print 'DA: ' + CAST(@DA AS VARCHAR)
    print 'PF: ' + CAST(@PF AS VARCHAR)
    print 'IT: ' + CAST(@IT AS VARCHAR)
    print 'Deductions: ' + CAST(@Deduction AS VARCHAR)
    print 'Gross Salary: ' + CAST(@GrossSal AS VARCHAR)
    print 'Net Salary: ' + CAST(@NetSal AS VARCHAR)

end

employeepayslip 'SMITH'


		