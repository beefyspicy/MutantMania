using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUpChecker : MonoBehaviour {

    public static bool moveUp;

    private void Start()
    {
        moveUp = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            moveUp = true;
        }
    }
}
