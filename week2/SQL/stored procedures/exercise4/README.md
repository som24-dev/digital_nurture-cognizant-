# Exercise 4: Execute a Stored Procedure

## Goal
Execute the stored procedure `sp_GetEmployeesByDepartment` with a `DepartmentID` parameter and display the output.

---

## Explanation

In a real SQL environment, we would run:

### SQL Server Syntax:
```sql
EXEC sp_GetEmployeesByDepartment @DeptID = 4;

SQL Server Syntax : EXEC sp_GetEmployeesByDepartment @DeptID = 4;

## ⚠️ Limitation: Stored Procedure Not Supported in DB Fiddle

Since **DB Fiddle** (an online SQL playground) does **not support** `CREATE PROCEDURE` or `CALL` statements, the stored procedure could not be executed directly.

---

### ✅ Workaround:
To simulate this behavior, we used a plain `SELECT` query with a hardcoded `DepartmentID` as shown below.

---

### 🔁 Simulated Query
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
