using System.Collections.Generic;
using System.Linq;

namespace Övning_införtentant
{
    internal class Menues
    {
        bool Exit = false;
        public void MenuLoop()
        {
            var optionsList = new List<Options>();
            optionsList = OptionsHelper.GetOptionsList();
            string? optionsNewLoad = optionsList.ToString();
            int currentMenu = 1;
            int menuIndex = 0;
            var options = new List<Options>();
            options = OptionsHelper.GetOptions();
            string selectedOption = "";
            while (true)
            {
                var optionsLoad = options.Where(s => s.OptionValue == currentMenu).ToList<Options>();
                var optionsShown = optionsLoad;
                Console.Clear();
                for (int i = 0; i < optionsLoad.Count; i++)
                {
                    if (i == menuIndex)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    Console.WriteLine(optionsLoad[i]);
                    selectedOption = optionsLoad[menuIndex].ToString();
                    Console.ResetColor();
                }
                ConsoleKeyInfo keyPressed = Console.ReadKey(true);
                switch (keyPressed.Key)
                {
                    case ConsoleKey.DownArrow:
                        if (menuIndex - 1 < optionsLoad.Count)
                        {
                            menuIndex++;
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if (menuIndex > 0)
                        {
                            menuIndex--;
                        }
                        break;
                    case ConsoleKey.Enter:
                        switch (selectedOption)
                        {
                            case "New Game":
                                Console.WriteLine("hello");
                                menuIndex = 0;
                                currentMenu = 2;
                                break;
                            case "Load Game":
                                menuIndex = 0;
                                currentMenu = 7;
                                break;
                            case "Exit Game":
                                Environment.Exit(0);
                                break;
                            case "Back To Menu":
                                menuIndex = 0;
                                currentMenu = 1;
                                break;
                            case "Move Forward":
                                menuIndex = 0;
                                break;
                            case "Go Back":
                                menuIndex = 0;
                                break;
                            case "Save Game":
                                menuIndex = 0;
                                break;
                            case "Leave Dungeon":
                                menuIndex = 0;
                                currentMenu = 4;
                                break;
                            case "Enter Dungeon":
                                menuIndex = 0;
                                currentMenu = 3;
                                break;
                            case "Rest":
                                menuIndex = 0;
                                break;
                            case "Level Up":
                                menuIndex = 0;
                                break;
                            case "Buy Item 1":
                                menuIndex = 0;
                                break;
                            case "Buy Item 2:":
                                menuIndex = 0;
                                break;
                            case "Buy Item 3:":
                                menuIndex = 0;
                                break;
                            case "Leave Store":
                                menuIndex = 0;
                                currentMenu = 4;
                                break;
                            case "Attack":
                                menuIndex = 0;
                                break;
                            case "Special Attack":
                                menuIndex = 0;
                                break;
                            case "Flee":
                                menuIndex = 0;
                                currentMenu = 3;
                                break;
                            case "Fight Monster":
                                menuIndex = 0;
                                currentMenu = 6;
                                break;
                            case "Hide":
                                menuIndex = 0;
                                currentMenu = 6;
                                break;
                            case "Demo Char":
                                menuIndex = 0;
                                currentMenu = 3;
                                break;
                        }
                                break;
                }   
            }
        }
        public string GetString()
        {
            return "";
        }
        public void InMainMenu()
        {



        }

        public void InNewGameMenu()
        {
            Console.WriteLine("A new Game option Click Here");

        }

        public void InDungeonMenu()
        {


        }

        public void InTownMenu()
        {


        }

        public void InStoreMenu()
        {



        }

        public void InFightMenu()
        {


        }

        public void InLoadGameMenu()
        {



        }
    }


}



//  switch (optionsNewLoad)
//{
//    case "New Game":
//        Console.WriteLine("hello");
//        uppdater = true;
//        Console.ReadLine();
//        currentMenu = 2;
//        break;
//    case "Load Game":
//        currentMenu = 7;
//        break;
//    case "Exit Game":
//        Environment.Exit(0);
//        break;
//    case "Back To Menu":
//        currentMenu = 1;
//        break;
//    case "Move Forward":

//        break;
//    case "Go Back":

//        break;
//    case "Save Game":

//        break;
//    case "Leave Dungeon":
//        currentMenu = 4;
//        break;
//    case "Enter Dungeon":
//        currentMenu = 3;
//        break;
//    case "Rest":

//        break;
//    case "Level Up":

//        break;
//    case "Buy Item 1":

//        break;
//    case "Buy Item 2:":

//        break;
//    case "Buy Item 3:":

//        break;
//    case "Leave Store":
//        currentMenu = 4;
//        break;
//    case "Attack":

//        break;
//    case "Special Attack":

//        break;
//    case "Flee":
//        currentMenu = 3;
//        break;
//    case "Fight Monster":
//        currentMenu = 6;
//        break;
//    case "Hide":
//        currentMenu = 6;
//        break;
//    case "Demo Char":
//        currentMenu = 3;
//        break;