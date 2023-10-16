use Assignment_DB

select * from employee

--1. Retrieve a list of MANAGERS. 
select ename from employee where job='MANAGER'

--2. Find out the names and salaries of all employees earning more than 1000 per month. 
select ename, sal from employee 
where sal>1000

--3. Display the names and salaries of all employees except JAMES. 
select ename,sal from employee 
where ename not like 'JAMES'

--4. Find out the details of employees whose names begin with ‘S’. 
select * from employee where ename like 'S%'

--5. Find out the names of all employees that have ‘A’ anywhere in their name. 
select ename from employee where ename like '%A%'

--6. Find out the names of all employees that have ‘L’ as their third character in their name. 
select ename from employee where ename like '%__L%'

--7. Compute daily salary of JONES.
select ename,sal,(sal/30) as 'Daily salary' from employee where ename='JONES'

--8. Calculate the total monthly salary of all employees. 
select sum(sal) as 'Total monthly salary of all employees' from employee

--9. Print the average annual salary .
select avg(sal*12) as 'Average annual salary' from employee

--10. Select the name, job, salary, department number of all employees except SALESMAN from department number 30. 
select ename, job,sal,deptno from employee
where job not like 'SALESMAN' and deptno like '30'

--11. List unique departments of the EMP table.
select distinct deptno as 'List of department numbers' from employee

--12. List the name and salary of employees who earn more than 1500 and are in department 10 or 30. Label the columns Employee and Monthly Salary respectively.
select ename as 'Employee',sal as 'Monthly Salary',deptno as 'Department Number' from employee
where sal>1500 and deptno like '10' or deptno like '30'

--13. Display the name, job, and salary of all the employees whose job is MANAGER or ANALYST and their salary is not equal to 1000, 3000, or 5000.
select ename,job,sal from employee 
where job ='MANAGER' or job ='ANALYST' 
and 
sal not in (1000,3000,5000)

--14. Display the name, salary and commission for all employees whose commission amount is greater than their salary increased by 10%. 
select ename as'Employee',sal as 'salary',comm as 'commision' from employee 
where (comm>(sal+(0.10*sal)))

--15. Display the name of all employees who have two Ls in their name and are in department 30 or their manager is 7782.
select ename from employee
where (deptno = 30 OR mgrid = 7782) and ename LIKE '%L%L%'

--16. Display the names of employees with experience of over 30 years and under 40 yrs.Count the total number of employees. 
select ename, Datediff(year,hiredate,getdate()) as 'Experience'
from employee
where (datediff(year,hiredate,getdate())between 30 and 40) 
select count(*) as 'Total employees' from employee


--17. Retrieve the names of departments in ascending order and their employees in descending order.
select ename as 'Employee name',deptno as 'Department number' from employee
order by deptno asc, ename desc

--18. Find out experience of MILLER. 
select ename,Datediff(year,hiredate,getdate()) as  "Experience" from employee
where ename = 'MILLER'
