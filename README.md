# _Eau Claire's Salon_
Epicodus Week 10  
Version 1.0 - July 31, 2020 

## _Project Description_
A practice in many-to-one database relationships.

## _Contributors_
JohnNils Olson  

## _Usage_
A webapp for business managers to track employees and associated clients.

## _Behavior Specifications_
| Behavior | Input | Output |
| ---- | ---- | ---- |
| Program Directs to Welcome Page | Project URL | Welcome Message |
| Program Directs to List of Stylists, Retrieved from Database | Link -> "See all Stylists" | Redirect -> Stylists - Index |
| Program Directs to Add New Stylist | Link -> "Add New Stylist" | Redirect -> Stylists - Create | 
| User Inputs New Stylist Info, Stylist Added to Database | Submit | Redirect -> Stylists - Index |
| Program Directs to Stylist Details | Link -> "Sytlist Details" | Redirect -> Stylists - Details |
| Program Directs to Remove Stylist | Link -> "Remove Sytlist" | Redirect -> Stylists - Delete
| User Removes Stylist, Stylist Removed from Database | Submit | Redirect -> Stylists - Index |
| Program Directs to Stylist Edit | Link -> "Edit Sytlist Details" | Redirect -> Stylists - Edit |
| User Edits Stylist Details, Stylist Details Changes Saved to Database | Submit | Redirect -> Stylists - Details |
| Program Directs to Add New Client  | Link -> "Add New Client" | Redirect -> Clients - Create |
| User Inputs New Client Info, Client Added to Database | Submit | Redirect -> Stylists - Details |
| Program Directs to Client Details | Link -> "Client Details" | Redirect -> Clients - Details |
| Program Directs to Remove Client | Link -> "Remove Client" | Redirect -> Clients - Delete
| User Removes Client, Client Removed from Database | Submit | Redirect -> Stylists - Details |
| Program Directs to Client Edit | Link -> "Edit Client Details" | Redirect -> Client - Edit |
| User Edits Client Details, Client Details Changes Saved to Database | Submit | Redirect -> Clients - Details |

## _Technologies Used_
C#  
.NETCore  
Entity Framework Core  
MySql Server

## _Installation Instructions_
* Cloning instructions.
  1. Open Git Bash.
  2. Change the current working directory to the location where you would like to clone the repository.
  3. Type "git clone" followed by "(https://github.com/JohnNilsOlson/HairSalon.Solution)" (without quotes) and hit enter.
  4. Open directory with code editor of choice.
  5. In the terminal, change working directory to ./HairSalon.
  6. Type "dotnet restore".
  7. Type "dotnet run".

* Download instructions.
  1. Visit "(github url)".
  2. Click the green "code" button and download zip file of project.
  3. Extract zip file to directory of choice.
  4. Open project directory in code editor of choice.

* Instructions to run WebApp
  1. In the terminal, change working directory to ./HairSalon.
  2. Type "dotnet restore".
  3. Type "dotnet run".

## _Bugs_
No known issues.

## _Contact Information_
JohnNils Olson - johnnils@gmail.com  

## _License_
The [MIT] license.
Copyright (c) 2020 JohnNils Olson