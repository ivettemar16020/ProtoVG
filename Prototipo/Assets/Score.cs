using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Score : MonoBehaviour {

	// Instanciar los objetos

	public static Score instance;
	public Text txtVidas; // txt de las vidas
	public static int vidas = 10; //vidas

	// Use this for initialization
	void Start () {
		instance = this;
 		txtVidas.text = "Vidas: "+ Score.vidas; //cambia el texto de las vidas
	}


	// contador de los puntos del player 2
	public void VidasCount()
	{
		vidas = vidas - 1;
		txtVidas.text = "Vidas: " + Score.vidas; //cambia el texto del player 2
		if (vidas == 0) {
			SceneManager.LoadScene(1);
			Score.vidas = 3; // reinicia las vidas
		}
	}
}