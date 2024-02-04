using System;

Random random = new Random();
Console.CursorVisible = false;
int height = Console.WindowHeight - 1;
int width = Console.WindowWidth - 5;
bool shouldExit = false;

// Console position of the player
int playerX = 0;
int playerY = 0;
int playerSpeed = 1;

// Console position of the food
int foodX = 0;
int foodY = 0;

// Available player and food strings
string[] states = {"('-')", "(^-^)", "(X_X)"};
string[] foods = {"@@@@@", "$$$$$", "#####"};

// Current player string displayed in the Console
string player = states[0];

// Index of the current food
int food = 0;

InitializeGame();
while (!shouldExit) 
{
    if (ShouldFreeze())
        FreezePlayer();

    Move();

    if (TerminalResized())
    {
        shouldExit = true;
        Console.Clear();
        Console.WriteLine("Console was resized. Program exiting.");
    }

    if (FoodConsumed())
    {
        ChangePlayer();
        ShowFood();
    }
}

// Should the player freeze
bool ShouldFreeze()
{
    if (player == states[2])
        return true;
    return false;
}

// Method that affects the movement of the player based on the food they ate
int UpdateMovement(bool faster = false)
{
    if (player.Equals(states[1]) && faster)
    {
        playerSpeed = 3;
    }
    else
        playerSpeed = 1;
    return playerSpeed;
}

// Returns true if the Terminal was resized 
bool TerminalResized() 
{
    return height != Console.WindowHeight - 1 || width != Console.WindowWidth - 5;
}

// Displays random food at a random location
void ShowFood() 
{
    Console.SetCursorPosition(foodX, foodY);
    Console.Write("     ");
    Console.SetCursorPosition(playerX, playerY);
    Console.Write(player);
    // Update food to a random index
    food = random.Next(0, foods.Length);

    // Update food position to a random location
    foodX = random.Next(0, width - player.Length);
    foodY = random.Next(0, height - 1);

    // Display the food at the location
    Console.SetCursorPosition(foodX, foodY);
    Console.Write(foods[food]);
}

// Changes the player to match the food consumed
void ChangePlayer() 
{
    player = states[food];
    Console.SetCursorPosition(playerX, playerY);
    Console.Write(player);
}

// Temporarily stops the player from moving
void FreezePlayer() 
{
    System.Threading.Thread.Sleep(1000);
    player = states[0];
}

// Reads directional input from the Console and moves the player
void Move(bool faster = true, bool allowOnlyDirectionalKeys = false) 
{
    int lastX = playerX;
    int lastY = playerY;
    playerSpeed = UpdateMovement(faster);

    switch (Console.ReadKey(true).Key) 
    {
        case ConsoleKey.UpArrow:
            playerY--; 
            break;
		case ConsoleKey.DownArrow: 
            playerY++; 
            break;
		case ConsoleKey.LeftArrow:  
            playerX -= playerSpeed; 
            break;
		case ConsoleKey.RightArrow: 
            playerX += playerSpeed; 
            break;
		case ConsoleKey.Escape:     
            shouldExit = true; 
            break;
        default:
            shouldExit = allowOnlyDirectionalKeys;
            break;
    }

    // Clear the characters at the previous position
    Console.SetCursorPosition(lastX, lastY);
    for (int i = 0; i < player.Length; i++) 
    {
        Console.Write(" ");
    }

    // Keep player position within the bounds of the Terminal window
    playerX = (playerX < 0) ? 0 : (playerX >= width ? width : playerX);
    playerY = (playerY < 0) ? 0 : (playerY >= height ? height : playerY);

    // Draw the player at the new location
    Console.SetCursorPosition(playerX, playerY);
    Console.Write(player);
}

// Clears the console, displays the food and player
void InitializeGame() 
{
    Console.Clear();
    ShowFood();
    Console.SetCursorPosition(0, 0);
    Console.Write(player);
}

// Chech if the player consumed the food
bool FoodConsumed()
{
    return (playerX <= foodX + 4 && playerX >= foodX - 4) && playerY == foodY;
}