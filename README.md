# asp.net-stored-procedure
## To create a stored Procedure:
### In your database expand Programmability section and right click on stored procedure and create new stored procedure
![image](https://user-images.githubusercontent.com/47690409/142003932-767c675a-1855-4788-8221-6be4c2644351.png)

#### Write Stored procedure

#### For example: 
Create Procedure spEmployees_Insert
@Id int,
@Name nvarchar(50),
@Email nvarchar(50)
as begin
delete from Employees where Id=@Id
end
