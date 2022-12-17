using System;
using NameGenerator;

class Run
{
    static public void Main(String[] args)
    {
        var randomName = NamesGenerator.GenerateName();
        Console.WriteLine(randomName);
    }
}


