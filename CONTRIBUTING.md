# Contributing

## Installing

- `brew install mono-libgdiplus`

## Updating

- increment version in `bunny-sdk.csproj`
- `dotnet clean bunny-sdk.csproj`
- `dotnet build bunny-sdk.csproj`
- `dotnet pack bunny-sdk.csproj`
- `git add -A`
- `git commit -m "message"`
- `git push`
- `dotnet nuget push bin/Release/BunnyLauncher.BunnySdk.0.0.0.nupkg --source https://api.nuget.org/v3/index.json --api-key API_KEY`
