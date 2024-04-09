# Charity Website

## Overview
Welcome to our Charity System web application! This system is designed to facilitate the management of charity cases. Admins can input various cases for inspection, and inspectors can review each case and provide a report on whether it merits assistance or not.

## Technologies Used
- .NET Framework

## Setup Instructions
To set up and run the Charity System web application on your local machine, please follow these steps:

1. Clone the repository to your local machine:

   ```
   git clone git@github.com:mohamedhassan218/SDProject.git
   ```

2. Open the project in your preferred IDE or text editor.

3. Make sure you have the necessary dependencies installed. You might need to install:
   - .NET Framework SDK
   - Entity Framework

4. Put your connection string in the appsettings.json file.

5. Build the project:

   ```
   dotnet build
   ```

6. Run the project:

   ```
   dotnet run
   ```

6. Once the project is running, you can access it through your web browser at `http://localhost:7122`

## Usage
- **Admin Features:**
  - Log in as an admin user.
  - Insert cases for inspection.
  - Manage inspectors and their assignments.
  - Register new admins.

- **Inspector Features:**
  - Log in as an inspector user.
  - Review cases assigned to them.
  - Provide reports on each case indicating whether it merits assistance or not.
See a demo to the project: [link](https://github.com/mohamedhassan218/charity-website/blob/main/SDProject/Demo.gif)

## Contributing
We welcome contributions from the community. If you find any bugs or have suggestions for improvements, please feel free to open an issue or submit a pull request.

## License
This project is licensed under the [MIT License](LICENSE).