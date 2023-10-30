use Assignment_DB
select * from employee

--1.	Write a T-SQL Program to find the factorial of a given number.

create or alter procedure factorial(@num int)
as
begin
	declare @i int=1,@fact int=1
		while(@i<=@num)
		begin 
			set @fact=@fact*@i
			set @i+=1
		end
	print 'Factorial of '+cast(@num as varchar(5))+' is:'+cast(@fact as varchar(max))
end

factorial 8

--2.	Create a stored procedure to generate multiplication tables up to a given number.


create or alter proc MultiplicationTable(@maxnum int)
as 
begin
	declare @num1 int,@num2 int,@res int
	set  @num1=1
	while (@num1<=@maxnum)
	begin
		set @num2=1
		while @num2<=10
		begin
			set @res=@num1*@num2
			print (cast(@num1 as varchar(5))+'x'+cast(@num2 as varchar(5))+'='+cast(@res as varchar(10)))
			set @num2+=1
		end
		set @num1+=1
	end
end

MultiplicationTable 6

--3.  Create a trigger to restrict data manipulation on EMP table during General holidays. 
--Display the error message like “Due to Independence day you cannot manipulate data” 
--or "Due To Diwali", you cannot manupulate" etc
--Note: Create holiday table as (holiday_date,Holiday_name) store at least 4 holiday details. try to match and stop manipulation 
create table holiday
( 
	holiday_date date,
	holiday_name varchar(30)
)
insert into holiday values
	('2023-01-26','Republic Day'),
	('2023-03-08','Holi'),
	('2023-04-21','Eid-ul-fitr'),
	('2023-08-15','Independece Day'),
	('2023-10-14','Sunday')

select * from holiday
select * from employee

create or alter trigger holidayalert
on employee
for insert
as
begin
	declare @today int
	set @today = datename(weekday,getdate())
	if @today ='holiday_date'
	begin
	print 'No data is inserted'+ cast(@today as varchar(20))
	end
end

insert into employee values (1,'ajay','clerk',123,'2001-12-12',200,100,null)

select * from employee


