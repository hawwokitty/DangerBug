using DangerBug;

List<Bug> ListOfBugs = new List<Bug>()
{
    new Edderkopp(),
    new Flått(),
    new Husflue(),
    new Mygg(),
    new Veps()
};

while (true)
{
    ShowMenu();
    int userInput = "Skriv inn et tall fra menyen over: ".RequestInt();
    switch (userInput)
    {
        case 1: ShowBugs();
            break;
        case 2: CreateBug();
            break;
        default: Environment.Exit(1);
            break;
    }
}

void ShowMenu()
{
    "1. Vis liste av alle bugs".PrintToConsole();
    "2. Legg til flere bugs".PrintToConsole();
    "Anything else. Close program".PrintToConsole();
}

void ShowBugs()
{
    for (int i = 0; i < ListOfBugs.Count; i++)
    {
        $"{i + 1}. {ListOfBugs[i].Name}".PrintToConsole();
    }

    PickBug();
}

void PickBug()
{
    int userInput = "Skriv inn tallet på den bug'en du vil se nærmere på: ".RequestInt();
    ListOfBugs[userInput-1].GetAllInfo.PrintToConsole();
}

void CreateBug()
{
    string name = "Hva slags bug er det?".RequestString();
    bool canBite = "Kan bug'en bite?".RequestBool();
}