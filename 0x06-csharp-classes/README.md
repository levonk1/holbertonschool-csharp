# 0x06. C# - Classes and Namespaces

![N|Solid](https://upload.wikimedia.org/wikipedia/commons/thumb/4/4f/Csharp_Logo.png/245px-Csharp_Logo.png)

This is a project from Holberton School..

## Namespace:

Namespaces are used to provide a "named space" in which your application resides. They're used especially to provide the C# compiler a context for all the named information in your program, such as variable names. Without namespaces, for example, you wouldn't be able to make a class named Console, as .NET already uses one in its System namespace. The purpose of namespaces is to solve this problem, and release thousands of names defined in the .NET Framework for your applications to use, along with making it so your application doesn't occupy names for other applications, if your application is intended to be used in conjunction with another. So namespaces exist to resolve ambiguities a compiler wouldn't otherwise be able to do.

## Classes:

A class is like a blueprint of a specific object. In the real world, every object has some color, shape, and functionalities - for example, the luxury car Ferrari. Ferrari is an object of the luxury car type. The luxury car is a class that indicates some characteristics like speed, color, shape, interior, etc. So any company that makes a car that meets those requirements is an object of the luxury car type. For example, every single car of BMW, Lamborghini, Cadillac are an object of the class called 'Luxury Car'. Here, 'Luxury Car' is a class, and every single physical car is an object of the luxury car class.

Likewise, in object-oriented programming, a class defines some properties, fields, events, methods, etc. A class defines the kinds of data and the functionality their objects will have.

A class enables you to create your custom types by grouping variables of other types, methods, and events.

In C#, a class can be defined by using the class keyword.


## Tasks

``Mandatory`` 

| Task | Description |
| ------ | ------ |
| 0. Braaainsss | Create a new namespace Enemies. Create an empty public class Zombie within Enemies that defines a zombie. |
| 1. Healthy competition | Based on 0-enemy, write a public class Zombie that defines a zombie by: -public field health. -health should be an int and have no value. -public constructor: public Zombie(). -sets the value of health to 0 |
| 2. Health validation | Based on 1-enemy, write a public class Zombie that defines a zombie by: -public field health. -health should be an int and have no value. -public constructor: public Zombie().sets the value of health to 0.-a new public constructor: public Zombie(int value): value must be greater than or equal to 0. if value is less than 0, throw an ArgumentException with the message Health must be greater than or equal to 0 |
| 3. Zombie health | Based on 2-enemy, write a public class Zombie that defines a zombie by: -private field health. -health should be an int and have no value. -public constructor: public Zombie(): sets the value of health to 0. -public constructor: public Zombie(int value): value must be greater than or equal to 0. -public method public int GetHealth() that returns the value of health of the Zombie object |
| 4. Hello, my name is | Based on 3-enemy, write a public class Zombie that defines a zombie by: -private field health. -health should be an int and have no value. -public constructor: public Zombie(): sets the value of health to 0. -public constructor: public Zombie(int value): value must be greater than or equal to 0. -private field name. -name should be a string and have a default value of (No name). -public property Name: get: retrieve name. set: set name. -public method public int GetHealth() that returns the value of health of the Zombie object |
| 5. Printing a zombie | Based on 4-enemy, write a public class Zombie that defines a zombie by: -private field health. -health should be an int and have no value. -public constructor: public Zombie(): sets the value of health to 0. -public constructor: public Zombie(int value): value must be greater than or equal to 0. -private field name. -name should be a string and have a default value of (No name). -public property Name: get: retrieve name. set: set name. -public method public int GetHealth() that returns the value of health of the Zombie object. -public .toString() override that prints the Zombie object’s attributes to stdout: Format: Zombie name: <name> / Total Health: <health> (see example below) |
