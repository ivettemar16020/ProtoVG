using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Poptext : MonoBehaviour {
	public Text myText; 

	//OnStart
	void Start () {
		Invoke("DisableText", 5f);//invoke after 5 seconds
	}
	
	void DisableText()
	{
		myText.enabled = false; 
	}
}
