echo %GITHUB_USERNAME%
echo %GITHUB_APIKEY%
echo %GITHUB_INDEX%

dotnet build --configuration Release
pause
dotnet nuget push JpgMetadataEditor/bin/Release/GradientSoftware.Metadata.0.1.0.nupkg --api-key %GITHUB_APIKEY% --source "github" 