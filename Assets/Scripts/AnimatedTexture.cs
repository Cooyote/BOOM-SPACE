using UnityEngine;
using System.Collections;

public class AnimatedTexture : MonoBehaviour 
{
	public Vector2 speed = Vector2.zero;
	private Vector2 offSet = Vector2.zero;

	Material material;

	// Use this for initialization
	void Start () 
	{
		material =GetComponent<Renderer>().material;
		offSet = material.GetTextureOffset("_MainTex");
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		offSet += speed * Time.deltaTime;
		material.SetTextureOffset("_MainTex",offSet);
	}
}
