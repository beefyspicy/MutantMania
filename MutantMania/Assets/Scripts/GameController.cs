using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    float level;

    bool levelUp;

    public Text deathText;
    public Text coinText;
    public Text levelText;

    public Slider healthSlider;
    public Slider magicSlider;
    public Slider levelSlider;

    public GameObject player;

	// Use this for initialization
	void Start ()
    {
        deathText.text = "";
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Joystick1Button12))
        {
            Debug.Log("Quit");
            Application.Quit();
        }
        if (Input.GetKeyDown(KeyCode.R) || Input.GetKeyDown(KeyCode.Joystick1Button13))
        {
            SceneManager.LoadScene("MainScene");
        }

        //death
        if (!player.activeSelf)
        {
            deathText.text = "Press [R] to restart or [ESC] to quit";
        }


        //score
        coinText.text = "Coins: " + CoinPickup.coins;

        //health slider
        healthSlider.maxValue = 5;
        healthSlider.value = PlayerHealthController.health;


        //magic slider
        magicSlider.maxValue = 10;
        magicSlider.value = WandAttack.mana;

        //level up
        levelSlider.maxValue = 50;
        //levelSlider.value = (CoinPickup.coins * 2);
        levelSlider.value = (PlayerAttack.score * 2);

        levelText.text = "Level " + level;
        if (levelSlider.value > 49)
        {
            //levelUp = true;
            //if (levelUp)
            //{
                levelSlider.value = 0;
                //level++;
                //levelUp = false;
            //}
        }
    }
}
