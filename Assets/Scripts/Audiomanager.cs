using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audiomanager : MonoBehaviour
{
    public static AudioClip FlippersSound;
    public static AudioClip PartidaSound;
    public static AudioClip ImpactObstacSound;
    public static AudioClip HuidaSound;
    public static AudioClip impactSound;
    public static AudioClip healSound;

    static AudioSource audioScr;
    // Start is called before the first frame update
    void Start()
    {
        FlippersSound = Resources.Load<AudioClip>("Flippers");
        PartidaSound = Resources.Load<AudioClip>("BolaInicia");
        ImpactObstacSound = Resources.Load<AudioClip>("ImpacObstac");
        HuidaSound = Resources.Load<AudioClip>("HuidaPanda");
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
            case "Flippers": audioScr.PlayOneShot(FlippersSound);
                break;

            case "BolaInicia":
                audioScr.PlayOneShot(PartidaSound);
                break;

            case "ImpacObstac":
                audioScr.PlayOneShot(ImpactObstacSound);
                break;

            case "HuidaPanda":
                audioScr.PlayOneShot(HuidaSound);
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
