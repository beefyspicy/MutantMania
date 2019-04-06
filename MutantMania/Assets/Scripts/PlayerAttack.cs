using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {

    public GameObject bloodfx;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && CharacterAnim.attack == true)
        {
            Instantiate(bloodfx, collision.transform.position, collision.transform.rotation);
        }
    }
}