#!/usr/bin/env bash

# create new Project it takes the project name and rename the file with the same name

if [ $# -eq 0 ]; then
  echo "No arguments supplied"
  exit
fi

projectName=$1
dotnet new console -o "$projectName" --force
rm "$projectName"/"$projectName".cs
mv "$projectName"/Program.cs "$projectName"/"$projectName".cs
