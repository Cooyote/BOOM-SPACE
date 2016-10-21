using UnityEngine;
using System.Collections;

public class PutRotate : MonoBehaviour 
{
	public float speedRotate;
	public bool activeRotate;

	void Update () 
	{
		if (activeRotate) 
		{
			transform.Rotate(new Vector3 (0,0,speedRotate));
		}
	}

	public void RotateTo(float value)
	{
		transform.eulerAngles = new Vector3(transform.eulerAngles.x,transform.eulerAngles.y,value);
	}
}
