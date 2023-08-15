using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Asteroide : MonoBehaviour
{
    protected int Velocidad, CoordX, CoordZ, vida ,daño;

    protected Rigidbody Rigidbody;

    public GameObject game;

    protected AudioSource Audio;

    protected abstract void destroyed();

    protected void aplicarVelocidad()
	{
        CoordX = Random.Range(0, 2);
        CoordZ = Random.Range(0, 2);
        if (CoordX == 0)
            CoordX = -1;
        if (CoordZ == 0)
            CoordZ = -1;
        Rigidbody.velocity = new Vector3(Velocidad * CoordX, 0, Velocidad * CoordZ) * Time.deltaTime;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("bala"))
        {
            Audio.Play();
            Destroy(collision.gameObject);
            vida--;
			if (vida <= 0)
			{
                Audio.Play();
                GetComponent<Collider>().enabled = false;
                GetComponent<MeshRenderer>().enabled = false;
                destroyed();
			}
        }
		if (collision.gameObject.CompareTag("Player"))
		{
            Vida v = collision.gameObject.GetComponent<Vida>();
            v.RecibirDaño(daño);
		}
    }
}
