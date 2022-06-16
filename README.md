# SixMinApi

## Docker

docker-compose up -d
docker-compose downs

## User secrets

dotnet user-secrets set "UserId" "sa"
dotnet user-secrets set "Password" "pa55w0rd!"

## EF migrations

dotnet tool install --global dotnet-ef

dotnet ef migrations add inititmigration
dotnet ef database update
