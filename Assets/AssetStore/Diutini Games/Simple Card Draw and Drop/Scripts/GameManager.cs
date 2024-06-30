using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleCardDrawAndSpread_CardDrag;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static GameManager instanse;
    public Player player;
    public PoolManager pool;
    public HUD hud;
    public MonsterSpawnManager spawnManager;
    public Player_CardMagicManager MagicManager;
    public CardDrawSystem cardDrawSystem;
    public bool isPlay;

    [Header("Can Use Card")]
    public List<bool> CardOn;
    public int[] CardLevels;

    [Header("GameLevel")]
    public int GameStageLevel;




    private void Awake()
    {
        for(int index = 0; index < CardLevels.Length; index++)
        {
            CardLevels[index] = 1;
        }

        Application.targetFrameRate = 60;
        instanse = this;
   
       
    }
    public void GameStartButton()
    {
        isPlay = true;
        instanse.spawnManager.SpawnStart();
        instanse.player.BasicAttackStart();
        instanse.cardDrawSystem.FastWalk(3);
    }

   
}
