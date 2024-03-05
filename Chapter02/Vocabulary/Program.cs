﻿//See https://aka.ms/new-console-template for more information
//#error version
//WriteLine($"Computer named {Env.MachineName} says \"No.\"");

//Outputs the current line terminator.
//By default, this is a carriage-return and line feed.
//Console.WriteLine();
//Outputs the greeting and the current line terminator 
//Console.WriteLine("Hello, Stephen");
//Outputs a formatted number and date and the current line terminator.
//Console.WriteLine("Temperature on {0:D} is {1}°", DateTime.Today, 23.4);
using System.Reflection; // To use Assembly, TypeName, and so on.

// Get the assembly that is the entry point for this app
Assembly? myApp = Assembly.GetEntryAssembly();

// If the previous line returned nothing then end the app.
if (myApp is null) return;
// Loop through the assemblies that my app references.
foreach (AssemblyName name in myApp.GetReferencedAssemblies())
{
    // Load the assembly so we can read its details.
    Assembly a = Assembly.Load(name);
    // Declare a variable to count the number of methods.
    int methodCount = 0;
    // Loop through all the types in the assembly.
    foreach (TypeInfo t in a.DefinedTypes)
    {
        // Add up the counts of all the methods 
        methodCount += t.GetMethods().Length;
    }
    // Output the count of types and their methods 
    WriteLine("{0:N0} types with {1:N0} methods in {2} assembly.",
        arg0: a.DefinedTypes.Count(),
        arg1: methodCount,
        arg2: name.Name);
}