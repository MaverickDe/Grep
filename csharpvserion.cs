
using System;
using System.IO;

enum Command
{
    COPY,
    REPLACE,
    FIND,
    MOVE,
    READ
}




class Grep
{
    
    

    // this is a csharp cammand  tool in csharp to read a file 
    //output it
    // or find
    // find and replace
    //copy





    Run(string[] args)
    {
if(args.Length == 0)
        {
            Console.WriteLine("Empty Command");
        }

string command = args[0];



        switch (command.ToUpper())
        {
              case "COPY":
            {
                if (args.Length < 3)
                {
                    Console.WriteLine("Source and destination required");
                    return;
                }

                string source = args[1];
                string destination = args[2];

                Copy(source, destination);
                break;
            }
            case "READ":
            {

                    if (args.Length < 2)
                {
                    Console.WriteLine("Source required");
                    return;
                }

                string source = args[1];
                Read(source);
                break;
            }
            case "FIND":
            {
                break;
            }
            case "REPLACE":
            {
                break;

            }
            case "MOVE":    
            {
                    if (args.Length < 3)
                {
                    Console.WriteLine("Source and destination required");
                    return;
                }

                string source = args[1];
                string destination = args[2];
                Move(source, destination);
                break;
            }
        }
        
// string[] lines = File.ReadAllLines("test.txt");

// foreach (string line in lines)
// {
//     Console.WriteLine(line);
// }



    }

WRITE (string source , string content)
    {
        
         File.WriteAllText(source, content);
    }
    Copy (string source , string destination)
    {
        
         File.Copy(source, destination);


    }
    Read (string source )
    {
        
         File.ReadAllText(source);


    }
    Move (string source , string destination)
    {
        
         File.Move(source, destination);


    }


    REPLACE (string source , string filter,string replacement)
    {
        
      string []lines  = File.ReadAllLines(source);
        for (int i = 0; i < lines.Length; i++)
        {
            if (lines[i].Contains(filter))
            {
                lines[i] = lines[i].Replace(filter, replacement);   }}
         WRITE(source, string.Join(Environment.NewLine, lines));
         
         }

FIND (string source , string filter)
    {
        
       string[] lines = File.ReadAllLines(source);
      int  index = 0;
        foreach (string line in lines)
        {
            if (line.Contains(filter))
            {
                Console.WriteLine($"Found '{filter}' in line {index + 1}: {line}");  
index++;
                }
                
                
                }
         
         
         }


    public static void Main()
    {
        string content = Read("test.txt");
        Console.WriteLine(content);
    }
    
}




