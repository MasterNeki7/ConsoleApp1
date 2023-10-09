class tamagotchi    
{
    int hunger;
    int boredom;
    public bool isAlive = true;
    int money = 100;
    int gamble;

   public List<string> wordList = new();
    
    

    Random gen = new();
    public string name;

    public void Feed()
    {
        Console.WriteLine($"You fed {name}!");
        hunger = 0;
    }

    public void Hi()
    {
        int choice = gen.Next(wordList.Count);
        Console.WriteLine(wordList[choice]);
        Reduceboredom();
    }

    public void Teach()
    {
        Console.WriteLine($"What word would you like to teach {name}?");
        string word = Console.ReadLine();
        wordList.Add(word);
        Console.WriteLine($"You taught {name} to say '{word}'");
        Reduceboredom();
    }

    public void Tick()
    {

        boredom += gen.Next(3);
        hunger += gen.Next(5);
        if (hunger >= 50 || boredom >= 100)
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
        Console.WriteLine($"hunger: {hunger}, Boredom: {boredom}, Money: {money}, {name} is {aliveTrue}");
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

    public void Gamble()
    {
        gamble = gen.Next(20);
        if (gamble >= 13)
        {
            money += gen.Next(20);
            Console.WriteLine("You won 10$!");
        }
        else{
            Console.WriteLine("You lost 10$!");
            money -= 10;
        }
    }
}