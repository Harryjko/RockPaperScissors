const string Rock = "Rock";
const string Paper = "Paper";
const string Scissors = "Scissors";
Console.Write("Choose [R]ock, [P]aper or [S]cissors");
string PlayerMove = Console.ReadLine();
if (PlayerMove == "r" || PlayerMove == "Rock")
{
    PlayerMove = Rock;
}
else if (PlayerMove == "s" || PlayerMove == "Scissors")
{
    PlayerMove = Scissors;
}
else if (PlayerMove == "p" || PlayerMove == "Paper")
{
    PlayerMove = Paper;
}
else
{
    Console.WriteLine("Invalid. Try again.");
        return;
}
Random random = new Random();
int computerRandomnumber = random.Next(1, 4);
string computerMove = "";
switch (computerRandomnumber)
{
    case 1:
        computerMove = Rock;
        break;
    case 2:
        computerMove = Paper;
        break;
    case 3:
        computerMove = Scissors;
        break;
}
Console.WriteLine($"The computer chose {computerMove}.");
if ((PlayerMove == Rock && computerMove == Scissors) ||
    (PlayerMove == Paper && computerMove == Rock) ||
    (PlayerMove == Scissors && computerMove == Paper))
{
    Console.WriteLine("You win!");
}

else if ((PlayerMove == Scissors && computerMove == Rock) ||
    (PlayerMove == Rock && computerMove == Paper) ||
    (PlayerMove == Paper && computerMove == Scissors))
{
    Console.WriteLine("You lose.");
}
else if ((PlayerMove == Scissors && computerMove == Scissors) ||
    (PlayerMove == Paper && computerMove == Paper) ||
    (PlayerMove == Rock && computerMove == Rock))
{
    Console.WriteLine("Draw!");
}