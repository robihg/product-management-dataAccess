

## Test and Deploy
How to migrate from code to database mysql 8 :

First Setup after clone repository

1. First, change the contents of "ProductManagementDB" in the appsettings.json file according to the instance and user password on MySql. What needs to be adjusted is
    - Server (is an instance of MySql).
    - Database (is a database from MySql).
    - User ID (is the login user on MySql).
    - Password (is the login password on MySql).
2. If there is a Migration folder, delete all files inside the folder, then open the Package Console Manager.
3. Type 'Add-Migration InitialMigration_GeneralSetting -Context GeneralSettingContext'. The function of the command above is to add a migration file that the Entity Framework will generate, 
    after that, type this script to run the migration 'Update-Database -Context GeneralSettingContext'.
4. Do the same for Product DataContext with this script 'Add-Migration InitialMigration_Product -Context ProductContext' and this 'Update-Database -Context ProductContext'
5. After that, build the entire solution,and if it's done and there are no errors, go to ../ProductManagement.DataAccess/bin/Debug/net8.0, and then copy ProductManagement.DataAccess.dll into ../libs folder in main     Framework product-management, adn after copying inside the libs folder, run the main framework product-management

## Name
Product Management

## Description
This is a Backend DataAccess project using .Net Core 8 and Entity Framework and using MySql for Product Management applications
