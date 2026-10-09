          namespace TextadventureFramework
          {
            class Game
            {
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
                        test.CreateEnemy("Zombie",100,25,25,1);
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
