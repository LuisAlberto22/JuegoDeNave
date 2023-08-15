using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arwing : MonoBehaviour
{
    // Start is called before the first frame update

    public float vel = 5f;
    public float giro = 150f;
    public Vida player;


    void Start()
	{
        player.Muerte += ()
            => {
                enabled = false;
            };
	}

	// Update is called once per frame
	void Update()
    {
        //Movimientos de la nave
		if (Input.GetKey(KeyCode.W))
		{
            transform.Translate(new Vector3(0,-vel,0)*Time.deltaTime);
		}

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0, vel, 0) * Time.deltaTime);
        }
        //girar la nave
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, 0, giro) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, 0, -giro) * Time.deltaTime);
        }
        ControlNaveVirtual();
    }

    void ControlNaveVirtual()
	{
		if (ControlVirtual.inputVector.z != 0)
		{
            transform.Translate(new Vector3
                (0, -ControlVirtual.inputVector.z * vel, 0)
                * Time.deltaTime);
        }

        if (ControlVirtual.inputVector.x != 0)
        {
            transform.Rotate(new Vector3
                (0,0, ControlVirtual.inputVector.x * giro)
                * Time.deltaTime);
        }
    }
}
