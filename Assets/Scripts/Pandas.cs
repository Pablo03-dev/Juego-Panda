using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pandas : MonoBehaviour
{
    public float speed;
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
            GameManager.manager.AddScore(10);
            Destroy(gameObject);
        }
    }
}
