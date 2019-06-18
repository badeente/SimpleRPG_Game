using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Models
{
    public class Weapon : GameItem
    {
        public int MinimumDamge { get; set; }
        public int MaximumDamge { get; set; }

        public Weapon(int itemTypeId, string name, int price, int minDamage, int maxDamage) 
            : base(itemTypeId, name, price)
        {
            MinimumDamge = minDamage;
            MaximumDamge = maxDamage;
        }


        public new Weapon Clone()
        {
            return new Weapon(ItemTypeId, Name, Price, MinimumDamge, MaximumDamge);
        }
    }
}
