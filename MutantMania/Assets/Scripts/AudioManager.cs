using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {

    public static bool playSquish;
    public static bool playEnemySquish;
    public static bool playEnemyHit;
    public static bool playJump;
    public static bool playCoin;
    public static bool playBarrel;
    public static bool playHurt;
    public static bool playDeath;
    public static bool playMana;
    public static bool playHealth;
    public static bool playSword;
    public static bool playWand;
    public static bool playPillar;

    AudioSource audioSource;
    public AudioClip bgm;
    public AudioClip squish;
    public AudioClip enemySquish;
    public AudioClip enemyHit;
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
    public AudioClip wand;
    public AudioClip pillar;

    void Start ()
    {
        //DontDestroyOnLoad(gameObject);

        audioSource = GetComponent<AudioSource>();
        //playSquish = false;

        audioSource.PlayOneShot(bgm, .18f);
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

        if (playEnemyHit)
        {
            audioSource.PlayOneShot(enemyHit, .7f);
            playEnemyHit = false;
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

        if (playWand)
        {
            audioSource.PlayOneShot(wand, .5f);
            playWand = false;
        }

        if (playPillar)
        {
            audioSource.PlayOneShot(pillar, .5f);
            playPillar = false;
        }
    }
}
