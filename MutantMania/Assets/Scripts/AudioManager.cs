using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {

    public static bool playSquish;
    public static bool playEnemySquish;
    public static bool playJump;
    public static bool playCoin;
    public static bool playBarrel;
    public static bool playHurt;
    public static bool playDeath;
    public static bool playMana;
    public static bool playHealth;
    public static bool playSword;

    AudioSource audioSource;
    public AudioClip squish;
    public AudioClip enemySquish;
    public AudioClip jump1;
    public AudioClip coin;
    public AudioClip barrel;
    public AudioClip playerHurt;
    public AudioClip playerDeath;
    public AudioClip manaPickup;
    public AudioClip healthPickup;
    public AudioClip swordSwing;
    public AudioClip swordSwing2;
    public AudioClip swordSwing3;

    void Start ()
    {
        audioSource = GetComponent<AudioSource>();
        //playSquish = false;
	}
	
	void Update ()
    {
        int r = Random.Range(0, 3);

        if (playSquish)
        {
            audioSource.PlayOneShot(squish, .7f);
            playSquish = false;
        }

        if (playEnemySquish)
        {
            audioSource.PlayOneShot(enemySquish, .7f);
            playEnemySquish = false;
        }

        if (playJump)
        {
            audioSource.PlayOneShot(jump1, .7f);
            playJump = false;
        }

        if (playCoin)
        {
            audioSource.PlayOneShot(coin, .7f);
            playCoin = false;
        }

        if (playBarrel)
        {
            audioSource.PlayOneShot(barrel, .3f);
            playBarrel = false;
        }

        if (playHurt)
        {
            audioSource.PlayOneShot(playerHurt, .7f);
            playHurt = false;
        }

        if (playDeath)
        {
            audioSource.PlayOneShot(playerDeath, .7f);
            playDeath = false;
        }

        if (playMana)
        {
            audioSource.PlayOneShot(manaPickup, .7f);
            playMana = false;
        }

        if (playHealth)
        {
            audioSource.PlayOneShot(healthPickup, .7f);
            playHealth = false;
        }

        if (playSword)
        {
            if(r == 0)
            {
                audioSource.PlayOneShot(swordSwing, .7f);
                playSword = false;
            }
            if (r == 1)
            {
                audioSource.PlayOneShot(swordSwing2, .7f);
                playSword = false;
            }
            if (r == 2)
            {
                audioSource.PlayOneShot(swordSwing3, .7f);
                playSword = false;
            }
        }
    }
}
