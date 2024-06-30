using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleCardDrawAndSpread_HandCard;
using SimpleCardDrawAndSpread_CardDrag;

public class Player_CardMagicManager : MonoBehaviour
{
    [Header("Magic Type")]
    public Player_FireMage fireMage;

    public void CardUnderstand(int cardType, int cardId, int cardLv)
    {
        switch (cardType)
        {
            case 0:
                fireMage.CardUnderstand(cardId, cardLv);
                break;

            case 1:
               
                break;

            case 2:

                break;
            case 3:
                break;

        }

    }


}
