using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Bar : MonoBehaviour
{

    public Player player;

    [Header("Bar")]
    public GameObject hpBar;
    public Slider hpbarSlider;
    public GameObject drawBar;
    public Slider drawBarSlider;


    private void Awake()
    {
       
    }
    private void Update()
    {
        HpUpdate();
        DrawUpdate();
    }

    void HpUpdate()
    {
        hpbarSlider.value = player.health / player.maxhealth;
    }
    void DrawUpdate()
    {
        drawBarSlider.value =player.drawpoint / player.maxdrawpoint;
    }
}
