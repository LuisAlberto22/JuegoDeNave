using System.Collections;
using System.Collections.Generic;
using Scene = UnityEngine.SceneManagement;
using UnityEngine;

public class SceneMananger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public void CargarEscena(int scene)
	{
        Scene.SceneManager.LoadScene(scene);
	}

}
