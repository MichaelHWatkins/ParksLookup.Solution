# _ParksLookup_

#### By _**{Mike Watkins}**_

#### _{An api that gives and recieves information about state and national parks.}_

## Technologies Used

* _GitHub repositories_
* _C#_
* _.Net 5_
* _NuGet_
* _MySql_
* _Swagger_
* _Entity Framework Core_


## Description

_{Tells you about national and state parks.}_

## Setup/Installation Requirements

* _Install .NET Framework_
* _Navigate to https://github.com/MichaelHWatkins/ParksLookup.Solution_
* _Click on the green "Code" button and copy the repository URL or click on the copy button_
* _Open the terminal on your desktop_
* _Once in the terminal, use it to navigate to your desktop folder_
* _Once inside your desktop folder, use the command "git clone https://github.com/MichaelHWatkins/ParksLookup.Solution"_
* _After cloning the project, navigate into it using the command "cd Treats.Solution"_
* _Use the command "git remote -v" to confirm the creation of the new local repository_
* _Open the project with the code editor of your choice_
* _Navigate to Treats directory and enter command "dotnet restore"_
* _Create a file in production folder called appsettings.json_
* _Add the following to the .json file, {
"ConnectionStrings": {
"DefaultConnection": "Server=localhost;Port=3306;database=michael_watkins.sql;uid=root;pwd=[YOUR PASSWORD];"
}
}_
* To recreate the database run "dotnet ef database update" which will trigger the migrations.
* _In ParksLookup directory enter command "dotnet run"_

_Note: when using the commands listed above, do not include the quotation marks. They are used here for readability._

## Api Documentation

Explore the API endpoints in Postman or a browser.

## Endpoints

Base URL: https://localhost:5000

GET /api/park
POST /api/park
GET /api/park/{id}
PUT /api/park/{id}
DELETE /api/park/{id}

## Example Query

https://localhost:5000/api/park

## Known Bugs

* _Swagger will not run on the PUT and DELETE routes_

## Contact Information
_michaelhugheswatkins@gmail.com_

## License
_MIT License: https://opensource.org/licenses/MIT_

Copyright (c) _2021_ _Michael Watkins_