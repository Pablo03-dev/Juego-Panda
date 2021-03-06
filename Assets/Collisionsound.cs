using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisionsound : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.CompareTag("Obstaculos"))
    //    {
    //        GameManager.manager.AddScore(5);
    //        Audiomanager.PlaySound("Impac Obstac");
    //    }
    //}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Obstaculos")
        {
            GameManager.manager.AddScore(5);
            CinemachineMovimientoCamara.Instance.MoverCamara(2, 2, 0.2f);
            Audiomanager.PlaySound("ImpactoObsta");
        }

        if (collision.gameObject.tag == "Muro")
        {
            //GameManager.manager.AddScore(5);
            CinemachineMovimientoCamara.Instance.MoverCamara(1, 1, 0.1f);
            Audiomanager.PlaySound("ImpacMuro");
        }
    }
}
