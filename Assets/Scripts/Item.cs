using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace bonehead
{
    public class Item 
    {
        public enum ItemType { Weapon=0, Shield=1, Helm=2}

        public int attack;
        public int armor;
        public int hitPoints;

        public ItemType type;

        public string name;

        public Image itemImage;
    }
}
