# Cafe Management System ☕

A sleek, high-performance C# Windows Forms desktop application designed to streamline daily coffee shop operations. Built with a modern UI and a lightweight footprint, it seamlessly bridges the gap between front-of-house order processing and back-of-house inventory tracking.

---

## ⚠️ Important: Database Setup Required
> [!IMPORTANT]
> If you are cloning or downloading this repository to run it locally, **you must set up the database first**. The application relies on a local database to store menu items, billing logs, and user credentials. It will throw errors if the database is missing.

### How to configure the database:
1. Locate the `.sql` backup script provided in the `/Database` folder of this project.
2. Open your database management tool (e.g., Microsoft SQL Server Management Studio).
3. Create a new database named `CafeManagementDB` (or your preferred name) and execute the script to generate the required tables and sample data.
4. Update the **Connection String** in your application's `App.config` file to match your local SQL Server instance:
   ```xml
   <connectionStrings>
       <add name="CafeDbConnection" 
            connectionString="Data Source=YOUR_SERVER_NAME;Initial Catalog=CafeManagementDB;Integrated Security=True;" 
            providerName="System.Data.SqlClient" />
   </connectionStrings>
