using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class pontuacao : MonoBehaviour {
	public static int pontos;
	public Text pontosTXT;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		pontosTXT.text = pontos.ToString ();
	
	}
}
