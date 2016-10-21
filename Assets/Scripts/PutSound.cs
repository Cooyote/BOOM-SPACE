using UnityEngine;
using System.Collections;

public class PutSound : MonoBehaviour 
{
	public AudioSource[] audioSource;
	public AudioClip[] clips;
	private AudioClip currentClip;

	void PutClip(int posC)
	{
		currentClip = clips[posC];
	}

	void PlayClip(int posA)
	{
		audioSource[posA].clip = currentClip;
		audioSource[posA].Play();
	}

	void StopClip(int posA)
	{
		audioSource[posA].Stop();
	}
}
