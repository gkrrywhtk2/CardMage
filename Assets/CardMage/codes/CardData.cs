using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Card", menuName = "scriptble object/CardData")]
public class CardData : ScriptableObject
{

    public enum CardType
    {
      basic,fire
    }
   

    [Header("# Main Info")]

    public int cardId;
    public CardType cardType;

    [Header("# Language")]
    public string cardNameKr;
    public string cardTextKr;

    [Header("# Image")]
    
    public Sprite cardSprite;

    [Header("# Level Data")]
    public float[] damages;
    public int[] counts;

    [Header("# Connect")]
    public int objectSpeed;
    public bool comboCard;

   
}
