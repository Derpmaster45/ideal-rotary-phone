          namespace TextadventureFramework
          {
            class Game
            {
				  void setTextColor(string textcolor)
    {
        Console.WriteLine("What text color would you want to use for your Character(s)");
        textcolor=Console.ReadLine();
        switch(textcolor.ToLower())
        {
                case"black":
                Console.ForegroundColor=ConsoleColor.Black;
                    break;
                case"red": 
                Console.ForegroundColor=ConsoleColor.Red;
                break;
                case "dark blue":
                case"db":
                Console.ForegroundColor=ConsoleColor.DarkBlue;
                break;
                case"dark green":
                case"dgr":
                Console.ForegroundColor=ConsoleColor.DarkGreen;
                break;
                case"dark cyan":
                case"dc":
                Console.ForegroundColor=ConsoleColor.DarkCyan;
                break;
                case "dark red":
                case"dr":
                Console.ForegroundColor=ConsoleColor.DarkRed;
                break;
                case"dark magenta":
                case "dm":
                Console.ForegroundColor=ConsoleColor.DarkMagenta;
                break;
                case"dark yellow":
                case "dy":
                Console.ForegroundColor=ConsoleColor.DarkYellow;
                break;
                case "gray":
                Console.ForegroundColor=ConsoleColor.Gray;
                break;
                case"dark gray":
                case"dgra":
                Console.ForegroundColor=ConsoleColor.DarkGray;
                break;
                case"blue":
                Console.ForegroundColor=ConsoleColor.Blue;
                break;
                case"green":
                Console.ForegroundColor=ConsoleColor.Green;
                break;
                case"cyan":
                Console.ForegroundColor=ConsoleColor.Cyan;
                break;
                // red is excluded because it is used as an error message indicator
                case"magenta":
                Console.ForegroundColor=ConsoleColor.Magenta;
                break;
                case"yellow":
                Console.ForegroundColor=ConsoleColor.Yellow;
                break;
                case"white":
                Console.ForegroundColor=ConsoleColor.White;
                break;
                default:
                DisplayErrorMessage("Error setting to default color");
                Console.ForegroundColor=ConsoleColor.Gray;
                textcolor="";
                break;
                
        }
    }
                static void DisplayErrorMessage(string message)
                {
                    Console.ForegroundColor=ConsoleColor.Red;
                    Console.WriteLine(message);
                    Console.ForegroundColor=ConsoleColor.White;
                    
                }
                static void ClearConsole()
                {
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    Console.Clear();
                }
                static void QuitGame()
                {
                    string quitgame="";
                    string message="";
                    // prompt user to make sure they want to quit
                    while(quitgame=="")
                    {
                        Console.WriteLine("Are you sure you want to quit y/n");
                        quitgame= Console.ReadLine();
                        switch(quitgame.ToLower())
                        {
                                case"y":
                                Console.WriteLine("GoodBye! Thanks for Playing!");
                                Environment.Exit(0);
                                break;
                                case"n":
                                Run();
                                break;
                            default:
                                DisplayErrorMessage(message);
                                break;
                        
                        }
                    }
                }
            public static void Run()
            {
                //game code
                Console.WriteLine("YOURGAMENAME HERE\n 1) New Game\n 2) Exit\n");
                 Enemy test =new Enemy();
                 Character player= new Character();
                string mainMenuOption=Console.ReadLine();
                switch(mainMenuOption.ToLower())
                {
                    case "1":
                    case"new game":
                        Console.WriteLine("New game started");
                        player.CreateCharacter();
                        test.CreateEnemy("Zombie",100,25,25,1,25);
                        break;
                    case"2":
                    case"exit":
                    case"quit":
                    case"quit game":
                        QuitGame();
                        break;
                }
            }
                
            }    
          }
