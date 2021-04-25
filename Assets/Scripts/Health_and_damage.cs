using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health_and_damage : MonoBehaviour 
{
	public int vida = 100;
	public bool invencible = false;
	public float tiempo_invencible = 1f;
	public float tiempo_frenado = 0.2f;

/*	private void Start()
	{
		anim = GetComponent<Animator>();
	}
*/
	public void RestarVida(int cantidad)
	{
		if (!invencible && vida > 0)
		{
			vida -= cantidad;
			//anim.Play("Damage");
			StartCoroutine(Invulnerabilidad());
			StartCoroutine(FrenarVelocidad());
			if (vida == 0)
			{
				PuntoRestauracion();
			}
		}
	}

	void PuntoRestauracion()
	{
		Debug.Log("Se murio....");
		Time.timeScale = 0;
		Destroy(gameObject);
		//Invoke("IU_restauracion",3);
	}



	IEnumerator Invulnerabilidad()
	{
		invencible = true;
		yield return new WaitForSeconds(tiempo_invencible);
		invencible = false;
	}

	IEnumerator FrenarVelocidad()
	{
		var VelocidadActual = GetComponent<PlayerMovement>().speed;
		GetComponent<PlayerMovement>().speed = 0;
		yield return new WaitForSeconds(tiempo_frenado);
		GetComponent<PlayerMovement>().speed = VelocidadActual;
	}
}