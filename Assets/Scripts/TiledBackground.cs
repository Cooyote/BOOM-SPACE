using UnityEngine;
using System.Collections;

public class TiledBackground : MonoBehaviour 
{
	public Vector2 textureSize = new Vector2 (1,1);

	public bool scaleHorizontal = false;
	public bool scaleVertical = false;

	void Start()
	{
		var newWidth = scaleHorizontal ? Mathf.Ceil(Screen.width/(textureSize.x * PixelPerfectCamera.scale)) : 1;
		var newHeidth = scaleVertical ?  Mathf.Ceil(Screen.width/(textureSize.y * PixelPerfectCamera.scale)) : 1;

		transform.localScale = new Vector3 (newWidth * textureSize.x, newHeidth * textureSize.y,1);

		GetComponent<Renderer>().material.mainTextureScale = new Vector3(newWidth,newHeidth,1);
	}
}
