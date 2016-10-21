using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour 
{
	private GameObject version;
	private GameObject rank;
	private GameObject buttonRight;
	private GameObject buttonLeft;
	private GameObject Ship;

	void Awake()
	{
		version = GameObject.FindGameObjectWithTag("Version");
		rank = GameObject.FindGameObjectWithTag("Rank");
		buttonRight = GameObject.FindGameObjectWithTag("ButtonRight");
		buttonLeft = GameObject.FindGameObjectWithTag("ButtonLeft");
		Ship = GameObject.FindGameObjectWithTag("Ship");
	}

	void Start () 
	{
		version.SetActive(false);
		rank.SetActive(false);
		buttonRight.SetActive(false);
		buttonLeft.SetActive(false);
		Ship.SetActive(false);

		StartCoroutine(StartGame());
	}

	IEnumerator StartGame()
	{
		yield return new WaitForSeconds (1f);
		Ship.SetActive(true);
		yield return new WaitForSeconds (2.8f);
		buttonRight.SetActive(true);
		buttonLeft.SetActive(true);
		yield return new WaitForSeconds (3.2f);
		version.SetActive(true);
		yield return new WaitForSeconds (2f);
		rank.SetActive(true);
	}
}
