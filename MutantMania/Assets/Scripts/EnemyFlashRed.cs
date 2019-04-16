using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFlashRed : MonoBehaviour
{
    Color color;
    Material mmaterial;

    void Start()
    {
        mmaterial = GetComponent<Renderer>().material;

        Renderer rend = GetComponent<Renderer>();

        //rend.material.color = color;
        color = rend.material.color;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Sword")) //&& Input.GetKey(KeyCode.Mouse0)) //&& CharacterAnim.attack)
        {
            mmaterial.color = Color.red;
            //Debug.Log("enemyflash");
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
