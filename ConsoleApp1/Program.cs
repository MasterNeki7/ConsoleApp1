tamagotchi t = new();

Console.WriteLine("Name your child!");
t.name = Console.ReadLine();

while (t.isAlive)
{
    Console.Clear();

    Console.WriteLine("What do you wish to do? Teach, Talk, Feed or do nothing. Asnwer with a number");
    string answer = Console.ReadLine();
    int answerInt;
    int.TryParse(answer, out answerInt);

    List<Action> eventList = new();

    eventList.Add(t.Teach);
    eventList.Add(t.Hi);
    eventList.Add(t.Feed);

    for (int i = 0; i < eventList.Count; i++)
    {
        if (answerInt == i + 1)
        {
            eventList[i]();
        }
    }
t.Tick();
t.PrintStats();
Console.ReadLine();
}

