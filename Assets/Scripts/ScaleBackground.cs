using UnityEngine;
using System.Collections;

public class ScaleBackground : MonoBehaviour 
{
	public Vector2 textureSize = new Vector2 (1f,1f); 

	public bool Vertical;	// escala na vertical
	public bool Horizontal; // escala na horizontal


	void Start () 
	{
		// arredondar para cima para evitar buracos.
		float newHeight = Vertical ? Mathf.Ceil(Screen.height/textureSize.y * PixelPerfectCamera.scale) : 1; 
		float newWidth = Horizontal ? Mathf.Ceil(Screen.width/textureSize.x * PixelPerfectCamera.scale): 1;

		transform.localScale =new Vector3 (newWidth * textureSize.x ,newHeight * textureSize.y,1f);

		GetComponent<Renderer>().material.mainTextureScale = new Vector3(newWidth,newHeight,1);

	}
}
