
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    public float speed;
    public float jumpForce;
    public float downForce;
    public float lowForce;

    public static float moveHorizontal;

    public GameObject jumpfx;
    public GameObject jumpSpawn;
    //public GameObject sword;

    public static bool onGround;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (rb.velocity.y < 0)
        {
            rb.AddForce(transform.up * downForce);
        }
        else if (rb.velocity.y > 0 && (!Input.GetKeyDown(KeyCode.Space) || !Input.GetKeyDown(KeyCode.Joystick1Button1)))
        {
            rb.AddForce(transform.up * lowForce);
        }

        //float 
        moveHorizontal = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(moveHorizontal * speed, rb.velocity.y);

        if (moveHorizontal < 0)
        {
            transform.rotation = Quaternion.Euler(0, -180, 0);
        }
        if (moveHorizontal > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }

    private void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Joystick1Button1)) && onGround == true)
        {
            onGround = false;

            rb.velocity = Vector2.up * jumpForce;

            var clone = jumpfx;

            Instantiate(clone, jumpSpawn.transform.position, jumpSpawn.transform.rotation);
            //Destroy(clone, 2f);
        }

        /*if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            sword.SetActive(true);
        }
        else
        {
            //StartCoroutine(Wait());
            sword.SetActive(false);
        }*/
    }

    /*IEnumerator Wait()
    {
        yield return new WaitForSeconds(4f);
    }*/
}