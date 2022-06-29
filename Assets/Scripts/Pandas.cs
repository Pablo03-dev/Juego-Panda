using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pandas : MonoBehaviour
{
    public float speed;
    [SerializeField] private GameObject efectoExplosion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Mover()
    {
        transform.Translate(transform.up * speed * Time.deltaTime, Space.World);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bola"))
        {
            Instantiate(efectoExplosion, transform.position, Quaternion.identity);
            GameManager.manager.AddScore(10);
            Audiomanager.PlaySound("Panda");
            Destroy(gameObject);
        }
        if (collision.CompareTag("BolaTwo"))
        {
            Instantiate(efectoExplosion, transform.position, Quaternion.identity);
            GameManager.manager.AddScore(13);
            Audiomanager.PlaySound("Panda");
            Destroy(gameObject);
        }
    }

}
