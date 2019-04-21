using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageByContact : MonoBehaviour {

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            PlayerHealthController.health -= 1;
            Debug.Log(PlayerHealthController.health);
        }
    }
}
