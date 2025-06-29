CREATE TABLE Departments (
 DepartmentID INT PRIMARY KEY,
 DepartmentName VARCHAR(100)
);

CREATE TABLE Employees (
 EmployeeID INT AUTO_INCREMENT PRIMARY KEY,
 FirstName VARCHAR(50),
 LastName VARCHAR(50),
 DepartmentID INT,
 Salary DECIMAL(10,2),
 JoinDate DATE,
 FOREIGN KEY (DepartmentID) REFERENCES Departments(DepartmentID)
);

INSERT INTO Departments (DepartmentID, DepartmentName) VALUES
(1, 'HR'),
(2, 'Finance'),
(3, 'IT'),
(4, 'Marketing');

INSERT INTO Employees (FirstName, LastName, DepartmentID, Salary, JoinDate) VALUES
('John', 'Doe', 1, 5000.00, '2020-01-15'),
('Jane', 'Smith', 2, 6000.00, '2019-03-22'),
('Michael', 'Johnson', 3, 7000.00, '2018-07-30'),
('Emily', 'Davis', 4, 5500.00, '2021-11-05');


-- Insert Employee Procedure (no DELIMITER)
CREATE PROCEDURE sp_InsertEmployee (
    IN FirstName VARCHAR(50),
    IN LastName VARCHAR(50),
    IN DeptID INT,
    IN Salary DECIMAL(10,2),
    IN JoinDate DATE
)
BEGIN
    INSERT INTO Employees (FirstName, LastName, DepartmentID, Salary, JoinDate)
    VALUES (FirstName, LastName, DeptID, Salary, JoinDate);
END;

-- Get Employees by Department Procedure (no DELIMITER)
CREATE PROCEDURE sp_GetEmployeesByDepartment (
    IN DeptID INT
)
BEGIN
    SELECT 
        e.EmployeeID,
        e.FirstName,
        e.LastName,
        d.DepartmentName,
        e.Salary,
        e.JoinDate
    FROM Employees e
    JOIN Departments d ON e.DepartmentID = d.DepartmentID
    WHERE e.DepartmentID = DeptID;
END;


-- Insert a new employee
CALL sp_InsertEmployee('Sam', 'Wilson', 4, 6500.00, '2024-06-01');

-- Get employees in Marketing (DepartmentID = 4)
CALL sp_GetEmployeesByDepartment(4);

