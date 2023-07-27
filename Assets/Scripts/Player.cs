using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace bonehead
{
    public class Player : MonoBehaviour
    {
        private int playerHitPoints;
        private int playerAttack;
        private int playerArmor;

        

        [SerializeField] private ItemsCollection collection;

        private Item newItem;
        
        [SerializeField] private ItemVisualisation newItemPanel;
        [SerializeField] private ItemVisualisation currentItemPanel;
        [SerializeField] private ItemVisualisation[] equipedItemsVisual;
       
        [SerializeField] private ItemVisualisation totalStats;

        [SerializeField] private GameObject greenArrows;
        [SerializeField] private GameObject redArrows;
        [SerializeField] private  Sprite blankImage;

        private int totalAttack;
        private int totalArmor;
        private int totalHP;

        
       private Item[] equipedItems;
     
        void Start()
        {
           Item[] equipedItems = new Item[3];
            Debug.Log(equipedItems.Length);
            for (int i = 0; i < equipedItems.Length; i++)
            {
                equipedItems[i] = new Item(blankImage);

            }            

        }

        public void FindNewItem()
        {
            var a = UnityEngine.Random.Range(0, 3);
            if (a==0)
            newItem = collection.GenerateItem(Item.ItemType.Weapon);
            else if(a==1)
                newItem = collection.GenerateItem(Item.ItemType.Shield);
                    else newItem = collection.GenerateItem(Item.ItemType.Helm);

            UpdateVisualisation();
           
        }

        private void UpdateVisualisation()
        {
            newItemPanel.armorValue.text = newItem.armor.ToString();
            newItemPanel.attackValue.text = newItem.attack.ToString();
            newItemPanel.hitpointsValue.text = newItem.hitPoints.ToString();
            newItemPanel.nameText.text = newItem.name.ToString();
            newItemPanel.itemImage.sprite = newItem.itemImage;

            for (int i = 0; i < 3; i++)
            {
                if (newItem.type == equipedItems[i].type)
                {
                    currentItemPanel.armorValue.text = equipedItems[i].armor.ToString();
                    currentItemPanel.attackValue.text = equipedItems[i].attack.ToString();
                    currentItemPanel.hitpointsValue.text = equipedItems[i].hitPoints.ToString();
                    currentItemPanel.nameText.text = equipedItems[i].name.ToString();
                    currentItemPanel.itemImage.sprite = equipedItems[i].itemImage;
                    if (newItem.attack > equipedItems[i].attack)
                    {
                        newItemPanel.greenArrows[0].gameObject.SetActive(true);
                        newItemPanel.redArrows[0].gameObject.SetActive(false);
                        currentItemPanel.redArrows[0].gameObject.SetActive(true);
                        currentItemPanel.greenArrows[0].gameObject.SetActive(false);
                    }
                    else if (newItem.attack < equipedItems[i].attack)
                    {
                        newItemPanel.greenArrows[0].gameObject.SetActive(false);
                        newItemPanel.redArrows[0].gameObject.SetActive(true);
                        currentItemPanel.redArrows[0].gameObject.SetActive(false);
                        currentItemPanel.greenArrows[0].gameObject.SetActive(true);
                    }
                    else
                    {
                        newItemPanel.greenArrows[0].gameObject.SetActive(false);
                        newItemPanel.redArrows[0].gameObject.SetActive(false);
                        currentItemPanel.redArrows[0].gameObject.SetActive(false);
                        currentItemPanel.greenArrows[0].gameObject.SetActive(false);
                    }

                    if (newItem.armor > equipedItems[i].armor)
                    {
                        newItemPanel.greenArrows[1].gameObject.SetActive(true);
                        newItemPanel.redArrows[1].gameObject.SetActive(false);
                        currentItemPanel.redArrows[1].gameObject.SetActive(true);
                        currentItemPanel.greenArrows[1].gameObject.SetActive(false);
                    }
                    else if (newItem.armor < equipedItems[i].armor)
                    {
                        newItemPanel.greenArrows[1].gameObject.SetActive(false);
                        newItemPanel.redArrows[1].gameObject.SetActive(true);
                        currentItemPanel.redArrows[1].gameObject.SetActive(false);
                        currentItemPanel.greenArrows[1].gameObject.SetActive(true);
                    }
                    else
                    {
                        newItemPanel.greenArrows[1].gameObject.SetActive(false);
                        newItemPanel.redArrows[1].gameObject.SetActive(false);
                        currentItemPanel.redArrows[1].gameObject.SetActive(false);
                        currentItemPanel.greenArrows[1].gameObject.SetActive(false);
                    }


                    if (newItem.hitPoints > equipedItems[i].hitPoints)
                    {
                        newItemPanel.greenArrows[2].gameObject.SetActive(true);
                        newItemPanel.redArrows[2].gameObject.SetActive(false);
                        currentItemPanel.redArrows[2].gameObject.SetActive(true);
                        currentItemPanel.greenArrows[2].gameObject.SetActive(false);
                    }
                    else if (newItem.hitPoints < equipedItems[i].hitPoints)
                    {
                        newItemPanel.greenArrows[2].gameObject.SetActive(false);
                        newItemPanel.redArrows[2].gameObject.SetActive(true);
                        currentItemPanel.redArrows[2].gameObject.SetActive(false);
                        currentItemPanel.greenArrows[2].gameObject.SetActive(true);
                    }
                    else
                    {
                        newItemPanel.greenArrows[2].gameObject.SetActive(false);
                        newItemPanel.redArrows[2].gameObject.SetActive(false);
                        currentItemPanel.redArrows[2].gameObject.SetActive(false);
                        currentItemPanel.greenArrows[2].gameObject.SetActive(false);
                    }

                }
            }
        }

        public void Equip()
        {
            for (int i = 0; i < 3; i++)
            {
                if (newItem.type == equipedItems[i].type)
                {
                    equipedItems[i] = newItem;
                    newItem.hitPoints = 0;
                    newItem.armor = 0;
                    newItem.attack = 0;
                    newItem.itemImage = blankImage;

                }
            }
            UpdateVisualisation();
        }

        public void Drop()
        {
            newItem.hitPoints = 0;
            newItem.armor = 0;
            newItem.attack = 0;
            newItem.itemImage = blankImage;
        }




      
        void Update()
        {
            totalArmor = 0;
            totalAttack = 0;
            totalHP = 0;
            Debug.Log(equipedItems.Length);
            for (int i = 0; i < equipedItems.Length; i++)
            {
                equipedItemsVisual[i].armorValue.text = equipedItems[i].armor.ToString();
                equipedItemsVisual[i].attackValue.text = equipedItems[i].attack.ToString();
                equipedItemsVisual[i].hitpointsValue.text = equipedItems[i].hitPoints.ToString();
                equipedItemsVisual[i].nameText.text = equipedItems[i].name.ToString();
                equipedItemsVisual[i].itemImage.sprite = equipedItems[i].itemImage;
                totalHP += equipedItems[i].hitPoints;
                totalAttack += equipedItems[i].attack;
                totalArmor += equipedItems[i].armor;



            }
            totalStats.totalArmor.text = totalArmor.ToString();
            totalStats.totalAttack.text = totalAttack.ToString();
            totalStats.totalHitPoints.text = totalHP.ToString();
        }
    }
}
