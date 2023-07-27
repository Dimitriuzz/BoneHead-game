using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace bonehead
{
    public class ItemsCollection : MonoBehaviour
    {
        [SerializeField] private string[] weaponNames;
        [SerializeField] private string[] shieldNames;
        [SerializeField] private string[] helmNames;

        [SerializeField] private Sprite[] weaponImages;
        [SerializeField] private Sprite[] shieldImages;
        [SerializeField] private Sprite[] helmImages;

        private Item newItem;
        // Start is called before the first frame update
        void Start()
        {
            
        }

        public Item GenerateItem(Item.ItemType type)
        {
            newItem.attack = Random.Range(1, 16);
            newItem.armor = Random.Range(1, 16);
            newItem.hitPoints = Random.Range(1, 16);
            newItem.type = type;
            switch(type)
            {
                case Item.ItemType.Weapon:
                {
                        newItem.name = weaponNames[Random.Range(0, weaponNames.Length)];
                        newItem.itemImage = weaponImages[Random.Range(0, weaponImages.Length)];
                        break;

                }
                case Item.ItemType.Shield:
                    {
                        newItem.name = shieldNames[Random.Range(0, shieldNames.Length)];
                        newItem.itemImage = shieldImages[Random.Range(0, shieldImages.Length)];
                        break;
                    }
                case Item.ItemType.Helm:
                    {
                        newItem.name = helmNames[Random.Range(0, helmNames.Length)];
                        newItem.itemImage = helmImages[Random.Range(0, helmImages.Length)];
                        break;
                    }

            }
            return newItem;
        }
        // Update is called once per frame
        void Update()
        {

        }
    }
}
