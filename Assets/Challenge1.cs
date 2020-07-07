using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Challenge1 : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		int[] array = {2,3,5,7,11};

		//正順表示
		for (int i = 0; i < 5; i++) 
		{
			Debug.Log(array[i]);
		}//End of for

		//逆順表示
		for (int i = 4; i >= 0; i--) 
		{
			Debug.Log(array[i]);
		} //End of for
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
