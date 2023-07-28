using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace bonehead
{
    public class Item 
    {
        public enum ItemType { Weapon=0, Shield=1, Helm=2, None=3}

        public int attack;
        public int armor;
        public int hitPoints;

        public ItemType type;

        public string name;

        public Sprite itemImage;

        public Item (Sprite sprite)
        {
            hitPoints = 0;
            armor = 0;
            attack = 0;
            name = "Item";
            type = ItemType.Weapon;
            itemImage = sprite;

        }
    }
}
