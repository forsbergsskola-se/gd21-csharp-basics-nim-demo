// settings
int players = 2;
int matches = 24;
int minMatches = 1;
int maxMatches = 3;

Console.WriteLine("Welcome to Nim!");

while (!IsGameOver())
{
    PrintMatches();
    PlayerDraw();

    if (IsGameOver())
    {
        Console.WriteLine("You lose.");
        break;
    }

    PrintMatches();
    AIDraw();

    if (IsGameOver())
    {
        Console.WriteLine("The AI loses.");
    }
}

bool IsGameOver()
{
    return matches < 1;
}

void PrintMatches()
{
    Console.WriteLine($"{new string('|', matches)} ({matches})");
}

void PlayerDraw()
{
    int inputNumber = 0;
    while (inputNumber < minMatches || inputNumber > maxMatches)
    {
        Console.WriteLine("How many matches do you want to draw?");
        string inputText = Console.ReadLine();
        inputNumber = int.Parse(inputText);
    }
    matches -= inputNumber;
}

void AIDraw()
{
    int inputNumber = 3;
    Console.WriteLine($"The AI draws {inputNumber} matches.");
    matches -= inputNumber;
}