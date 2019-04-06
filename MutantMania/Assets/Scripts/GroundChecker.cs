using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour {

    //public GameObject landfx;
    //public GameObject jumpSpawn;

    private void OnTriggerEnter2D(Collider2D other)
    {
        PlayerController.onGround = true;
        //Instantiate(landfx, jumpSpawn.transform.position, jumpSpawn.transform.rotation);
    }
}
