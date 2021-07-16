# VehicleActivityTracker

This is a project is a microservice with a CRUD.

# Project setup
## Install Dotnet Core
1. Go to the Dotnet Core page [Dotnet Core](https://dotnet.microsoft.com/download/dotnet)
2. Download the version NET 5.0 according of your OS.

## Clone the repository
1. Go to the path where the project is going to be at.
2. Open a terminal/Console and run the following command:
>git clone https://github.com/Aryevang/VehicleActivityTracker.git

## Run the project stand alone
1. Go to the VAT.api folder.
2. Run the following command:
>dotnet run

## Run the test
1. Go to the folder VAT.UnitTest located in outside of the src folder.
2. Run the command:
>dotnet test

## Create a Docker image of the app
1. Go to the folder VAT.api
2. In a terminal, run the command:
>docker build -t [IMAGE_NAME]:v1 . 

NOTE 1: The project have a docker-compose.yaml file that can be use to extend the deployment.

NOTE 2: This project needs a SQL Server instance running. The app will automatically create the Database and will seed it with some data.

NOTE 3: Make sure to change the connectionstring info in the *Startup.cs* file located in the VAT.api folder.