using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class joga : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			if (pontuacao.pontos >= 10){
				SceneManager.LoadScene ("Fase2");
			}else{
				SceneManager.LoadScene ("Fase1");
			}
		}

	}
}
