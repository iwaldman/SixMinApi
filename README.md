# SixMinApi

dotnet build
dotnet run
dotnet watch

## Docker

docker-compose up -d

docker-compose down

## User secrets

dotnet user-secrets set "UserId" "sa"

dotnet user-secrets set "Password" "pa55w0rd!"

## EF migrations

dotnet tool install --global dotnet-ef

dotnet ef migrations add initialmigration

dotnet ef migrations remove

dotnet ef database update

## Insert commands

INSERT INTO dbo.Commands
 (HowTo, Platform, CommandLine)
VALUES ('Run a .NET App','.NET', 'dotnet run');