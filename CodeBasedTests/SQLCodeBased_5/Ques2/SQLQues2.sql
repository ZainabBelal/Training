select * from employee
declare @empno int 
declare @empsal numeric(10,2)
declare employeecursor cursor for
select empno,sal from employee
where deptno=20

declare @newsal numeric(10,2)
open employeecursor
fetch next from employeecursor into @empno,@empsal
while @@FETCH_STATUS=0
begin
	set @newsal=@empsal*1.15
	update employee
	set sal=@newsal
	where empno=@empno
	fetch next from employeecursor into @empno,@empsal
end
close employeecursor
deallocate employeecursor

select empno,ename,sal,deptno from employee where deptno=20