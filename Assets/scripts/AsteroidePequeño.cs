using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidePequeño : Asteroide
{
    public AudioClip AudioClip;
	protected override void destroyed()
	{
        Instantiate(game,transform.position,transform.rotation);
        Audio.clip = AudioClip;
        Audio.Play();
        Destroy(gameObject,2f);
	}

	void Start()
    {
        Rigidbody = GetComponent<Rigidbody>();
        Audio = GetComponent<AudioSource>();
        daño = 10;
        Velocidad = 10;
        vida = 1;
        aplicarVelocidad();
    }
}
