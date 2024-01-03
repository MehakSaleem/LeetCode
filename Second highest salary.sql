select  max(e.salary) as SecondHighestSalary
from Employee as e
where salary < (select max(salary) from Employee)