# Oregon Parks mock website

#### Contributors: Anthony DiFalco

#### A site featuring some State, National, and City parks in Oregon

## Technologies Used

* C#
* .NET
* ASP.NET Core
* MySQL / Entity & Identity
* HTML / CSS

## Description

This project simulates a website that features 5 parks around Oregon. Each of these parks are accessed from the ParksDirectory API. The site includes a home page, an index for all parks in the API, and details pages for each park. 

Users can register accounts and sign in, which allows them to add/edit parks through the API. A user account requires a username and a password, which for simplicity's sake can be any single aplhanumeric character.

## Setup/Installation Requirements

Installation from GitHub:

* To run this program you will need to install VSCode, along with C# and .NET
* From your terminal run&emsp;`git clone https://github.com/Di-Falco/code-review-12-MVC`
* From the root directory run&emsp;`dotnet restore` and `dotnet build`

SQL setup:

* In the Root directory, create an appsetting.json file. The terminal command for this is&emsp;`touch appsettings.json`
* Within appsettings.json, insert the following:

`"ConnectionStrings": {`

&emsp;`  "DefaultConnection": "Server=localhost;Port=3306;database=anthony_difalco;uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"`
`}`

* Replace&ensp;`[YOUR-USERNAME-HERE]`&ensp;and&ensp;`[YOUR-PASSWORD-HERE]`&ensp;with your username and password for MySqlWorkbench

To Run the Program:
* Navigate to the root directory from your terminal
* Enter the command `dotnet run`
* The program should launch on&ensp;`localhost:5000`

To set up and access the API, see `https://github.com/Di-Falco/code-review-12`

## Known Bugs

* Currently able to add/edit parks with any registered account. Ideally these actions would be limited to admin-authorized users.

## License

## Contact Information