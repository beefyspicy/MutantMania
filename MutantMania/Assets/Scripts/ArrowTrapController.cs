using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowTrapController : MonoBehaviour {

    public float timer;
    public float force;

    public GameObject arrow;
    public GameObject projectileSpawn;

    IEnumerator ShootArrow()
    {
        GameObject arrows = Instantiate(arrow, projectileSpawn.transform.position, projectileSpawn.transform.rotation);
        Rigidbody2D rb = arrows.GetComponent<Rigidbody2D>();
        rb.AddForce(transform.right * force, ForceMode2D.Impulse);
        //rb.AddForce(transform.up * (force * .04f), ForceMode2D.Impulse);

        yield return new WaitForSeconds(timer);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(ShootArrow());
        }
    }
}
