using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModifyHP : MonoBehaviour
{
	public bool destroyWhenActivated = false;
	public int healthChange = -1;

	public HPSystem hp;

    private void Start()
    {
		hp = GameObject.Find("PLayer").GetComponent<HPSystem>();
    }

    private void OnCollisionEnter2D(Collision2D collisionData)
	{
		OnTriggerEnter2D(collisionData.collider);
	}

	//private void OnTriggerEnter2D(Collider2D colliderData)
	//{
	//	HPSystem healthScript = colliderData.gameObject.GetComponent<HPSystem>();
	//	if (healthScript != null)
	//	{
	//		healthScript.ModifyHealth(healthChange);

	//		if (destroyWhenActivated)
	//		{
	//			Destroy(this.gameObject);
	//		}
	//	}
	//}

	private void OnTriggerEnter2D(Collider2D colliderData)
	{
		//HPSystem healthScript = colliderData.gameObject.GetComponent<HPSystem>();
		//if (healthScript != null)
		//{
			//Estudiante est = colliderData.GetComponent<Estudiante>();
			//if (est != null)
   //         {
			//	if (est.tieneNota == false)
   //             {
			//		hp.ModifyHealth(healthChange);

			//		if (destroyWhenActivated)
			//		{
			//			Destroy(this.gameObject);
			//		}
			//	}
   //         }
		//}
	}
}
