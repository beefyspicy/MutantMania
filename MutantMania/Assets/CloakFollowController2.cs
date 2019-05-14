using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloakFollowController2 : MonoBehaviour {

    public GameObject hitBox;
    public GameObject bloodfx;

    private Vector3 offset;

    void Start()
    {
        offset = transform.position - hitBox.transform.position;
    }

    void LateUpdate()
    {
        transform.position = hitBox.transform.position + offset;

        if (CloakHealthController2.health < 1)
        {
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Sword") && CharacterAnim.attack == true)
        {
            CloakHealthController2.health -= 1;
            Debug.Log(CloakHealthController2.health);

            AudioManager.playEnemyHit = true;

            Instantiate(bloodfx, transform.position, transform.rotation);
            ScreenShake.shake = true;
            Debug.Log("shake = true");

            //health -= 1;
            CharacterAnim.attack = false;
        }
    }
}
