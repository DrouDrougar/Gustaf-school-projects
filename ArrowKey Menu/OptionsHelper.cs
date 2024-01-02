using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_införtentant
{
    internal static class OptionsHelper
    {
        public static List<Options> GetOptions()
        { 
            var options = new List<Options>();
            options.Add(new Options("New Game", 1 ));
            options.Add(new Options("Load Game", 1));
            options.Add(new Options("Exit Game", 1));

            options.Add(new Options("Demo Char", 2));
            options.Add(new Options("Back To Menu", 2));

            options.Add(new Options("Move Forward", 3));
            options.Add(new Options("Go Back", 3));
            options.Add(new Options("Fight Monster", 3));
            options.Add(new Options("Hide", 3));
            options.Add(new Options("Save Game", 3));
            options.Add(new Options("Leave Dungeon", 3));

            options.Add(new Options("Enter Dungeon", 4));
            options.Add(new Options("Rest", 4));
            options.Add(new Options("Save Game", 4));
            options.Add(new Options("Level Up", 4));
            options.Add(new Options("Move Forward", 4));
            options.Add(new Options("Back To Menu", 4));

            options.Add(new Options("Buy Item 1", 5));
            options.Add(new Options("Buy Item 2:", 5));
            options.Add(new Options("Buy Item 3:", 5));
            options.Add(new Options("Leave Store", 5));

            options.Add(new Options("Attack", 6));
            options.Add(new Options("Special Attack", 6));
            options.Add(new Options("Flee", 6));

            options.Add(new Options("Back To Menu", 7));

            return options;
        
        }

        public static List<Options> GetOptionsList()
        {
            var optionsList = new List<Options>();
            optionsList.Add(new Options("New Game"));
            optionsList.Add(new Options("Load Game"));
            optionsList.Add(new Options("Exit Game"));

            optionsList.Add(new Options("Demo Char"));
            optionsList.Add(new Options("Back To Menu"));
            optionsList.Add(new Options("Back To Menu"));

            optionsList.Add(new Options("Move Forward"));
            optionsList.Add(new Options("Go Back"));
            optionsList.Add(new Options("Fight Monster"));
            optionsList.Add(new Options("Hide"));
            optionsList.Add(new Options("Save Game"));
            optionsList.Add(new Options("Leave Dungeon"));

            optionsList.Add(new Options("Enter Dungeon"));
            optionsList.Add(new Options("Rest"));
            optionsList.Add(new Options("Save Game"));
            optionsList.Add(new Options("Level Up"));
            optionsList.Add(new Options("Move Forward"));
            optionsList.Add(new Options("Back To Menu"));

            optionsList.Add(new Options("Buy Item 1"));
            optionsList.Add(new Options("Buy Item 2:"));
            optionsList.Add(new Options("Buy Item 3:"));
            optionsList.Add(new Options("Leave Store"));

            optionsList.Add(new Options("Attack"));
            optionsList.Add(new Options("Special Attack"));
            optionsList.Add(new Options("Flee"));

            optionsList.Add(new Options("Back To Menu"));

            return optionsList;
        }
    }
}


/*
 * 
 *  "Back To Main Menu"
 *                     new Options {Option = "Move Forward"},
                    new Options {Option = "Go Back"},
                    new Options {Option = "Save Game"},
                    new Options { Option = "Leave Dungeon"},
 * 
 *                                 //In Town Menu
                    new Options { Option = "Enter Dungeon"},
                    new Options { Option = "Rest"},
                    new Options { Option = "Visit Store"},
                    new Options { Option = "Save Game"},
                    new Options { Option = "Level Up"},
                    new Options { Option = "Back To Menu"},
 * 
 *                //in Store Menu
                 new Options { Option = "Buy Item 1:"},
                 new Options { Option = "Buy Item 2:"  },
                 new Options { Option = "Buy Item 3:"  },
                 new Options { Option = "Leave Store" },
 * 
 *                                //In Fight Menu
                    new Options { Option = "Attack" },
                    new Options { Option = "Special Attack" },
                    new Options { Option = "Flee" },
 * 
 *              new Options { Option = "Back To Menu"    }
 * 
 */