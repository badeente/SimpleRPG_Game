using System;
using System.Collections.Generic;
using System.Text;
using Engine.Models;
using System.Linq;

namespace Engine.Factories
{
    internal static class QuestFactory
    {
        private static readonly List<Quest> _quests = new List<Quest>();

        static QuestFactory()
        {
            //Declare the items need to complete the quest, and its rewrd items
            List<ItemQuantity> itemstoComplete = new List<ItemQuantity>();
            List<ItemQuantity> rewardItems = new List<ItemQuantity>();

            itemstoComplete.Add(new ItemQuantity(9001, 5));
            rewardItems.Add(new ItemQuantity(1002, 1));

            //Create the quest
            _quests.Add(new Quest(1,
                                    "Clear the herb garden",
                                    "Defeat the snakes in the Herbalist's garden",
                                    itemstoComplete,
                                    25, 10,
                                    rewardItems));
        }

        internal static Quest GetQuestById(int id)
        {
            return _quests.FirstOrDefault(quest => quest.ID == id);
        }
    }
}
