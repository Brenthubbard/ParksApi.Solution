# _Building an API_
## Parks API
### An independent project for Epicodus

#### _A program that creates an API of state and national parks in the United States._

#### By Brent Hubbard

## Technologies Used

* _C#_
* _.NET 5.0_
* _<span>ASP.NET</span> Core Mvc 
* _Swagger_
* _MySQL_
* _Razor_
* _Entity Framework Core_
* _Git_

## Description

_This application creates a database to hold parks and their respective sizes and locations. A user can create, update, or delete parks. A user can also see a list of all parks. You can ALSO pick a random park from the data and check it out._

## Setup/Installation Requirements

* You can clone the repository to your desktop
* Navigate to the ParksApi directory
* Add a file called appsettings.json. In that file, you will need to add the following code:
<pre>
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=park;uid=root;pwd=<em>password</em>;"
  }
}
</pre>
* The 'password' is only necessary if you have a password for your MySQL
* Save
### Setting up the database
#### Using SQL
1. Open a SQL command line in a terminal. Copy and paste the contents of brent_hubbard.sql and hit enter.
2. Quit out of SQL with Ctrl + c
#### OR Using Entity Framework Core
1. In the terminal, navigate to the ParksApi directory
2. Enter "dotnet ef database update"
### Running the program
* From the ParksApi directory, enter "dotnet restore"
* Next, enter "dotnet build"
* Enter "dotnet run" in the terminal and hit enter to start a local host. 
* Ctrl + click the link that populates in the terminal to view the application in the webpage. It is probably http://localhost:5000/
* Use Ctrl + C in the terminal to quit the host and close out of the window in the browser.

*_EndPoints_
The following URl's will take you to the desired endpoints.
First use the base Url = https://localhost:5000
then for 
Example Query:<br/>>
 https://localhost:5000/api/Canyonlands National Park/5

Example Response:
{
   "parkId": 5,
        "name": "Canyonlands National Park",
        "state": "Utah",
        "sqMiles": 527
}
Query: GET  https://localhost:5000/api/(parks) <br /> 
Example Response: {
        "parkId": 1,
        "name": "Yellowstone",
        "state": "Wyoming and Idaho",
        "sqMiles": 3471
    },
    {
        "parkId": 2,
        "name": "Arches National Park",
        "state": "Utah",
        "sqMiles": 120
    },
    {
        "parkId": 3,
        "name": "Yosemite National Park",
        "state": "California",
        "sqMiles": 1169
    },
    {
        "parkId": 4,
        "name": "Glacier National Park",
        "state": "Montana",
        "sqMiles": 1583
    },
    {
        "parkId": 5,
        "name": "Canyonlands National Park",
        "state": "Utah",
        "sqMiles": 527
    }
Query: POST https://localhost:5000/api/(parks)
<br /> 
*In the Body you will need to add the data you wish to post <br/>
Example data input: 
 {
        "parkId": 90,
        "name": "AwesomeLands National Park",
        "state": "Utah",
        "sqMiles": 1200
    }
Example Response: 201Created
[
    {
        "parkId": 1,
        "name": "Yellowstone",
        "state": "Wyoming and Idaho",
        "sqMiles": 3471
    },
    {
        "parkId": 2,
        "name": "Arches National Park",
        "state": "Utah",
        "sqMiles": 120
    },
    {
        "parkId": 3,
        "name": "Yosemite National Park",
        "state": "California",
        "sqMiles": 1169
    },
    {
        "parkId": 4,
        "name": "Glacier National Park",
        "state": "Montana",
        "sqMiles": 1583
    },
    {
        "parkId": 5,
        "name": "Canyonlands National Park",
        "state": "Utah",
        "sqMiles": 527
    },
    {
        "parkId": 90,
        "name": "AwesomeLands National Park",
        "state": "Utah",
        "sqMiles": 1200
    }
]
Query: PUT  https://localhost:5000/api/(parks)/{id}<br /> 
Example to add to the body of the post:
 {
        "parkId": 93,
        "name": "AwesomeLands State Park",
        "state": "Idaho",
        "sqMiles": 1200
    }
Example Response:201Created
{
    "parkId": 93,
    "name": "AwesomeLands State Park",
    "state": "Idaho",
    "sqMiles": 1200
}

Query: DELETE  https://localhost:5000/api/(parks)/{id}<br /> 
Example Response:200 OK
[
    {
        "parkId": 1,
        "name": "Yellowstone",
        "state": "Wyoming and Idaho",
        "sqMiles": 3471
    },
    {
        "parkId": 2,
        "name": "Arches National Park",
        "state": "Utah",
        "sqMiles": 120
    },
    {
        "parkId": 3,
        "name": "Yosemite National Park",
        "state": "California",
        "sqMiles": 1169
    },
    {
        "parkId": 4,
        "name": "Glacier National Park",
        "state": "Montana",
        "sqMiles": 1583
    },
    {
        "parkId": 5,
        "name": "Canyonlands National Park",
        "state": "Utah",
        "sqMiles": 527
    },
    {
        "parkId": 90,
        "name": "AwesomeLands National Park",
        "state": "Utah",
        "sqMiles": 1200
    },
    {
        "parkId": 93,
        "name": "AwesomeLands State Park",
        "state": "Idaho",
        "sqMiles": 1200
    }
]


### Checking the API documentation using Swagger
* Whatever URL your local host is using, just add "/swagger" to the end of it!
* You can also USE the API from here. Just click one of GET, POST, PUT, or DELETE buttons, and then click Try it out. 

## Known Bugs
 _Swagger is WIP_ 


## License

[MIT](https://opensource.org/licenses/MIT)

Copyright © 2021 Brent Hubbard

All Rights Reserved

## Contact Information
_hubbardbrent@hotmail.com_