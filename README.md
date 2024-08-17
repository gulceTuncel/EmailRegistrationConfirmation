# Email Register Application

This is a simple ASP.NET Core MVC application that provides user registration, login, and email confirmation functionalities using Identity and a custom email service.

## Features

- **User Registration**: Users can sign up with an email and password.
- **Email Confirmation**: Upon registration, a confirmation email is sent to the user to verify their email address.
- **User Login**: Users can log in using their email and password after email verification.
- **Error Handling**: Basic error handling and validation during registration and login.
- **Dependency Injection**: Utilizes dependency injection to manage services like email and user management.

## Technologies Used

- **ASP.NET Core MVC**
- **Entity Framework Core**
- **ASP.NET Core Identity**
- **MailKit for Email Service**
- **Microsoft SQL Server**
- **Lazy Loading Proxies**

## Getting Started

### Prerequisites

- .NET 7 SDK or later
- Microsoft SQL Server
- SMTP server credentials (e.g., Gmail SMTP)

### Installation

1. **Clone the repository**:
    ```bash
    git clone https://github.com/your-username/EmailRegister.git
    cd EmailRegister
    ```

2. **Set up the database**:
    - Ensure your SQL Server is running and update the connection string in `appsettings.json` if necessary.

3. **Update SMTP settings**:
    - Add your SMTP credentials in the `appsettings.json` under `SmtpSettings`:
    ```json
    "SmtpSettings": {
        "Server": "smtp.yourserver.com",
        "Port": 587,
        "SenderName": "Your Name",
        "SenderEmail": "youremail@domain.com",
        "Password": "yourpassword",
        "UseSsl": true
    }
    ```

4. **Run database migrations**:
    ```bash
    dotnet ef database update
    ```

5. **Run the application**:
    ```bash
    dotnet run
    ```

6. **Navigate to** `https://localhost:5001` in your browser to use the application.

## Usage

- **Register**: Go to the `/Home/Register` page to create a new account.
- **Login**: After email confirmation, use the `/Home/Login` page to access your account.
- **Email Confirmation**: Check your inbox for the confirmation email and follow the provided link.

## Project Structure

- `Controllers/`: Contains the controllers for handling HTTP requests.
- `Models/`: Defines the view models and data models used in the application.
- `Views/`: Contains the Razor views for rendering HTML pages.
- `MailServices/`: Includes the `IMailService` interface and `MailService` class for sending emails.
- `Data/`: Holds the `AppDbContext` for database interactions.

## Contributing

Feel free to fork this repository and contribute via pull requests. Any improvements or bug fixes are welcome.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## Contact

For any questions or suggestions, feel free to contact me at [your-email@example.com](mailto:your-email@example.com).

---

Thank you for checking out this project! Happy coding!
