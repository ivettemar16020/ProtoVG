using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript2 : MonoBehaviour {
   
	float timer = 100f;
	public Text countdownText;
    public GameObject conejo;

    // Use this for initialization
    void Start () {
    }  
    // Update is called once per frame
    void Update () {
    	//System.Math.Round(timer,2);
    	countdownText.text = ("Time Left:" + (int)timer);

 		timer -= Time.deltaTime;
  

 		if (timer <= 0){
 			countdownText.text = "Times Up!";
 			Application.LoadLevel("Lost");
 		}
    }

   //void OnCollisionEnter(Collision col)
    //{   
   //     Debug.Log("holi")
   //     Debug.Log("Detected collision between " + gameObject.name + " and " + col.collider.name);
//
   // }
    void OnTriggerEnter(Collider other){
        if (other.tag == "Trampa"){
            Debug.Log("holi");
            countdownText.text = ("woops");
        }

    }
}
