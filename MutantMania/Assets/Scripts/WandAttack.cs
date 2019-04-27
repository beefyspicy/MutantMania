using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WandAttack : MonoBehaviour {

    public float force;
    public static float mana;

    public GameObject wandProjectile;
    public GameObject projectileSpawn;

    private void Start()
    {
        mana = 10;
    }

    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Mouse2))
        {
            shootWand();
            Debug.Log(mana);
        }

        //mana += GameController.mana;
	}

    void shootWand()
    {
        GameObject magic = Instantiate(wandProjectile, projectileSpawn.transform.position, projectileSpawn.transform.rotation);
        Rigidbody2D rb = magic.GetComponent<Rigidbody2D>();
        rb.AddForce(transform.right * force, ForceMode2D.Impulse);
        rb.AddForce(transform.up * (force * .04f), ForceMode2D.Impulse);
        mana--;
    }
}
