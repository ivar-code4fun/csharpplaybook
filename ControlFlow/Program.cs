// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using ControlFlow;
using System.Reflection;

//# region For and ForEach loops
//var languages = new List<string>{ "c#", "f#", "vb", "java", "python", "c++" };

//Sequences.DisplaySequence_ForEach(languages);
//Console.WriteLine("***************");
//Sequences.DisplayFirstN_ForEach(languages, 3);
//Console.WriteLine("***************");
//Sequences.DisplayListWithIndex_For(languages);

//Sequences.DisplaySequence_For(languages);
//Console.WriteLine("***************");
//Sequences.DisplayFirstN_For(languages, 3);
//Console.WriteLine("***************");
//Sequences.DisplayListWithIndex_For(languages);
////#endregion

#region While loop
string filePath = Assembly.GetExecutingAssembly()!.Location;

Console.WriteLine("Entry assembly is " + Path.GetFileName(filePath));
Console.WriteLine("Folder are :");
//FolderProcessor.DisplayParentNames_While(filePath);
var folderNames = FolderProcessor.EnumerateParentNames_While(filePath);
foreach (var folderName in folderNames.Reverse())
{
    Console.WriteLine(folderName);
}
#endregion


return;



