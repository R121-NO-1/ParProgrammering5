// See https://aka.ms/new-console-template for more information

// Danger Bug

using ParProgrammering5;


Console.WriteLine("List over ALL bugs.. in this book; ");


List<bug>BOOKOFBUGS=new List<bug>(){new mygg("mosquito"), /*new Edderkopp()*/};
OpenList();

void OpenList()
{
    for (int i = 0; i < BOOKOFBUGS.Count; i++) // same as for each
    {
        Console.WriteLine($"{i+1} {BOOKOFBUGS[i].name} ");
        
    }
}
