using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class espinho : MonoBehaviour {
	private		Rigidbody2D 	espinho2D;
	private		int 			atrito;
	public 		int 			atritoMaximo, atritoMinimo;
	public 		Vector3			posicao;
	public		GameObject 		espinhoPrefab;
	// Use this for initialization
	void Start () {
		espinho2D = GetComponent<Rigidbody2D> ();
		atrito = Random.Range (atritoMinimo, atritoMaximo);
		espinho2D.drag = atrito;

		posicao = transform.position;
	
	}
	
	// Update is called once per frame
	void OnBecameInvisible () {
		Instantiate (espinhoPrefab, posicao, transform.localRotation);
		pontuacao.pontos += 1;
		Destroy (this.gameObject);

		if (pontuacao.pontos == 10) {
			SceneManager.LoadScene ("EntreFases");
		}
	}
}
