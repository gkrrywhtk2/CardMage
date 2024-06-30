using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_FireMage : MonoBehaviour
{
    Scaner scaner;
   
    private void Awake()
    {
        scaner = GetComponent<Scaner>();
    }

    public void CardUnderstand(int cardId, int cardLv)
    {
        switch (cardId)
        {
            case 0:
                Card_0_FireBall(cardLv);
                break;

            case 1:
                Card_1_Ignite(cardLv);
                break;

            case 2:

                break;
    
        }

    }

    private void Card_0_FireBall(int cardLv)
    {
        GameManager.instanse.player.SlashAnim();
        GameObject autoattack = GameManager.instanse.pool.Get(2);
        autoattack.transform.position = new Vector2(transform.position.x + 0.4f, transform.position.y - 0.3f);
        int objectSpeed = GameManager.instanse.cardDrawSystem.data[0].objectSpeed;
        float objectDamage = GameManager.instanse.cardDrawSystem.data[0].damages[cardLv];
        autoattack.GetComponent<bullet>().Init(objectSpeed, objectDamage);
    }

    private void Card_1_Ignite(int cardLv)
    {
     
        float objectDamage = GameManager.instanse.cardDrawSystem.data[1].damages[cardLv];
        GameObject Ignite = GameManager.instanse.pool.Get(3);
        Ignite.GetComponent<bullet>().Init(0, objectDamage);

        if (scaner.targets == true)
        {
            Ignite.transform.position = scaner.targets.transform.position + new Vector3(0, 1.1f);
        }
        else
        {
            Ignite.transform.position = transform.position + new Vector3(1, 1.1f);
        }
    }
}
