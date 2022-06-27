using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audiomanager : MonoBehaviour
{
    public static AudioClip FireSound;
    public static AudioClip enemyDeathSound;
    public static AudioClip coinInsertSound;
    public static AudioClip powerupSound;
    public static AudioClip impactSound;
    public static AudioClip healSound;

    static AudioSource audioScr;
    // Start is called before the first frame update
    void Start()
    {
        FireSound = Resources.Load<AudioClip>("fire");
        enemyDeathSound = Resources.Load<AudioClip>("enemyDeath");
        coinInsertSound = Resources.Load<AudioClip>("Coinintro");
        powerupSound = Resources.Load<AudioClip>("Power up");
        impactSound = Resources.Load<AudioClip>("impacto");
        healSound = Resources.Load<AudioClip>("Powerup 2");

        audioScr = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound (string clip)
    {
        switch (clip)
        {
            case "fire": audioScr.PlayOneShot(FireSound);
                break;

            case "enemyDeath":
                audioScr.PlayOneShot(enemyDeathSound);
                break;

            case "Coinintro":
                audioScr.PlayOneShot(coinInsertSound);
                break;

            case "Power up":
                audioScr.PlayOneShot(powerupSound);
                break;

            case "impacto":
                audioScr.PlayOneShot(impactSound);
                break;

            case "Powerup 2":
                audioScr.PlayOneShot(healSound);
                break;
        }
    }
}
