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
 https://localhost:5000/api/Canyonlands National Park/5<br />
<hr/>
Example Response:<br />
{<br />
   "parkId": 5,<br />
        "name": "Canyonlands National Park",<br />
        "state": "Utah",<br />
        "sqMiles": 527<br />
}<br />
Query: GET  https://localhost:5000/api/(parks) <br /> 
<hr/>
Example Response: {<br />
        "parkId": 1,<br />
        "name": "Yellowstone",<br />
        "state": "Wyoming and Idaho",<br />
        "sqMiles": 3471<br />
    },<br />
    {<br />
        "parkId": 2,<br />
        "name": "Arches National Park",<br />
        "state": "Utah",<br />
        "sqMiles": 120<br />
    },<br />
    {<br />
        "parkId": 3,<br />
        "name": "Yosemite National Park",<br />
        "state": "California",<br />
        "sqMiles": 1169<br />
    },<br />
    {<br />
        "parkId": 4,<br />
        "name": "Glacier National Park",<br />
        "state": "Montana",<br />
        "sqMiles": 1583<br />
    },<br />
    {<br />
        "parkId": 5,<br />
        "name": "Canyonlands National Park",<br />
        "state": "Utah",<br />
        "sqMiles": 527<br />
    }<br />
Query: POST https://localhost:5000/api/(parks)<br />
<br /> 
<hr/>
*In the Body you will need to add the data you wish to post <br/>
Example data input: <br />
 {<br />
        "parkId": 90,<br />
        "name": "AwesomeLands National Park",<br />
        "state": "Utah",<br />
        "sqMiles": 1200<br />
    }<br />
Example Response: 201Created<br />
[<br />
    {<br />
        "parkId": 1,<br />
        "name": "Yellowstone",<br />
        "state": "Wyoming and Idaho",<br />
        "sqMiles": 3471<br />
    },<br />
    {<br />
        "parkId": 2,<br />
        "name": "Arches National Park",<br />
        "state": "Utah",<br />
        "sqMiles": 120<br />
    },<br />
    {<br />
        "parkId": 3,<br />
        "name": "Yosemite National Park",<br />
        "state": "California",<br />
        "sqMiles": 1169<br />
    {<br />
        "parkId": 4,<br />
        "name": "Glacier National Park",<br />
        "state": "Montana",<br />
        "sqMiles": 1583<br />
    },<br />
    {<br />
        "parkId": 5,<br />
        "name": "Canyonlands National Park",<br />
        "state": "Utah",<br />
        "sqMiles": 527<br />
    },<br />
    {<br />
        "parkId": 90,<br />
        "name": "AwesomeLands National Park",<br />
        "state": "Utah",<br />
        "sqMiles": 1200<br />
    }
]<br />
<hr/>
Query: PUT  https://localhost:5000/api/(parks)/{id}<br /> 
<hr/>
Example to add to the body of the post:<br />
 {<br />
        "parkId": 93,<br />
        "name": "AwesomeLands State Park",<br />
        "state": "Idaho",<br />
        "sqMiles": 1200<br />
    }<br />
Example Response:201Created<br />
{<br />
    "parkId": 93,<br />
    "name": "AwesomeLands State Park",<br />
    "state": "Idaho",<br />
    "sqMiles": 1200<br />
}<br />

Query: DELETE  https://localhost:5000/api/(parks)/{id}<br /> 
<hr/>
Example Response:200 OK<br />
[<br />
    {<br />
        "parkId": 1,<br />
        "name": "Yellowstone",<br />
        "state": "Wyoming and Idaho",<br />
        "sqMiles": 3471<br />
    },<br />
    {<br />
        "parkId": 2,<br />
        "name": "Arches National Park",<br />
        "state": "Utah",<br />
        "sqMiles": 120<br />
    },<br />
    {<br />
        "parkId": 3,<br />
        "name": "Yosemite National Park",<br />
        "state": "California",<br />
        "sqMiles": 1169<br />
    },<br />
    {<br />
        "parkId": 4,<br />
        "name": "Glacier National Park",<br />
        "state": "Montana",<br />
        "sqMiles": 1583<br />
    },<br />
    {<br />
        "parkId": 5,<br />
        "name": "Canyonlands National Park",<br />
        "state": "Utah",<br />
        "sqMiles": 527<br />
    },<br />
    {<br />
        "parkId": 90,<br />
        "name": "AwesomeLands National Park",<br />
        "state": "Utah",<br />
        "sqMiles": 1200<br />
    },<br />
    {<br />
        "parkId": 93,<br />
        "name": "AwesomeLands State Park",<br />
        "state": "Idaho",<br />
        "sqMiles": 1200<br />
    }<br />
]<br />
<br />

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