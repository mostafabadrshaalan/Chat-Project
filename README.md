# SignalR Chat Project

This repository houses a cutting-edge, real-time chat application powered by SignalR, showcasing the best practices in developing interactive web applications with ASP.NET Core. It's designed to provide a robust and scalable platform for users to engage in real-time conversations, either in group chats or private messages. This application is a testament to the power of SignalR, enabling developers and users alike to experience the full potential of real-time web communication.

## Key Features

- **Instant Messaging:** Send and receive messages in real-time across any device.
- **Multi-Room Chat:** Users can create, join, and manage multiple chat rooms.
- **Direct Messaging:** Private conversation capabilities between users.
- **Online Presence Indicator:** Shows which users are online, away, or busy.
- **Message History:** Persistent storage and retrieval of chat history.
- **Notifications:** Real-time alerts for new messages.
- **Responsive Design:** Fully responsive user interface, compatible with desktop and mobile devices.

## Built With

- **SignalR:** For real-time web functionality.
- **ASP.NET Core:** For server-side logic.
- **Entity Framework Core:** For database operations.
- **Bootstrap:** For responsive front-end design.
- **SQL Server Database:** For data storage (alternatively, local SQL Server can be used).


## Getting Started

To get a local copy up and running follow these simple steps.

### Prerequisites

- .NET Core SDK (Version 3.1 or later)
- Visual Studio 2019 (or later) with ASP.NET and web development workload installed
- SQL Server (or any compatible SQL Database)

### Installation

1. **Clone the repo**
   ```sh
   git clone https://github.com/mostafabadrshaalan/Chat-Project
   ```
2. **Navigate to the project directory**
   ```sh
   cd signalr-chat-project
   ```
3. **Restore NuGet packages**
   ```sh
   dotnet restore
   ```
4. **Update the connection string** in `appsettings.json` to your database.
5. **Apply migrations** to create the database schema.
   ```sh
   dotnet ef database update
   ```
6. **Run the application**
   ```sh
   dotnet run
   ```

## Usage

After running the application, navigate to `http://localhost:5000` (or the port specified by your development environment) to start using the chat application. You can register a new user account or log in with an existing one to begin messaging.

## Contributing

Contributions are what make the open-source community such an amazing place to learn, create, and collaborate. Any contributions you make are **highly appreciated**.

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details.

## Acknowledgements

- [SignalR Documentation](https://docs.microsoft.com/en-us/aspnet/core/signalr/introduction?view=aspnetcore-3.1)
- [Bootstrap](https://getbootstrap.com/)
- [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/)

## Contact
moustafa.shaalan@gmail.com

Project Link: [Project-Link](https://github.com/mostafabadrshaalan/Chat-Project)

