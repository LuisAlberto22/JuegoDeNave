using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasController : MonoBehaviour
{
	public Text Marcador;

	public Text ContVida;

	public LevelMananger levelMananger;

	public Text level;

	public Slider Slider;

	public Image Image;

	public GameObject panel;

	public Vida player;

	public Contador contador;

	public Color[] Color;


	void Start()
	{
		player.CambioVida += SetVida;
		player.CambioVida += BarraDeVida;
		player.Muerte += Muerte;
		contador.CambioContador += SetMarcador;
	}

	public void SetMarcador(int Marcador)
	{
		this.Marcador.text = string.Format($"{Marcador}/"+levelMananger.totalCapsulas);
	}

	void SetVida(float vida)
	{
		ContVida.text = string.Format($"{vida}%");
		Slider.value = vida;
	}

	public void setLevel(int nivel)
	{
		level.text += nivel;
	}

	void BarraDeVida(float vida)
	{
		if (vida > 60f)
		{
			ContVida.color = Color[0];
			Image.color = Color[0];
		}
		else if (vida > 30f)
		{
			ContVida.color = Color[1];
			Image.color = Color[1];
		}
		else
		{
			ContVida.color = Color[2];
			Image.color = Color[2];
		}
	}
	public void win()
	{
		panel.SetActive(true);
	}
	void Muerte()
	{
		panel.SetActive(true);
	}
}
