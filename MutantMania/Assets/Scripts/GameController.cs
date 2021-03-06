﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    float level;

    //public static float mana;

    bool levelUp;

    public Text deathText;
    public Text coinText;
    public Text levelText;

    //public GameObject startMenu;   ////////

    public Slider healthSlider;
    public Slider magicSlider;
    public Slider levelSlider;

    public GameObject player;

	// Use this for initialization
	void Start ()
    {
        Cursor.visible = false;

        CoinPickup.coins = 0;

        deathText.text = "";
        PlayerHealthController.health = 8;

        PlayerAttack.score = 0; //or leave it so it accumulates ?

    }

    // Update is called once per frame
    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Joystick1Button12))
        {
            Debug.Log("Quit");
            TransitionAnimForest.forestTran = true;
            StartCoroutine("quit");
            //Application.Quit();
        }
        if (Input.GetKeyDown(KeyCode.R) || Input.GetKeyDown(KeyCode.Joystick1Button13))
        {
            TransitionAnimForest.forestTran = true;
            StartCoroutine("respawn");
            //SceneManager.LoadScene("ForestMap");
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button9))
        {
            TransitionAnimForest.forestTran = true;
            StartCoroutine("menu");
            //startMenu.SetActive(true);     /////////////////
        }

        //death
        if (!player.activeSelf)
        {
            deathText.text = "PRESS [TOUCH PAD] TO RESTART OR [HOME BUTTON] TO QUIT";
        }


        //score
        coinText.text = "COINS: " + CoinPickup.coins;

        //health slider
        healthSlider.maxValue = 8;  //does not actually cap the maximum value for some reason
        healthSlider.value = PlayerHealthController.health;
        /*if (healthSlider.value > 5)
        {
            healthSlider.value = 5;
        }*/


        //magic slider
        magicSlider.maxValue = 10;
        magicSlider.value = WandAttack.mana;
        //magicSlider.value += CoinPickup.mana;
        //mana += CoinPickup.mana;

        //level up
        levelSlider.maxValue = 600;
        //levelSlider.value = (CoinPickup.coins * 2);
        levelSlider.value = (PlayerAttack.score * 2);

        levelText.text = "LEVEL " + level;
        if (levelSlider.value < 50)
        {
            level = 1;
        }
        else if (levelSlider.value >= 50 && levelSlider.value < 125)
        {
            level = 2;
        }
        else if (levelSlider.value >= 125 && levelSlider.value < 200)
        {
            level = 3;
        }
        else if (levelSlider.value >= 200 && levelSlider.value < 300)
        {
            level = 4;
        }
        else if (levelSlider.value >= 300 && levelSlider.value < 400)
        {
            level = 5;
        }
        else if (levelSlider.value >= 400 && levelSlider.value < 500)
        {
            level = 6;
        }
        else if (levelSlider.value >= 500 && levelSlider.value < 600)
        {
            level = 7;
        }
    }

    IEnumerator respawn()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("ForestMap");
    }

    IEnumerator quit()
    {
        yield return new WaitForSeconds(1f);
        Application.Quit();
        //SceneManager.LoadScene("MenuFinal");
    }

    IEnumerator menu()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("MenuFinal");
    }
}
