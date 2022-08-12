# _Dr. Sillystringz's Factory_

#### By _**Rosario Ruvalcaba**_

#### _A C# web application to manage Machines and Engineers for 'Dr. Sillystringz's Factory' using an SQL database and many-to-many relationships._

## Technologies Used

* _C#_
* _.Net 5.0_
* _ASP .Net Core MVC_
* _Razor View Engine_
* _MySQL Workbench_
* _Entity Core Framework_
* _Markdown, CSS, Bootstrap, HTML_

## Description

_This project consists of an C# MVC web application that allows 'Mr.Sillystring' to manage information on his factory's Engineers and Machines. It allows the management of the fictional 'Factory' to add Engineers and Machines to an SQL Database with the use of Entity Core Framework. The manager can also view details for each Engineer/Machine and delete relationships and objects. The project was created as a code review for Epicodus following the Many-To-Many-Relationships section of C#._


## Setup/Installation Requirements

* _Clone repository from Github and save a copy on own computer. Then on your local copy, navigate to the top level of the directory._

* _If saving repository remotely, make an initial commit pushing ONLY your .gitignore file so sensitive information is not pushed._

* _Ensure you have C# and .NET installed by running the command [dotnet --version] in your terminal. If the response is not a version number, install .NET from Microsoft website._

* _Install MySQL Community Server MySQL Workbench per instruction provided below by Epicodus:_
  * _[https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql]_

* _Open MySQL Workbench and import the database provided with this project (rosario_ruvalcaba_factory)._
  



* _Create file called appsettings.json in the main project directory (HairSalon)_
  * _Open file and add the following: { "ConnectionStrings": { "DefaultConnection": "Server=localhost;Port=3306;database=[DATABASE NAME HERE];uid=[USER ID HERE];pwd=[PASSWORD HERE];" } }_
  * _Substitute your own information for DATABASE NAME HERE, USER ID HERE, and PASSWORD HERE._

* _Navigate to the Factory directory in the project and run the command [dotnet restore, then dotnet build]._

* _While still in the Factory directory, run the command [dotnet run] to run the application using a localhost server._

## Known Bugs

* _At the moment: user can enter 'blank' or repeat Engineers/Machines as well as the wrong data type, such as letters for a numbers._

## License

MIT License

Copyright (c) _August_2022_ _Rosario Ruvalcaba Harwood_