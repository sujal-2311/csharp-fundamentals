﻿using _02_NamesBeforeRefactorToSRP.DataAccess;

var names = new Names();
var path = new NamesFilePathBuilder().BuildFilePath();
var stringTextualRepository = new StringsTexutalRepository();
if (File.Exists(path))
{
    Console.WriteLine("Names file already exists. Loading names.");
    var stringsFromFile = stringTextualRepository.Read(path);
    names.AddNames(stringsFromFile);
}
else
{
    Console.WriteLine("Names file does not yet exist.");

    //let's imagine they are given by the user
    names.AddName("John");
    names.AddName("not a valid name");
    names.AddName("Claire");
    names.AddName("123 definitely not a valid name");

    Console.WriteLine("Saving names to the file.");
    stringTextualRepository.Write(path, names.All);
}
Console.WriteLine(new NamesFormatter().Format(names.All));

Console.ReadLine();

