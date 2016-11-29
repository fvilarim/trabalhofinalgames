using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class player : MonoBehaviour {

	private 	Rigidbody2D 	playerRb;
	private 	SpriteRenderer 	playerSprite;
	public 		float 			velocidade;
	public 		bool 			flipxBool;

	// Use this for initialization
	void Start () {
		playerRb = GetComponent<Rigidbody2D> ();
		playerSprite = GetComponent<SpriteRenderer> ();
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown (0)) {
			velocidade *= (-1);	
			flipxBool = !flipxBool;
			playerSprite.flipX = flipxBool;
		}

		playerRb.velocity = new Vector2 (velocidade, playerRb.velocity.y);
	
	}

	void OnCollisionEnter2D(Collision2D colisao){
		if (colisao.gameObject.tag == "espinho") {
			pontuacao.pontos = 0;
			SceneManager.LoadScene ("GameOver");
		}
	}

	void OnTriggerEnter2D (Collider2D colisao){
		if (colisao.gameObject.tag == "espinho") {
			pontuacao.pontos = 0;
			SceneManager.LoadScene ("GameOver");
		}
	}
}
