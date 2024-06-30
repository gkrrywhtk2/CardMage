using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("BulletsStat")]
    public float bulletSpeed;
    public float bulletDamage;

    [Header("CardStat")]
    public int thiscardnumber;

    [Header("Animation")]
    Animator anim;



    private void Awake()
    {
        
        anim = GetComponent<Animator>();
      
    }
    private void OnEnable()
    {
      
       
    }


    public void Init(int speed, float damage)
    {
        bulletSpeed = speed;
        bulletDamage = damage;
    }

    private void FixedUpdate()
    {
        transform.Translate(Vector3.right * bulletSpeed * Time.fixedDeltaTime);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Mob"))
            return;

        collision.GetComponent<Mob>().Damagecalculator(bulletDamage);

        switch (thiscardnumber)
        {
                case 0: 
                bulletSpeed = 0;
                anim.SetBool("IsHit", true);
                break;

            case 1:
                break;
        }
       
    }

    public void delete()
    {
        gameObject.SetActive(false);
    }

    IEnumerator destroy()
    {
        yield return new WaitForSeconds(10f);
        gameObject.SetActive(false);
    }
}
