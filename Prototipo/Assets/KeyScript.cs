using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class KeyScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	void OnTriggerEnter(Collider other){
		if (other.tag == "Player"){
			//SceneManager.LoadScene(2);
			Application.LoadLevel("Won");
		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}
