using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HUD : MonoBehaviour
{
    // Start is called before the first frame update
  
    [Header("CheatUi(Test)")]
    public GameObject firstdrawB;
    public GameObject nomaldrawB;

    [Header("cardui")]
    public Text cardname;
    public Text cardexplation;
    public Image carduipanel;
    

    public void CheatOn()
    {
        firstdrawB.gameObject.SetActive(true);
        nomaldrawB.gameObject.SetActive(true);
    }
    public void CheatOff()
    {
        firstdrawB.gameObject.SetActive(false);
        nomaldrawB.gameObject.SetActive(false);
    }

    private void Awake()
    {
      
    }
    // Update is called once per frame
  
   
   
}
