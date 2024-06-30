using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawnManager : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform spawnpoint;
    public GameObject startButtonTest;
  
    Coroutine mobSpawnCoroutine = null;


    public void SpawnStart()
    {
        if (mobSpawnCoroutine != null)
        {
            StopCoroutine(mobSpawnCoroutine);
        }
        mobSpawnCoroutine = StartCoroutine(SpawnMonster());
        startButtonTest.gameObject.SetActive(false);
    }
    public void SpawnStop()
    {
        StopCoroutine(mobSpawnCoroutine);
    }


    IEnumerator SpawnMonster()
    {
        if (GameManager.instanse.isPlay == true)
        {
            GameObject monster_0 = GameManager.instanse.pool.Get(0);
            monster_0.transform.position = new Vector2(spawnpoint.transform.position.x, spawnpoint.transform.position.y);
            yield return new WaitForSeconds(10f);
            SpawnStart();
        }

    }

}
