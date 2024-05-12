# Description: Makefile for maintaining project
# Variables
PROJECT = src/pegatestscli/pegatestscli.csproj

reset: clean install build

# Install dependencies
install:
	dotnet restore $(PROJECT)

# Build target
build:
	dotnet build $(PROJECT)

# Publish target
publish:
	dotnet publish $(PROJECT) -c Release -o bin

# Deploy to Nuget
deploy:
	dotnet nuget push bin/*.nupkg --source https://api.nuget.org/v3/index.json --api-key $(NUGET_API_KEY)

# Clean target
clean:
	rm -rf bin

# Default target
.DEFAULT_GOAL := reset