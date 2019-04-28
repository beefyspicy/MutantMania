using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChestController : MonoBehaviour {

    float rand;

    public GameObject ninjaStar;
    public GameObject helmet;
    public GameObject cuirass;
    public GameObject chestfx;

    public Text chestText;

    bool newText = false;

    private void Start()
    {
        chestText.text = "";

        ninjaStar.SetActive(false);
    }

    private void Update()
    {
        rand = Random.Range(0, 3);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if(rand == 0)
            {
                if (!newText)
                {
                    chestText.text = "[F] to open chest";
                }
                if (Input.GetKey(KeyCode.F))
                {
                    Debug.Log("chest opened");
                    //chestText.text = @"Nothing in there... ¯\_(ツ)_/¯";
                    chestText.text = "You have found a throwing star!";
                    newText = true;
                    ninjaStar.SetActive(true);
                    //Instantiate(chestfx, transform.position, transform.rotation);
                }
                else if (Input.GetKey(KeyCode.E))
                {
                    SceneManager.LoadScene("Dungeon");
                }
            }
            if (rand == 1)
            {
                if (!newText)
                {
                    chestText.text = "[F] to open chest";
                }
                if (Input.GetKey(KeyCode.F))
                {
                    Debug.Log("chest opened");
                    //chestText.text = @"Nothing in there... ¯\_(ツ)_/¯";
                    chestText.text = "You have found a helmet!";
                    newText = true;
                    helmet.SetActive(true);
                    //Instantiate(chestfx, transform.position, transform.rotation);
                }
                else if (Input.GetKey(KeyCode.E))
                {
                    SceneManager.LoadScene("Dungeon");
                }
            }
            if (rand == 2)
            {
                if (!newText)
                {
                    chestText.text = "[F] to open chest";
                }
                if (Input.GetKey(KeyCode.F))
                {
                    Debug.Log("chest opened");
                    //chestText.text = @"Nothing in there... ¯\_(ツ)_/¯";
                    chestText.text = "You have found a cuirass!";
                    newText = true;
                    cuirass.SetActive(true);
                    //Instantiate(chestfx, transform.position, transform.rotation);
                }
                else if (Input.GetKey(KeyCode.E))
                {
                    SceneManager.LoadScene("Dungeon");
                }
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        newText = false;
        chestText.text = "";
    }
}