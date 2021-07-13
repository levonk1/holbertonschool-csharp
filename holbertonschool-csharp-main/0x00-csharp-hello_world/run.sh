#!/usr/bin/env bash

# build and run the projectName passed

if [ $# -eq 0 ]; then
  echo "No arguments supplied"
  exit
fi

projectName=$1
dotnet build "$projectName"
dotnet run --project "$projectName"
