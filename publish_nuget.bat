echo %GITHUB_USERNAME%
echo %GITHUB_APIKEY%
echo %GITHUB_INDEX%


dotnet nuget push Metadata/bin/Release/GradientSoftware.Metadata.0.1.0.nupkg --api-key %GITHUB_APIKEY% --source "github" 