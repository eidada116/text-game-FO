using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject UI, level1, level2, titlescreen, level3;
    public int health, stamina;
    public TextMeshProUGUI HealthText, StaminaText;
    // Start is called before the first frame update
    void Start()
    {
        titlescreen.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        HealthText.text = health.ToString();
        StaminaText.text = stamina.ToString();
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
    }
    public void Button_1()
    {
        level1.SetActive(false);
        level2.SetActive(true);
        
    }
}
