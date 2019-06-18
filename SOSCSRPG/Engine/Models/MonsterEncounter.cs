using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Models
{
    public class MonsterEncounter
    {
        public int MonsterID { get; set; }
        public int ChanceOfEncountering { get; set; }

        public MonsterEncounter(int monsterId, int changeChanceOfEncountering)
        {
            MonsterID = monsterId;
            ChanceOfEncountering = changeChanceOfEncountering;
        }
    }
}
