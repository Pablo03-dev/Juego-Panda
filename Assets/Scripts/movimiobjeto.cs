using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiobjeto : MonoBehaviour
{
    public float velocidad;
    //public float inputX;
    //public float inputY;

    public Vector2 direccion;
    public float limiteIz;
    public float limiteDe;
    public float limiteAr;
    public float limiteAb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   

    private void Update()
    {
       direccion.x = Input.GetAxisRaw("Horizontal");
       direccion.y = Input.GetAxisRaw("Vertical");

        transform.Translate(direccion.normalized * velocidad * Time.deltaTime);


        Vector2 posicionCorregida = transform.position;

        posicionCorregida.x = Mathf.Clamp(posicionCorregida.x, limiteIz, limiteDe);
        posicionCorregida.y = Mathf.Clamp(posicionCorregida.y, limiteAb, limiteAr);

        transform.position = posicionCorregida;
    }
}
