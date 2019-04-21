using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashRed : MonoBehaviour {

    Color color;
    Material mmaterial;

    void Start ()
    {
        mmaterial = GetComponent<Renderer>().material;

        Renderer rend = GetComponent<Renderer>();

        //rend.material.color = color;
        color = rend.material.color;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("EnemySword") || collision.gameObject.CompareTag("Enemy"))
        {
            mmaterial.color = Color.red;
            //Debug.Log("flash");
            Invoke("ResetColor", 0.1f);
        }
    }

    /*IEnumerator Wait()
    {
        yield return WaitForSeconds(.5f);
    }*/

    void ResetColor()
    {
        mmaterial.color = color;
    }
}
