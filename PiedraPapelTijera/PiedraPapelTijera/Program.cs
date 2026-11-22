Console.WriteLine("Rock - Paper - Scissors");

while (true)
{
    Console.WriteLine("Are You Ready!?");
    Console.WriteLine("Let´s GO!!");

    string selectedChoice = SelectedChoice();
    char yourChoice = char.Parse(selectedChoice);
    Console.WriteLine($"You Selected {yourChoice}");

    char opponentChoice = GetOpponentChoice();
    Console.WriteLine($"I Chose {opponentChoice}");

    DecideWinner(yourChoice, opponentChoice);

    Console.WriteLine("Do you want to play again?");
    Console.WriteLine("Enter Y to play again or N to stop");
    string? playAgain = Console.ReadLine();
    if (playAgain?.ToLower() == "n")
    {
        break;
    }
}

string SelectedChoice()
{
    Console.WriteLine("Choice R - P - S :[R]OCK - [P]APER - [S]CISSORS ");
    string selectedChoice = (Console.ReadLine() ?? "").Trim().ToUpper();

    if (selectedChoice != "R" && selectedChoice != "P" && selectedChoice != "S")
    {
        Console.WriteLine("Usted Digito una opcion invalida, Digite Nuevamente");
        selectedChoice = SelectedChoice();
    }

    return selectedChoice;
}

char GetOpponentChoice()
{
    char[] options = { 'R', 'P', 'S' };
    Random random = new Random();
    int randomIndex = random.Next(0, options.Length);
    return options[randomIndex];
}

void DecideWinner(char yourChoice, char opponentChoice)
{
    if (yourChoice == opponentChoice)
    {
        Console.WriteLine("Draw!");
        return;
    }

    switch (yourChoice)
    {
        case 'R':
            if (opponentChoice == 'P')
            {
                Console.WriteLine("Paper beats rock, I WIN");
            }
            else
            {
                Console.WriteLine("Rock beats Scissors, YOU WIN");
            }
            break;
        case 'P':
            if (opponentChoice == 'S')
            {
                Console.WriteLine("Scissors beats Paper, I WIN");
            }
            else
            {
                Console.WriteLine("Paper beats rock, YOU WIN");
            }
            break;
        case 'S':
            if (opponentChoice == 'R')
            {
                Console.WriteLine("Rock beats Scissors, I WIN");
            }
            else
            {
                Console.WriteLine("Scissors beats Paper, YOU WIN");
            }
            break;
    }
}
