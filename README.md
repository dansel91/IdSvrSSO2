## Synopsis

Target of this project was to implement a Single-Sign-On and Single-Sign-Out with IdentityServer3. Therefor 3 c# projects were realised. One playing the part of the IdentityServer and authenticating users and 2 standart template MVC clients which call the identityServer for authentication.

## Code Example

Not much to say here. If the project us run, all 3 clients start running. If one clicks SignIn in the navigation of HybridClient01 or HybridClient02, he is forwarded to the IdentityServer (https) for login (user: Bob, password: secret) purpose. If login is ok, the user is also logged in in second client. Probably a refresh is needed in the second webpage. Same goes for logout.

## Motivation

The project was done as a school project in IT.

## Installation

Download the solution as zip and unzip it somewhere or checkout the project. You will need Visual Studio to run it. Open the solution. In it you find 3 MVC projects. One called IdentityServer which is as it says the identityServer. The others are HybridClients 01 and 02. 
Keep in mind that the IdentityServer runs on SSL. So your localhost certificate must be ok. If not, delete the installed certificate and generate a new one.
