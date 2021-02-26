using System;

Main();

void Main()
{
    Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine();

    // Let the moose speak!
    MooseSays("H I, I'M  E N T H U S I A S T I C !");
    MooseSays("I really am enthusiastic");

    // As a question
    // CanadaQuestion();
    // EnthusiasticQuestion();
    // LoveCSharpQuestion();
    // SecretQuestion();

    MooseQuestions("Are you enthusiastic?", "Yay!", "You should try it!");
    MooseQuestions("Do you love C# yet?", "Good job sucking up to your instructor!", "You will...oh, yes, you will...");
    MooseQuestions("Are you enthusiastic?", "Do you want to know a secret?", "ME TOO!!!! I love secrets...tell me one!");
    MooseQuestions("Does Canada Exist?", "I knew it!", "I don't know if that's true!");
}


void MooseQuestions(string question, string yes, string no)
{

    bool isTrue = MooseAsks(question);
    if (isTrue)
    {
        MooseSays(yes);
    }
    else
    {
        MooseSays(no);
    }
}


bool MooseAsks(string question)
{
    Console.Write($"{question} (Y/N): ");
    string answer = Console.ReadLine().ToLower();

    while (answer != "y" && answer != "n")
    {
        Console.Write($"{question} (Y/N): ");
        answer = Console.ReadLine().ToLower();
    }

    if (answer == "y")
    {
        return true;
    }
    else
    {
        return false;
    }
}




void MooseSays(string message)
{
    Console.WriteLine($@"
                                      _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
}

