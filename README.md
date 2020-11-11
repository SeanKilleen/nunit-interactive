# try-nunit

A proof of concept to see if we can get NUnit working with Try .NET

## Pre-requisites

* .NET Core 3.1
* the .NET Try tool: `dotnet tool install -g Microsoft.dotnet-try`

## To Run

* Open a command prompt in the project root directory
* `dotnet restore`
* `dotnet build`
* Run `dotnet try verify` to ensure things are in working order
* Run `dotnet try` to spin up the site. Open the URL it provides
* Go to `/NUnit.md` which is the proof of concept.
