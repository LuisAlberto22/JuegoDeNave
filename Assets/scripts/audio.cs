using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio : MonoBehaviour
{
    AudioSource AudioSource;
    void Start()
    {
        AudioSource = GetComponent<AudioSource>();
    }

	private void OnDestroy()
	{
        AudioSource.Play();
	}
}
