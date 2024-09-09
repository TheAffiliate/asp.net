Contract Monthly Claim System
Overview
The Contract Monthly Claim System is a web-based application designed to streamline and automate the claim submission, verification, and approval process for lecturers, Programme Coordinators, and Academic Managers. This system allows users to submit claims, upload supporting documents, and track claim statuses transparently until they are settled.

Features
User Authentication: Sign-up and log-in functionality with validation to ensure secure access.
Claim Submission: Lecturers can submit claims and attach supporting documents.
Claim Verification and Approval: Programme Coordinators and Academic Managers can verify and approve or reject claims.
Tracking Claims: Transparent tracking of the claim status throughout the process.
Cyberpunk Themed UI: A futuristic, cyberpunk-inspired user interface that enhances the user experience.
Technologies Used
ASP.NET Core MVC: Backend framework for handling requests and responses.
C#: Primary programming language.
Entity Framework Core: ORM for managing database operations.
SQL Server: Database management system.
HTML/CSS: Frontend technologies for designing the UI, including a cyberpunk theme.
Bootstrap: CSS framework for responsive design and layout.
Project Structure
Controllers: Handle incoming requests, process data using models, and return appropriate views.
HomeController: Manages all core functionalities, including handling requests for the home, login, sign-up, and claim submission pages.
Models: Define the structure of the data used in the application.
ClaimFormModel: Represents the claim submission form.
SignUpModel: Handles user registration data.
LogInModel: Manages user login data.
VerificationModel: Facilitates the verification and approval of claims.
Views: Provide the frontend UI for user interaction.
Index.cshtml: Home page.
LogIn.cshtml: User login page.
SignUp.cshtml: User registration page.
SubmitClaim.cshtml: Claim submission form.
VerifyClaim.cshtml: Claim verification and approval page.
Installation and Setup
Prerequisites
.NET Core SDK: Download and install the latest version of the .NET Core SDK from the official Microsoft website.
SQL Server: Ensure you have SQL Server installed for database management.
Steps
Clone the Repository:

bash
Copy code
git clone https://github.com/yourusername/contract-monthly-claim-system.git
cd contract-monthly-claim-system
Build the Solution: Open the solution in Visual Studio or use the terminal to run:

bash
Copy code
dotnet build
Set Up the Database: Update the connection string in the appsettings.json file with your SQL Server credentials. Run the following command to apply migrations and create the database:

bash
Copy code
dotnet ef database update
Run the Application: Start the application by running:

bash
Copy code
dotnet run
The application will be hosted locally at https://localhost:5001.

Access the Application: Open a browser and navigate to https://localhost:5001 to access the Contract Monthly Claim System.

Usage
Lecturers:

Sign up or log in to the system.
Navigate to the "Submit Claim" page to fill out the claim form and upload supporting documents.
Submit the claim for review.
Programme Coordinators/Academic Managers:

Log in to the system.
Navigate to the "Verify Claims" page to review pending claims.
Approve or reject claims and provide comments as necessary.
Assumptions and Constraints
The system assumes that only authorized users can access the verification and approval functionality.
User authentication is handled using basic login and sign-up forms, with no third-party integration at this stage.
The design prioritizes simplicity and clarity while incorporating the cyberpunk theme.
The system is intended for use within a small academic environment, and scalability considerations will be addressed in future versions.
UML Class Diagram
The UML class diagram accurately reflects the data requirements of the system. It defines relationships between users (Lecturers, Coordinators, Managers), claims, and the verification process. The diagram was used to guide the development of the database schema, ensuring all necessary entities and their relationships were captured.

Project Plan
The project plan outlines the key tasks involved in developing the system, including front-end design, back-end logic implementation, and database integration. Dependencies were managed effectively, with a timeline that ensured all components were completed within the project deadline.

Version Control
This project is version-controlled using Git. All commits include descriptive messages to clearly outline changes made in each update. The repository is hosted on GitHub for collaboration and tracking.

Future Enhancements
Role-based Access Control: Implement more granular permissions based on user roles.
Notification System: Add email notifications for claim status changes.
Improved Security: Incorporate features like password recovery and stronger password policies.
Conclusion
The Contract Monthly Claim System is designed to streamline the claim process within an academic institution. Its user-friendly interface, coupled with secure and efficient backend functionality, ensures that all users can perform their roles effectively. Future iterations of the system will focus on enhancing security and adding more advanced features based on user feedback.
