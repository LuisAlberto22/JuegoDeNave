using System.Collections;
using System.Collections.Generic;
using Scene = UnityEngine.SceneManagement;
using UnityEngine;

public class LevelMananger : MonoBehaviour
{
    public int totalCapsulas { get; private set; }

    public CanvasController canvasController;

    public Contador contador;

    void Start()
    {
        contador.CambioContador += win;
        var nivel = Scene.SceneManager.GetActiveScene().buildIndex;
		switch (nivel)
		{
            case 1:
                totalCapsulas = 7;
                break;
            case 2:
                totalCapsulas = 14;
                break;
            case 3:
                totalCapsulas = 21;
                break;
		}
        canvasController.SetMarcador(0);
        canvasController.setLevel(nivel);
    }
    void win(int capsulas)
	{
		if (totalCapsulas <= capsulas)
		{
            canvasController.win();
		}
	}
}
