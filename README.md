# HRMS-project


# Database & Visual Studio

- Open backend .NET project by double-clicking .sln file
- click ‘View’ tab found on navbar
- click SQL Server Object Explorer
- expand (localdb)
- right click on 'Databases' folder
- select Add new database
- click on the created database so it expands and then right click on the database name
- click ‘Properties’
- find ‘Connection string‘ under ‘General’ and copy the field value
- Navigate to ’Solution Explorer’ tab and double click ’Web.config’
- In 12th row find ‘connectionString‘ attribute and inside the quotation marks of the given attribute delete existing value and paste the one you copied earlier
- Hit the following four keys in succession without holding the ALT key ( ALT > T > N > O )
- Type ‘update-database’ in the console to fill database with some test data
- OPTIONAL: add more test data by navigating to Migrations folder in Solution Explorer and click Configuration.cs . Add more data.


# React

- Open visual studio code editor (or prefered editor)
- if it is VS Code click CTRL + SHIFT + ` to open cmd console
- Type ‘cd’ hit space and drag ‘HRMS-front’ folder to the console and then click enter
- Type ‘npm install’ to install the dependencies
- Navigate to ‘src > api > timesheetApi.js ‘ and change the url to match your localhost:port.
- Type ‘npm start’ in the console to run the project


