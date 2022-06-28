using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{

    public GameObject powerup;
    public float tiempoDuracion;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, tiempoDuracion);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bola"))
        {
            Instantiate(powerup, transform.position, Quaternion.identity);
            //GameManager.manager.AddScore(10);
            //Audiomanager.PlaySound("Panda");
            Destroy(gameObject);
        }
    }
}
