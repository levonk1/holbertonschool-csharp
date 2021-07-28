#!/usr/bin/env bash                                                        
dotnet new console -n $1                                                   
cd $1                                                                      
mv Program.cs $1.cs
sed -i '6  a \\t\t\<DocumentationFile\>bin\\\$(Configuration)\\\$(TargetFramework)\\\$(AssemblyName).xml\<\/DocumentationFile\>' $1.csproj                                                       
