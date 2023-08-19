// working with files in C#
using System.IO;

string textToWrite = "Ask them to take a poem\r\nand hold it up to the light\r\nlike a color slide\r\n   " +
    "               \r\nor press an ear against its hive.\r\n                \r\nI say drop a mouse into a poem\r\nand watch him probe his way out,\r\nor walk inside the poem's room\r\nand feel the walls for a light switch.\r\n   " +
    "               \r\nI want them to waterski\r\nacross the surface of a poem\r\nwaving at the author's name on the shore.\r\n                 \r\nBut all they want to do\r\nis tie the poem to a chair with rope\r\nand torture a confession out of it.\r\n " +
    "                \r\nThey begin beating it with a hose\r\nto find out what it really means.\r\n—Billy Collins";

File.WriteAllText("sometext.txt",textToWrite);

string readText = File.ReadAllText("sometext.txt");

Console.WriteLine(readText);