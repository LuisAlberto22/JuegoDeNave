using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Contador : MonoBehaviour
{
	public int cont { get; private set; }

	public Action<int> CambioContador;

	public Vida player;

	void Start()
	{
		player.Muerte += ()
		   => {
			   enabled = false;
		   };
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("vida"))
		{
			cont++;
			CambioContador(cont);
			player.Curar();
			other.GetComponent<AudioSource>().Play();
			other.enabled = false;
			other.GetComponent<MeshRenderer>().enabled = false;
			Destroy(other.gameObject,2f);
		}	
	}
}
