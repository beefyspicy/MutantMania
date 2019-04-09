using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ChestController : MonoBehaviour {

    public GameObject chestfx;

    public Text chestText;

    bool newText = false;

    private void Start()
    {
        chestText.text = "";
    }

    /*private void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            Debug.Log("chest opened");
        }
    }*/

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if(!newText)
            {
                chestText.text = "[F] to open chest";
            }
            if (Input.GetKey(KeyCode.F))
            {
                Debug.Log("chest opened");
                chestText.text = @"Nothing in there... ¯\_(ツ)_/¯";
                newText = true;
                //Instantiate(chestfx, transform.position, transform.rotation);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        newText = false;
        chestText.text = "";
    }
}
