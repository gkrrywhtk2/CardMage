using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Card", menuName = "scriptble object/CardData")]
public class CardData : ScriptableObject
{


    public enum CardType
    {
      fire,Basic
    }
   

    [Header("# Main Info")]

    public int cardid;
    public CardType cardType;
    public string cardname0;
    public string cardname1;
    public string cardname2;
    public int objectSpeed;
    

    [TextArea]
    public string carddesclevel0;
    public string carddesclevel1;
    public string carddesclevel2;
    public Sprite cardicon;

    [Header("# Level Data")]
    public float basedamage;
    public int basecount;
    public float[] damages;
    public int[] counts;

}
