using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    public GameObject bala;

    public Vida player;

    private float desfase = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
          player.Muerte += ()
              => {
                  enabled = false;
              };
    }

    void disparar()
	{
        var clon = Instantiate(bala, transform.position, transform.rotation);
        Destroy(clon, 2f);
    }
  
    // Update is called once per frame
    void Update()
    {
		if (Input.GetMouseButtonDown(0))
		{
			disparar();
		}

		if (ControlDisparo.Disparo)
		{
            desfase -= Time.deltaTime;
			if (desfase <= 0)
			{
                disparar();
                desfase = 0.1f;
			}
        }
    }
}
