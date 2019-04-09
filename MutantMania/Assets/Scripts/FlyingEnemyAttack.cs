using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingEnemyAttack : MonoBehaviour
{

    static public bool flyingAttack;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            flyingAttack = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        flyingAttack = false;
    }
}

