class tamagotchi    
{
    int hunger;
    int boredom;
    public bool isAlive = true;
    List<string> words = new();

    Random gen = new();
    public string name;

    public void Feed()
    {
        Console.WriteLine("Feed Da Dog");
        hunger = 0;
    }

    public void Hi()
    {
        int choice = gen.Next(words.Count);
        Console.WriteLine(words[choice]);
        Reduceboredom();
    }

    public void Teach()
    {
        Console.WriteLine("What word would you like to teach your child?");
        string word = Console.ReadLine();
        words.Add(word);
        Console.WriteLine($"You taught your child to say '{word}'");
        Reduceboredom();
    }

    public void Tick()
    {

        boredom += gen.Next(3);
        hunger += gen.Next(5);
        if (hunger >= 10 || boredom >= 20)
        {
            isAlive = false;
        }
    }

    public void PrintStats()
    {
        string aliveTrue;
        if (isAlive)
        {
            aliveTrue = "Alive";
        }
        else
        {
            aliveTrue = "Dead";
        }
        Console.WriteLine($"hunger: {hunger}, Boredom: {boredom}, Your kid is {aliveTrue}");
    }

    public bool GetAlive()
    {
        if (isAlive)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    void Reduceboredom()
    {
        boredom = boredom/2;
    }
}