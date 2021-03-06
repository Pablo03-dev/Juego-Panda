using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirXcontacto : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Piso final"))
        {
            //Instantiate(efectoExplosion, transform.position, Quaternion.identity);
            //GameManager.manager.AddScore(10);
            //Audiomanager.PlaySound("Panda");
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Obstaculos")
        {
            GameManager.manager.AddScore(5);
            Audiomanager.PlaySound("ImpactoObsta");
        }

        if (collision.gameObject.tag == "Muro")
        {
            //GameManager.manager.AddScore(5);
            Audiomanager.PlaySound("ImpacMuro");
        }
    }
}
