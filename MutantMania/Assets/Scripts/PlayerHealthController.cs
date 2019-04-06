using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthController : MonoBehaviour {

    public float health;

    //bool isColliding;

    public GameObject bloodfx;

    private void Update()
    {
        if (health < 1)
        {
            gameObject.SetActive(false);
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
        }
    }
}
