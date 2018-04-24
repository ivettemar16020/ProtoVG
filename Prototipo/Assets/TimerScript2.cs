using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript2 : MonoBehaviour {

	float timer = 100f;
	public Text countdownText;

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
}
