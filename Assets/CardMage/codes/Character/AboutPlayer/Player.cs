using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SimpleCardDrawAndSpread_HandCard;
using SimpleCardDrawAndSpread_CardDrag;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("PlayerStat")]
    public bool islive;
    public float health;
    public float maxhealth;
    public float drawpoint;
    public float maxdrawpoint;
    public float drawrecovery;

    [Header("BasicAttackCorotine")]
    Coroutine basicAttack = null;

    [Header("Connect")]
    HandCardSystem handcardSystem;
    CardDrawSystem carddrawSystem;
    Scaner scaner;


    [Header("Animation")]
    Animator anim;


    public void Awake()
    {
        anim = GetComponent<Animator>();
        scaner = GetComponent<Scaner>();
        Init();
    }

    public void Init()
    {
        islive = true;
        health = maxhealth;
        drawpoint = 0;
        drawrecovery = 0.5f;
    }


    private void FixedUpdate()
    {
        if (GameManager.instanse.isPlay != true)
            return;
        DrawUpdate();
        LifeUpdate();

    }

    private void LifeUpdate()
    {
        if (health < 0 && islive)
        {
            anim.SetTrigger("IsDead");
            islive = false;
        }
    }

    private void DrawUpdate()
    {
        if (drawpoint <= 10)
        {
            drawpoint += drawrecovery * Time.deltaTime;
            if (drawpoint > 10)
            {
                drawpoint = 0;
                GameManager.instanse.cardDrawSystem.Button_CardDraw_Manager();
            }
        }
    }
    public void BackToReadyAnim()
    {
        anim.SetTrigger("Ready");
    }
    public void SlashAnim()
    {
        anim.SetTrigger("Slash");
    }

    public void Damagecalculator(float Damage)
    {
        if (!islive)
            return;

        health -= Damage;
            
    }

    public void BasicAttackStart()
    {
        if (basicAttack != null)
        {
            StopCoroutine(basicAttack);
        }
        basicAttack = StartCoroutine(BasicAttackCoroutine());
    }

    IEnumerator BasicAttackCoroutine()
    {
        if (GameManager.instanse.isPlay == true)
        if (scaner.targets == true)
            {
                anim.SetTrigger("Slash");
                yield return new WaitForSeconds(0.3f);
                GameObject autoattack = GameManager.instanse.pool.Get(1);
                autoattack.transform.position = new Vector2(transform.position.x + 0.5f, transform.position.y + 0.3f);
                int objectSpeed = 3;
                int objectDamage = 3;
                autoattack.GetComponent<bullet>().Init(objectSpeed, objectDamage);
                yield return new WaitForSeconds(2f);
                BasicAttackStart();
            }
            else
            {
                yield return new WaitForSeconds(2f);
                BasicAttackStart();
            }
           
    }
  

    

   
}


        

