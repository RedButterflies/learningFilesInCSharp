// working with files in C#
using System;
using System.Globalization;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string path = "sometextx.txt";
        if(!File.Exists(path))
        {
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine("I ask them to take a poem\r\nand hold it up to the light\r\nlike a color slide\r\n                  \r\nor press an ear against its hive.\r\n                \r\nI say drop a mouse into a poem\r\nand watch him probe his way out,\r\nor walk inside the poem's room\r\nand feel the walls for a light switch.\r\n                  \r\nI want them to waterski\r\nacross the surface of a poem\r\nwaving at the author's name on the shore.\r\n                 \r\nBut all they want to do\r\nis tie the poem to a chair with rope\r\nand torture a confession out of it.\r\n                 \r\nThey begin beating it with a hose\r\nto find out what it really means.\r\n—Billy Collins");
                sw.Flush();
                Console.WriteLine("Enter a line you'd like to append to the end of the text: ");
                string str = Console.ReadLine();
                sw.WriteLine(str);
                sw.Flush ();
                sw.Close();
            }
            
        }
        else
        {
            using (StreamWriter fs = File.AppendText(path))
            {
                fs.WriteLine("I ask them to take a poem\r\nand hold it up to the light\r\nlike a color slide\r\n                  \r\nor press an ear against its hive.\r\n                \r\nI say drop a mouse into a poem\r\nand watch him probe his way out,\r\nor walk inside the poem's room\r\nand feel the walls for a light switch.\r\n                  \r\nI want them to waterski\r\nacross the surface of a poem\r\nwaving at the author's name on the shore.\r\n                 \r\nBut all they want to do\r\nis tie the poem to a chair with rope\r\nand torture a confession out of it.\r\n                 \r\nThey begin beating it with a hose\r\nto find out what it really means.\r\n—Billy Collins");
                fs.Flush();
                Console.WriteLine("Enter a line you'd like to append to the end of the text: ");
                string str = Console.ReadLine();
                fs.WriteLine(str);
                fs.Flush();
                fs.Close();
            }
        }
        if (File.Exists(path))
        {
            string text = File.ReadAllText(path);
            Console.WriteLine(text);
        }
     
        if (!File.Exists("hi.txt"))
        {
            using (StreamWriter sw = File.CreateText("hi.txt"))
            {
                sw.WriteLine("Hi");
                sw.Close();
            }

        }
        else
        {
            using (StreamWriter sw = File.AppendText("hi.txt"))
            {
                sw.WriteLine("Hi");
                sw.Close();
            }
            string text1 = File.ReadAllText("hi.txt");
            Console.WriteLine(text1);
        }
        File.Replace(path, "hi.txt", "sometextbackup.txt");

        if (File.Exists("sometextbaxkup.txt")){
            string text3 = File.ReadAllText("sometextbackup.txt");
            Console.WriteLine(text3);
        }

        

    }
}
