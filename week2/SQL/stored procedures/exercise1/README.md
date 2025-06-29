# Exercise: Stored Procedures – Employee Management

##  Goal:
Create two stored procedures to:
1. Retrieve employee details by department
2. Insert a new employee

---

##  Stored Procedures:

### 1. `sp_GetEmployeesByDepartment`
- Takes `@DeptID` as input
- Returns all employees in that department (joined with department name)

### 2. `sp_InsertEmployee`
- Takes employee details as parameters
- Inserts a new employee into the `Employees` table

---

-- Test call to insert an employee
CALL sp_InsertEmployee('Sam', 'Wilson', 4, 6500.00, '2024-06-01');

-- Test call to get employees from Marketing (DepartmentID = 4)
CALL sp_GetEmployeesByDepartment(4);


## Usage Example:

```sql
EXEC sp_GetEmployeesByDepartment @DeptID = 2;

EXEC sp_InsertEmployee 
    @FirstName = 'Sam', 
    @LastName = 'Wilson', 
    @DepartmentID = 4, 
    @Salary = 6500.00, 
    @JoinDate = '2024-06-01';


---


## Note on Stored Procedure Execution

Due to limitations in **DB Fiddle**, `CREATE PROCEDURE` and `CALL` statements are **not supported**.

Therefore, the functionality of the stored procedure `sp_GetEmployeesByDepartment` was **simulated using a standard `SELECT` query** with a hardcoded `DepartmentID` value.

This allows us to test and demonstrate the same logic and output, even though the stored procedure cannot be executed directly in the online tool.

## Simulated Query (SELECT instead of Procedure)

```sql
SELECT 
    e.EmployeeID,
    e.FirstName,
    e.LastName,
    d.DepartmentName,
    e.Salary,
    e.JoinDate
FROM Employees e
JOIN Departments d ON e.DepartmentID = d.DepartmentID
WHERE e.DepartmentID = 4;