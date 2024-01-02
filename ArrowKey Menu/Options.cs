using Övning_införtentant;
using System.Collections.Generic;

namespace Övning_införtentant
{
    internal class Options
    {

        //menu options, used to generate the different possible menu option objects,
         public string? Option { get; set; }
        public int OptionValue { get; set; }

        public Options() { }
        public Options(string option) 
        {
            Option = option;
        }

        public Options(string option, int optionValue)
        {
                Option = option;
            OptionValue = optionValue;
        }

        //public static List<Options> options
        //{
        //    get { return new List<Options>(option); }
        //    set { option = value; }
        //}
        //private static List<Options> option = new List<Options>()
        //{
        //    new Options {Option="New Game", OptionValue = 1, IsMainMenu = true},
        //    new Options { Option = "Load Game", OptionValue = 1, IsMainMenu = true },
        //    new Options { Option = "Exit Game", OptionValue = 1, IsMainMenu = true },
        //    //new game menu
        //    new Options { Option = "Back To Main Menu", OptionValue = 2, IsNewGameMenu = true },
        //    //in dungeon Menu
        //    new Options {Option = "Move Forward", OptionValue = 3, IsInDungeonMenu = true},
        //    new Options {Option = "Go Back", OptionValue = 3, IsInDungeonMenu = true},
        //    new Options {Option = "Save Game", OptionValue = 3, IsInDungeonMenu = true},
        //    new Options { Option = "Leave Dungeon", OptionValue = 3, IsInDungeonMenu = true },
        //    //In Town Menu
        //    new Options { Option = "Enter Dungeon", OptionValue = 4, IsInTownMenu = true },
        //    new Options { Option = "Rest", OptionValue = 4, IsInTownMenu = true },
        //    new Options { Option = "Visit Store", OptionValue = 4, IsInTownMenu = true  },
        //    new Options { Option = "Save Game", OptionValue = 4, IsInTownMenu = true  },
        //    new Options { Option = "Level Up", OptionValue = 4, IsInTownMenu = true  },
        //    new Options { Option = "Back To Menu", OptionValue = 4, IsInTownMenu = true  },
        //    //in Store Menu
        //    new Options { Option = "Buy Item 1:", OptionValue = 5, IsInStoreMenu = true },
        //    new Options { Option = "Buy Item 2:", OptionValue = 5, IsInStoreMenu = true  },
        //    new Options { Option = "Buy Item 3:", OptionValue = 5, IsInStoreMenu = true  },
        //    new Options { Option = "Leave Store", OptionValue = 5, IsInStoreMenu = true  },
        //    //In Fight Menu
        //    new Options { Option = "Attack", OptionValue = 6, IsInFightMenu = true },
        //    new Options { Option = "Special Attack", OptionValue = 6, IsInFightMenu = true  },
        //    new Options { Option = "Flee", OptionValue = 6, IsInFightMenu = true  },
        //    //in Load Game Menu
        //    new Options { Option = "Back To Menu", OptionValue = 7, IsInLoadGameMenu = true }
        //};


        public override string ToString()
        {
            return $"{Option}";
        }

    }
}
