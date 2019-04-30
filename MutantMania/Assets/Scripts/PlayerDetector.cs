using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetector : MonoBehaviour
{
    public float speed;

    public GameObject player;
    public GameObject bug;

    private void OnTriggerStay2D(Collider2D collision)
    {
        float step = speed * Time.deltaTime;
        bug.transform.position = Vector2.MoveTowards(bug.transform.position, player.transform.position, step);
    }
}
