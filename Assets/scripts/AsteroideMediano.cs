using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroideMediano : Asteroide
{
	protected override void destroyed()
	{
        var diferencia = new Vector3(.03f,0,0.03f);
		for (int i = 0; i < 2; i++)
		{
          Instantiate(game, transform.position+diferencia, transform.rotation);
            diferencia *= 2;
		}
        Destroy(gameObject, 2f);
    }

	void Start()
    {
        Rigidbody = GetComponent<Rigidbody>();
        Audio = GetComponent<AudioSource>();
        Velocidad = 5;
        daño = 20;
        vida = 4;
        aplicarVelocidad();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
