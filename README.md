# MiniProjectE

Program Documentation
Overview:
This program is designed to manage user profiles, authentication, menu filtering, and order check-in functionalities. It consists of four forms:

Form1: Create User Profile

Allows users to create a new profile by providing necessary details like username, email, password, date of birth, and phone number.
Implements validation for each field to ensure data integrity.
Stores user information securely in a SQL Server database.
Form2: Login

Provides a login interface for existing users to access the system.
Validates user credentials against the database.
Upon successful authentication, grants access to the filtering form.
Filter Form: Menu Filtering

Enables users to filter menu items based on various criteria such as course type, dietary preferences, allergies, and portion size.
Retrieves menu data from the database and displays it in a DataGridView.
Allows users to clear filters and reset the view.
Provides a button to proceed to the check-in form for ordering selected items.
Check-in Form: Order Management

Facilitates users to check-in and place orders.
Validates user input for ordering information such as order amount, client name, phone number, bill amount, and order date.
Inserts validated orders into the database upon successful submission.
Technologies Used:
C# (Windows Forms)
Microsoft SQL Server (Database)
Form1 (Create User Profile):
Validations:
Username: Ensures the username is at least 5 characters long.
Email: Validates the email format using a regular expression.
Password: Checks for length (>8 characters), presence of uppercase letters, lowercase letters, and digits.
Date of Birth: Verifies the user's age is above 18 years.
Phone Number: Validates Bulgarian phone numbers.
Database Interaction:
Inserts new user profiles into the "userInfo" database.
Form2 (Login):
Validation:
Username: Checks if the username is at least 5 characters long.
Password: Ensures the password meets complexity requirements.
Authentication:
Validates user credentials against stored data in the "userInfo" database.
Grants access to the filtering form upon successful authentication.
Filter Form (Menu Filtering):
Filtering Options:
Course Type, Dietary Preferences, Allergies, Portion Size.
Allows users to filter menu items based on selected criteria.
Database Interaction:
Retrieves menu data from the "MiniProjectE" database.
Allows user to update their information if they have inputted something incorrectly using their unique phone number
Allows user to delete incorrect orders by using their unique phone number
Check-in:
Provides a button to proceed to the check-in form for ordering selected items.
Check-in Form (Order Management):
Validation:
Order Amount: Ensures a valid numeric input.
Client Name: Checks for a minimum length of 5 characters.
Bill Amount: Validates as a numeric value.
Order Date: Verifies a valid date format.
Phone Number: Validates Bulgarian phone numbers.
Database Interaction:
Inserts validated orders into the "MiniProjectE" database.
Conclusion:
This program offers a comprehensive solution for user management, authentication, menu filtering, and order management. By leveraging Windows Forms and SQL Server, it provides a user-friendly interface and ensures data integrity and security throughout the process.
