1. Create a database in the SQL server called "Taller"

2. Add a new table to the SQL Server by running the script

CREATE TABLE Users (
    UserName VARCHAR(50) NOT NULL,
    Name VARCHAR(200) NULL,
    PRIMARY KEY (UserName)
);

3. Change the ConnectionStrings in the "appsettings.json" to your local machine connection by configuring the "DefaultConnection"
