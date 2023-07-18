using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject UI, level1, level2, titlescreen, level3, level4, level5;
    public int health, stamina;
    public TextMeshProUGUI healthText, staminaText;
    // Start is called before the first frame update
    void Start()
    {
        titlescreen.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = health.ToString();
        staminaText.text = stamina.ToString();
    }
    public void StartGameButton()
    {
        titlescreen.SetActive(false);
        level1.SetActive(true);
    }

    public void levelthree()
    {
        
        level2.SetActive(false);
        level3.SetActive(true);
        level5.SetActive(false);
        level4.SetActive(false); ;
       

    }
    public void Button_1()
    {
        level1.SetActive(false);
        level2.SetActive(true);
        stamina -= 5;
      

    }
    public void levelfour()
    {
        level2.SetActive(false);
        level4.SetActive(true);
        level1.SetActive(false);
       
    }
    public void restart()
    {
        titlescreen.SetActive(true);
        level3.SetActive(false);
        level5.SetActive(false);
       

        if (health < 10)
        {
            health = 10;
        }
        if (stamina < 10)
        {
            stamina = 10;
        }
    }

    public void levelfive()
    {
        level4.SetActive(false);
        level5.SetActive(true);
        health -= 10;
    }
  
}
