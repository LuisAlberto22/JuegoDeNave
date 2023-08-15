using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vida : MonoBehaviour
{
	public Action<float> CambioVida;

	public Action Muerte;

	AudioSource[] AudioSource;

    public float vida = 100f;

    public AudioClip[] vidaSound;

    void Start()
    {
        AudioSource = GetComponents<AudioSource>();
    }

	public void Curar()
	{
		vida = Mathf.Clamp(vida + 10, 0, 100);
		CambioVida(vida);
	}


    public void RecibirDaño(float Daño)
	{
        vida = Mathf.Clamp(vida - Daño, 0,100);
        AudioSource[0].Play();
        CambioVida(vida);
		if (vida == 0)
		{
		  this.enabled = false;
          Muerte();
		}
	}

    private void Audio(AudioClip clip)
	{
		if (AudioSource[1].clip != clip)
		{
		   AudioSource[1].clip = clip;
		   AudioSource[1].Play();
		}
	}
    // Update is called once per frame
    void Update()
    {
			if (vida < 50f && vida > 30f)
			{	
				Audio(vidaSound[2]);
			}
			else if (vida <= 30f && vida > 10)
			{
				Audio(vidaSound[1]);
			}
			else if(vida <= 10f && vida > 0)
			{
				Audio(vidaSound[0]);
			}
    }
}
