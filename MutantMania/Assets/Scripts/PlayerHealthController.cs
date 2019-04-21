using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthController : MonoBehaviour {

    public static float health = 5;

    //bool isColliding;

    public GameObject bloodfx;
    public GameObject player;

    private void Update()
    {
        if (health < 1)
        {
            player.gameObject.SetActive(false);
        }

        //isColliding = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if (isColliding) return;
        //isColliding = true;
        if (collision.gameObject.CompareTag("EnemySword")) //&& CharacterAnim.attack == true)
        {
            health -= 1;
            Instantiate(bloodfx, transform.position, transform.rotation);
            Debug.Log(health);

            ScreenShake.shake = true;
        }
        else
        {
            ScreenShake.shake = false;
        }
    }
}
