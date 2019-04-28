using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashEnemyController : MonoBehaviour
{
    public GameObject trashfx;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ChaseMonster") || collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Sword"))
        {
            Instantiate(trashfx, transform.position, transform.rotation);
            gameObject.SetActive(false);
        }
    }
}
