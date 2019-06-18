using System;
using System.Collections.Generic;
using System.Text;
using Engine.Models;

namespace Engine.Factories
{
    internal static class WorldFactory
    {
        internal static World CreateWorld()
        {
            World newWorld = new World();
            newWorld.AddLocation(-2, -1, "Farmer's Field", "There are rows of corn growing here, with giant rats hiding between them.",
                "C:/Tutorials/SimpleRPG_Game/SOSCSRPG/Engine/Images/Locations/FarmFields.png");
            newWorld.AddLocation(-1, -1, "Farmer's House", "This is the house of your neighbor",
                "C:/Tutorials/SimpleRPG_Game/SOSCSRPG/Engine/Images/Locations/Farmhouse.png");
            newWorld.AddLocation(0, -1, "Home", "This is your Home", 
                "C:/Tutorials/SimpleRPG_Game/SOSCSRPG/Engine/Images/Locations/Home.png");
            newWorld.AddLocation(-1, 0, "Trading Shop", "The shop of Susan, the trader.", 
                "C:/Tutorials/SimpleRPG_Game/SOSCSRPG/Engine/Images/Locations/Trader.png");
            newWorld.AddLocation(0, 0, "Town square", "You see a fountain here.", 
                "C:/Tutorials/SimpleRPG_Game/SOSCSRPG/Engine/Images/Locations/TownSquare.png");
            newWorld.AddLocation(1, 0, "Town Gate", "There is a gate here, protecting the town from giant spiders.",
                "C:/Tutorials/SimpleRPG_Game/SOSCSRPG/Engine/Images/Locations/TownGate.png");
            newWorld.AddLocation(2, 0, "Spider Forest", "The trees in this forest are covered with spider webs.",
                "C:/Tutorials/SimpleRPG_Game/SOSCSRPG/Engine/Images/Locations/SpiderForest.png");
            newWorld.AddLocation(0, 1, "Herbalist's hut", "You see a small hut, with plants drying from the roof.",
                "C:/Tutorials/SimpleRPG_Game/SOSCSRPG/Engine/Images/Locations/HerbalistsHut.png");
            newWorld.AddLocation(0, 2, "Herbalist's garden", "There are many plants here, with snakes hiding behind them.",
                "C:/Tutorials/SimpleRPG_Game/SOSCSRPG/Engine/Images/Locations/HerbalistsGarden.png");

            return newWorld;
        }
    }
}
