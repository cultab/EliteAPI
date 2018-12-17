<img src="https://i.imgur.com/keDXwjY.png" align="right"
     title="EliteAPI by Somfic" width="280" height="280">

# EliteAPI
A powerful event based API for [Elite: Dangerous](https://www.elitedangerous.com/) that hooks into the [Player Journal](http://edcodex.info/?m=doc). Created by CMDR [Somfic](https://github.com/Somfic).

[![Codacy Badge](https://api.codacy.com/project/badge/Grade/480f394b3d044412afb33351120253f9)](https://app.codacy.com/app/EliteAPI/EliteAPI?utm_source=github.com&utm_medium=referral&utm_content=Somfic/EliteAPI&utm_campaign=Badge_Grade_Dashboard) [![Discord](https://img.shields.io/discord/498422961297031168.svg)](https://discord.gg/jwpFUPZ)

[![GitHub issues](https://img.shields.io/github/issues/EliteAPI/EliteAPI.svg)](https://github.com/EliteAPI/EliteAPI/issues) [![GitHub forks](https://img.shields.io/github/forks/EliteAPI/EliteAPI.svg)](https://github.com/EliteAPI/EliteAPI/network) [![GitHub stars](https://img.shields.io/github/stars/EliteAPI/EliteAPI.svg)](https://github.com/EliteAPI/EliteAPI/stargazers) [![GitHub license](https://img.shields.io/github/license/EliteAPI/EliteAPI.svg)](https://github.com/EliteAPI/EliteAPI/blob/master/LICENSE)

[![Nuget](https://img.shields.io/nuget/v/EliteAPI.svg)](https://www.nuget.org/packages/EliteAPI/) [![GitHub tag](https://img.shields.io/github/tag/EliteAPI/EliteAPI.svg)](https://github.com/EliteAPI/EliteAPI/releases) [![GitHub last commit](https://img.shields.io/github/last-commit/EliteAPI/EliteAPI.svg)](https://github.com/EliteAPI/EliteAPI/commits/master) [![GitHub Release Date](https://img.shields.io/github/release-date/EliteAPI/EliteAPI.svg)](https://github.com/EliteAPI/EliteAPI/releases) [![NuGet](https://img.shields.io/nuget/dt/EliteAPI.svg)](https://www.nuget.org/packages/EliteAPI/)

# Usage
Let's get this party rolling.

## Installation
First we will have to install EliteAPI. We can do this a number of ways.

##### Nuget
Use the nuget package manager console.

```Install-Package EliteAPI```

After that it will be ready to go.

##### Nuget package manager
It is also available in the nuget package manager via Visual Studio. Simply search for ***EliteAPI***. After that it will be ready to go.

##### Github
You can find the latest release [here](https://github.com/EliteAPI/EliteAPI/releases). Download the .dll file and reference it to your Visual Studio project.

## Code example
First, add the namespace to your class.
```csharp
using EliteAPI;
```
Then create a new `EliteDangerousAPI` object.
```csharp
EliteDangerousAPI EliteAPI = new EliteDangerousAPI();
```
Since `EliteDangerousAPI` needs a reference to the directory that contains the PlayerJournals, we have to pass it a `DirectoryInfo` object.
```csharp
DirectoryInfo playerJournalFolder = new DirectoryInfo(
$@"C:\Users\{Environment.UserName}\Saved Games\Frontier Developments\Elite Dangerous");

EliteDangerousAPI EliteAPI = new EliteDangerousAPI( playerJournalFolder );
```
Now that we are hooked to the API, we can setup the events that we want to get information about. Let's say we want to know when the player docks at a station. Simply hook into its event and create a method for it. After that start the API.
```csharp
DirectoryInfo playerJournalFolder = new DirectoryInfo(
$@"C:\Users\{Environment.UserName}\Saved Games\Frontier Developments\Elite Dangerous");

EliteDangerousAPI EliteAPI = new EliteDangerousAPI( playerJournalFolder );

EliteAPI.DockedEvent += EliteAPI_DockedEvent;

EliteAPI.Start();
```
```csharp
private static void EliteAPI_DockedEvent(object sender, DockedInfo e)
{
     //This method will be ran every time the player docks.
}
```
Now if you want to display the station's name for example, you can use the `DockedInfo` object.
```csharp
private static void EliteAPI_DockedEvent(object sender, DockedInfo e)
{
     //This method will be ran every time the player docks.
     Console.WriteLine($"Docked at {e.StationName}.");
}
```