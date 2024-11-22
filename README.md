# **🏦 Bank Management System**

A Windows Forms application built with C# and SQL Server, providing robust banking functionalities such as managing clients, transactions, currency exchange, user management, and login tracking. 💼

## **🌟 Features**
The application includes the following main functionalities:

### 1. **🔑 Login System**
- ✅ Secure login with username and password.
- ✅ Validates credentials against a SQL Server database.
- ✅ Tracks login time and stores it in the database.

### 2. **🏠 Home Menu**
- 📊 Displays:
  - Total number of clients in the database.
  - Total number of system users.

### 3. **👥 Manage Clients**
- 📋 View all clients stored in the database.
- 🔍 Search clients by account number.
- ➕ Add new clients with the following details:
  - 🆔 Client ID
  - 🔢 Account Number
  - 📧 Email
  - 🔒 PIN Code
  - 💰 Account Balance
  - 🧑 Client Name
  - 📞 Phone Number
- ❌ Prevents duplicate client records by validating against the database.

### 4. **💵 Transactions**
- **💸 Withdraw**:
  - Displays account balance for the selected client.
  - Allows withdrawal of a specific amount and updates the database.
- **💰 Deposit**:
  - Similar to withdrawal but adds funds to the account.
- **🔄 Transfer**:
  - Facilitates transferring money from one account to another.
  - Requires source and destination account numbers.
  - Updates balances for both accounts.
- **📜 Transfer Log**:
  - Displays the history of all transfers.

### 5. **👩‍💻 Manage Users**
- 📋 View all system users.
- 🔍 Search users by username.
- ➕ Add new users with the following details:
  - 🆔 User ID
  - 🧑 First Name
  - 🧑 Last Name
  - 👤 Username
  - 📞 Phone Number
  - 📧 Email
  - 🔑 Password
  - ⚙️ Permissions

### 6. **🌍 Currency Exchange**
- 📋 View all available currencies.
- 🔍 Search currencies by their code.
- 💱 Exchange currency based on current rates.
- 🛠️ Update currency exchange rates.

### 7. **🕒 Login History**
- 📜 Displays the login history of all users, including:
  - 👤 Username
  - ⏰ Login time

### 8. **🚪 Logout**
- Logs out the current user and returns to the login screen. 🔒

---

## **💻 Technical Details**

### **🛠 Technologies Used**
- **C#**: Application development using Windows Forms.
- **SQL Server**: Backend database to store and manage data.
- **ADO.NET**: For database connectivity and operations.

### **📂 Database Structure**
- **Tables**:
  - 🗂️ `Users`: Stores user information.
  - 🗂️ `Clients`: Stores client information.
  - 🗂️ `Transactions`: Tracks all transactions (withdrawals, deposits, transfers).
  - 🗂️ `Currencies`: Stores currency details and rates.
  - 🗂️ `LoginHistory`: Logs user login details.

---

## **⚙️ Setup Instructions**

### **📋 Prerequisites**
- Visual Studio (2019 or later) with .NET Framework support.
- SQL Server (2017 or later).
- SQL Server Management Studio (SSMS) for database setup.

### **🚀 Steps to Run the Project**
1. Clone the repository:
   ```bash
   git clone https://github.com/saraanbih/Bank-project-CSharp-WindowsForm.git
   ```
2. Open the solution file (`BankManagementSystem.sln`) in Visual Studio.
3. Set up the database:
   - Run the SQL scripts in the `/Database` folder using SSMS:
     - `DatabaseSchema.sql` to create tables.
     - `SeedData.sql` to insert initial data.
   - Update the connection string in `App.config` to match your SQL Server configuration.
4. Build and run the project in Visual Studio.

---

## **📸 Screenshots**
Add screenshots of your application here for better visualization:
- **🔑 Login Screen**
- **🏠 Home Dashboard**
- **👥 Manage Clients Form**
- **💵 Transactions Form**
- **🌍 Currency Exchange Form**
- **🕒 Login History Form**

---

## **🔮 Future Enhancements**
- 📊 Add report generation for transactions and clients.
- 🔐 Implement role-based access control for different user types.
- 🌐 Integrate an API for real-time currency exchange rates.

---

## **📞 Contact**
For questions, feedback, or collaboration opportunities, feel free to reach out:

- 📧 **Email**: [nabihsara8@gmail.com]
- 💼 **LinkedIn**: [https://www.linkedin.com/in/sara-nabih-4168212a3/]
- ✈️ **Telegram**: [https://t.me/Sara_Nabih]

