using System.Collections.Generic;

HashSet<string> courseA = new HashSet<string>();
HashSet<string> courseB = new HashSet<string>();
HashSet<string> courseC = new HashSet<string>();

Console.Write("How many students for course A? ");
int a = int.Parse(Console.ReadLine());
for(int i = 0; i < a; i++)
{
    Console.WriteLine("Enter with the students id:");
    string id = Console.ReadLine();
    courseA.Add(id);
}
Console.Write("How many students for course B? ");
int b = int.Parse(Console.ReadLine());
for (int i = 0; i < b; i++)
{
    Console.WriteLine("Enter with the students id:");
    string id = Console.ReadLine();
    courseB.Add(id);
}
Console.Write("How many students for course C? ");
int c = int.Parse(Console.ReadLine());
for (int i = 0; i < c; i++)
{
    Console.WriteLine("Enter with the students id:");
    string id = Console.ReadLine();
    courseC.Add(id);
}

HashSet<string> all = new HashSet<string>(courseA);
all.UnionWith(courseB);
all.UnionWith(courseC);
Console.WriteLine("Total students: " + all.Count);

