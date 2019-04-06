using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour {

    static public bool attack;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            attack = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        attack = false;
    }
}
