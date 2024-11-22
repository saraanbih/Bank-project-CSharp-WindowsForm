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
- ![Screenshot 2024-11-22 080633](https://github.com/user-attachments/assets/d53f5b58-052d-4463-8dc6-ab36285b50fb)

- **🏠 Home Dashboard**
- ![Screenshot 2024-11-22 080538](https://github.com/user-attachments/assets/71e1c190-7405-43c4-9da6-972af79214f4)

- **👥 Manage Clients Form**
  ![Screenshot 2024-11-22 080726](https://github.com/user-attachments/assets/15ce97ca-47b8-41b8-aa2d-38b6ce371692)
  
  ![Screenshot 2024-11-22 080817](https://github.com/user-attachments/assets/5e1f513d-34f7-40f6-adea-374f11c4da0c)

- **💵 Transactions Form**
  ![Transactions](https://github.com/user-attachments/assets/09aa2d29-f40b-4811-9b1f-9d4330fba579)
  
  ![Withdraw](https://github.com/user-attachments/assets/e35e3c54-ff9b-499c-8435-7c07d9deaeed)
  
  ![Deposit](https://github.com/user-attachments/assets/d53d8434-9b9d-496d-9b83-658a611459eb)
  
  ![Transfer](https://github.com/user-attachments/assets/0338a4ea-3aeb-4200-8f43-1b6965117375)
  
  ![Transfer Log](https://github.com/user-attachments/assets/06dbfc52-0f0e-4d9e-8a84-62fcb626976f)

  - **👥 Manage Users Form**
    ![Manage Users](https://github.com/user-attachments/assets/efd249df-9c7d-46b5-a0dc-cf9cb5a632d8)
    
    ![AddUser](https://github.com/user-attachments/assets/75b4d6f4-dae3-4dd1-88b8-c416910a13f0)

- **🌍 Currency Exchange Form**
  ![Currency Exchange](https://github.com/user-attachments/assets/58d9a920-7b53-4947-829c-b732b7e84692)
  
  ![Exchange](https://github.com/user-attachments/assets/62780caa-b60d-454a-acbf-f2a0e9cf36df)
  
  ![Update Rate](https://github.com/user-attachments/assets/f47bfb2a-6715-4d18-b987-fab8b1e8d749)

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

