using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace bonehead
{ 
   
    public class ItemVisualisation : MonoBehaviour
    {
        [SerializeField] public TMP_Text nameText;
        [SerializeField] public TMP_Text attackValue;
        [SerializeField] public TMP_Text armorValue;
        [SerializeField] public TMP_Text hitpointsValue;
        [SerializeField] public TMP_Text totalAttack;
        [SerializeField] public TMP_Text totalArmor;
        [SerializeField] public TMP_Text totalHitPoints;
        [SerializeField] public Image itemImage;
        [SerializeField] public GameObject[] greenArrows;
        [SerializeField] public GameObject[] redArrows;


       
    }
}
