using System;
class program
{
class IndexerClass
{
    public string[] names = new string[5];
    public string this[int i]
    {
        get
        {
            return names[i];
        }
        set
        {
            names[i] = value;
        }
    }
}

static void Main(string[] args)
    {
        IndexerClass Team = new IndexerClass();
        Team[0] = "Sasin";
        Team[1] = "Ashok";
        Team[2] = "Pravin";
        Team[3] = "Rajan";
        

        for(int i=0;i<=4;i++)
        {
            Console.WriteLine(Team[i]);
        }

        Console.ReadKey();
        
    }

}