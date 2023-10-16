use Assignment_DB


--creating table department
create table deptm
(
	deptno int primary key,
	dname varchar(20),
	loc varchar(15)
)

--creating table employee
create table empl
(
	empno int,
	ename varchar(15),
	job varchar(15),
	mgrid int,
	hiredate DATE,
	sal int,
	comm int,
	deptno int foreign key references deptm(deptno)
)
insert into empl values
	(7369,'SMITH','CLERK',7902, '1980-12-17', 800,NULL,20),
	(7499,'ALLEN','SALESMAN',7698,'1981-02-20',1600,300,30),
	(7521,'WARD','SALESMAN' ,7698 ,'1981-02-22',1250 ,500 ,30),
	(7566,'JONES','MANAGER',7839,'1981-04-02',2975,NULL,20),
	(7654,'MARTIN','SALESMAN',7698,'1981-09-28',1250,1400,30),
	(7698,'BLAKE','MANAGER',7839,'1981-05-01',2850 ,NULL,30),
	(7782,'CLARK','MANAGER',7839,'1981-06-09',2450,NULL,10),
	(7788,'SCOTT','ANALYST',7566,'1987-04-19',3000,NULL,20),
	(7839,'KING','PRESIDENT',NULL,'1981-11-17',5000,NULL,10),
	(7844,'TURNER','SALESMAN',7698,'1981-09-08',1500,0,30),
	(7876,'ADAMS','CLERK',7788,'1987-05-23',1100,NULL,20),
	(7900,'JAMES','CLERK',7698,'1981-12-03', 950, NULL,30),
	(7902,'FORD','ANALYST',7566,'1981-12-03',3000,NULL,20),
	(7934,'MILLER','CLERK',7782,'1982-01-23',1300 ,NULL,10)

select * from empl


--recursive cte
with mycte(empno,ename,mgrid,emplevel)
as(select empno,ename,mgrid, 1 emplevel
from empl where mgrid is null     -- initial query
union all
select e.empno,e.ename,e.mgrid, mct.emplevel + 1 -- recursive query
from empl e inner join mycte mct on e.mgrid=mct.empno
where e.mgrid is not null)

select * from mycte
order by emplevel




insert into deptm values
	(10  ,  ' ACCOUNTING ', '  NEW YORK'), 
	(20   ,  'RESEARCH  '   ,' DALLAS '),
	(30    , 'SALES  '   , '   CHICAGO'), 
	(40     ,'OPERATIONS' , '  BOSTON ')

select * from deptm
--1
select * from empl where ename like 'A%'

--2
select * from empl where mgrid is NULL

--3
select empno,ename,sal from empl where sal between 1200 and 1400

--4
select * from empl where deptno=20
update empl set sal=sal*1.10 where deptno=20
select * from empl where deptno=20

--5
select count (*) as 'Number of clerks' from empl where job ='CLERK'

--6
select job,avg (sal) as 'Average_Salary',count (*) as 'total employees' 
from empl group by job

--7
select * from empl where sal=( select min(sal) from empl) or sal=(select max(sal) from empl)

--8
select * from deptm where deptno not in(select distinct deptno from empl)

--9
select ename,sal from empl where deptno=20 and job='ANALYST' and sal>1200
order by ename

--10


--11
select ename,sal from empl where ename ='MILLER' or ename ='SMITH'
order by ename

--12
select ename,sal from empl where ename like 'A%' or ename like 'M%' 
order by ename

--13
select ename as 'Employee_name',sal as 'Monthly_salary' ,sal*12 as 'Yearly_salary' 
from empl where ename='SMITH'

--14
select ename as 'Employee_name',sal as 'Employee_salary' 
from empl 
where (sal not between 1500 and 2850)

--15



