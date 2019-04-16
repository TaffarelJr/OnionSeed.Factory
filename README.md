# OnionSeed.Factory

Contains common factory interface definitions, intended to reduce boilerplate when implementing the [Abstract Factory](https://en.wikipedia.org/wiki/Abstract_factory_pattern) pattern.

|                  | AppVeyor |
|------------------|----------|
| Project          | [![Build status](https://ci.appveyor.com/api/projects/status/b1oiobbyovmqotwh?svg=true)](https://ci.appveyor.com/project/TaffarelJr/onionseed-factory-igve9) |
| Branch: `master` | [![Build status](https://ci.appveyor.com/api/projects/status/b1oiobbyovmqotwh/branch/master?svg=true)](https://ci.appveyor.com/project/TaffarelJr/onionseed-factory-igve9/branch/master) |

## Build

This solution consists of a [.NET Standard](https://docs.microsoft.com/en-us/dotnet/standard/net-standardP) class library and an [xUnit](https://xunit.net/) test project. It can be built with any version of [Visual Studio](https://visualstudio.microsoft.com/vs/) (2017+) or [Visual Studio Code](https://code.visualstudio.com/).

The official build/[CI](https://en.wikipedia.org/wiki/Continuous_integration) process is borrowed from another Git repository - [OnionSeed.Build](https://github.com/TaffarelJr/OnionSeed.Build) - and imported here as a Git [submodule](https://git-scm.com/book/en/v2/Git-Tools-Submodules). This shared code encapsulates the entire process using [Cake](https://cakebuild.net/) tasks - running them locally produces the same result as running them on a build server (currently [AppVeyor](https://www.appveyor.com/)).

Windows command prompt:
```
powershell .\build.ps1
```

[Powershell](https://docs.microsoft.com/en-us/powershell/scripting/overview?view=powershell-6):
```
.\build.ps1
```

Mac\Linux:
```
./build.sh
```
