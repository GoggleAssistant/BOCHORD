# BOCHORD: A Library Management System

## Overview  
This Windows Forms application is a simple **Library Management System** designed to manage book inventories, user accounts, and book issue records. The app uses a pre-existing SQL Server LocalDB database file (`library.mdf`) to store all data.

## Features  
- **User Login**: Secure login through a separate login form.  
- **Book Management**: Add, view, update, and delete book records.  
- **Issue Management**: Manage book issue transactions and returns.  
- **User Accounts**: Manage library users and their credentials.  
- **Splash Screen**: Animated splash screen with progress bar on app start.

## Architecture & Technologies  
- Developed using **C# Windows Forms (.NET Framework)**.  
- Uses **SQL Server LocalDB** with an attached `.mdf` database file (`library.mdf`).  
- Database interactions via **`System.Data.SqlClient`**.  
- Data folder and database file located within the application directory (`bin\Data\library.mdf`).

## Important Notes  
- The database creation code has been removed; the app expects the database file to already exist in the `Data` folder.  
- The app will fail if the database file is missing or inaccessible—make sure `library.mdf` is present in the `Data` folder.

