using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterAnim : MonoBehaviour {

    //public static float mana = 10;

    private float time;
    public float startTime;

    static public bool attack;

    public GameObject swordTrail;
    public GameObject swordTrail2;
    public GameObject swordTrail3;

    private Animator anim;

    //Rigidbody2D rb;

    void Start()
    {
        anim = GetComponent<Animator>();
        time = startTime;
    }

    void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        //attack = false; ///////////

        //int r = Random.Range(0, 5);

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || PlayerController.moveHorizontal < 0 || PlayerController.moveHorizontal > 0)
        {
            anim.SetBool("isRunning", true);
        }
        else
        {
            anim.SetBool("isRunning", false);
        }

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Joystick1Button1))
        {
            anim.SetTrigger("jump");

            /*if (r == 0 || r == 1 || r == 3)
            {
                anim.SetTrigger("jump");
            }
            else if (r == 4)
            {
                anim.SetTrigger("jump2");
            }*/
        }

        if (time <= 0)
        {
            if(Input.GetKeyDown(KeyCode.Mouse0) || Input.GetKeyDown(KeyCode.Joystick1Button0))
            {
                AudioManager.playSword = true;

                attack = true;
                anim.SetTrigger("attack");
                time = startTime;
                swordTrail.SetActive(true);
                swordTrail2.SetActive(true);
                swordTrail3.SetActive(true);
            }
            else
            {
                attack = false;
                swordTrail.SetActive(false);
                swordTrail2.SetActive(false);
                swordTrail3.SetActive(false);
            }
            if ((Input.GetKeyDown(KeyCode.Mouse1) || Input.GetKeyDown(KeyCode.Joystick1Button2)) && sceneName == "TownMap")  // && ChestController.ninjaStar.activeSelf)
            {
                attack = true;
                anim.SetTrigger("ninjaThrow");
                time = startTime;
            }
            if (Input.GetKeyDown(KeyCode.Mouse2) || Input.GetKeyDown(KeyCode.Joystick1Button3))
            {
                anim.SetTrigger("wandAttack");
                //StartCoroutine("wandHold");
                //mana--;
            }
        }
        else
        {
            time -= Time.deltaTime;
        }
    }

    /*IEnumerator wandHold()
    {
        yield return new WaitForSeconds(.5f);
    }*/
}
