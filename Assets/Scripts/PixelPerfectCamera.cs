using UnityEngine;
using System.Collections;

public class PixelPerfectCamera : MonoBehaviour 
{
	public  static float pixelToUnits = 1f;
	public  static float scale = 1f;

	public float TopScreen = (Screen.height/2);
	public float BottomScreen = -(Screen.height/2);

	public static Vector2 nativeResolution = new Vector2 (960,640); 
	// Use this for initialization
	void Start () 
	{
		pixelToUnits = 1f;
		scale = 1f;
		Camera camera = GetComponent<Camera>();

		if(camera.orthographic) // certificar que a camera é ortografica
		{
			//identifica qual a escala em relação a resolução nativa
			scale = (Screen.height / nativeResolution.y);
			pixelToUnits *= scale;

			//altera a distancia da camera
			camera.orthographicSize = ((Screen.height/2) / pixelToUnits);
		}
	}
}
