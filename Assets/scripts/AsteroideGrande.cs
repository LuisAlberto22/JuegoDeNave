using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroideGrande : Asteroide
{
	protected override void destroyed()
	{
        var diferencia = new Vector3(.05f, 0, 0.05f);

        for (int i = 0; i < 3; i++)
		{
            Instantiate(game, transform.position+diferencia, transform.rotation);
            diferencia *= 4;
        }
        Destroy(gameObject, 2f);
    }

	// Start is called before the first frame update
	void Start()
    {
        Rigidbody = GetComponent<Rigidbody>();
        Audio = GetComponent<AudioSource>();
        Velocidad = 3;
        daño = 30;
        vida = 6;
        aplicarVelocidad();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
