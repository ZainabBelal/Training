create table code_employeee
(
	empno int primary key,
	empname varchar(35) not null,
	empsal numeric(10,2) check (empsal>=25000),
	emptype char(1) check(emptype in ('F','P'))
)

insert into code_employeee values
	(1001,'SMITH',26000,'F'),
	(1002,'ALLEN',30000,'P'),
	(1003,'WARD',27500,'P'),
	(1004,'MARTIN',28000,'F'),
	(1005,'BLAKE',26500,'F')

select empno as 'EMPLOYEE NUMBER',empname as 'EMPLOYEE NAME',empsal as 'EMPLOYEE SALARY', emptype as 'EMPLOYEE TYPE(F->Full time/P->Part time)' from code_employeee

create proc insert_emp_records(@empname varchar(35),@empsal numeric(10,2),@emptype char(1))
as
begin
	declare @newempno int
	select @newempno =coalesce(max(empno), 0) + 1  from code_employeee
	insert into code_employeee(empno, empname, empsal, emptype) VALUES (@newempno, @empname, @empsal, @emptype)
	select @newempno as EMPNO
end

