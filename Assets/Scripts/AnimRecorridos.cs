using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimRecorridos : MonoBehaviour
{
    public Animator anima;

    private void Start()
    {
        int random = Random.Range(0, 4);
        if(random == 0)
        {
            anima.Play("Recorrido1");
            Audiomanager.PlaySound("PandaPasto");
        }

        if (random == 1)
        {
            anima.Play("Recorrido2");
            Audiomanager.PlaySound("PandaPasto");
        }

        if (random == 2)
        {
            anima.Play("Recorrido3");
            Audiomanager.PlaySound("PandaPasto");
        }

        if (random == 3)
        {
            anima.Play("Recorrido4");
            Audiomanager.PlaySound("PandaPasto");
        }

    }
}
