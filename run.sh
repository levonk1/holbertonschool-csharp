#!/usr/bin/env bash
mkdir $1
cd $1
dotnet new sln
mkdir $2
cd $2
dotnet new classlib
mv Class1.cs $2.cs
sed -i '4  a \\t\t\<DocumentationFile\>bin\\\$(Configuration)\\\$(TargetFramework)\\\$(AssemblyName).xml\<\/DocumentationFile\>' $2.csproj
cd ../
dotnet sln add $2/$2.csproj
mkdir $2.Tests
cd $2.Tests
dotnet new nunit
mv UnitTest1.cs $2.Tests.cs
dotnet add reference ../$2/$2.csproj
cd ../
dotnet sln add $2.Tests/$2.Tests.csproj