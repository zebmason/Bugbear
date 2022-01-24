dotnet clean
dotnet restore
dotnet build -c Release
dotnet pack .\Bugbear.Gremlin.Net -c Release -o .\nugets
dotnet pack .\Bugbear.Core -c Release -o .\nugets
dotnet pack .\Bugbear.Graph -c Release -o .\nugets
dotnet pack .\Bugbear.IO -c Release -o .\nugets
dotnet pack .\Bugbear.Practical -c Release -o .\nugets
dotnet pack .\Bugbear.TinkerPop -c Release -o .\nugets
