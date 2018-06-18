using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chao_caindo : MonoBehaviour {

	public float tempoReal;
	public float tempo;
	public int plataformas;
	public bool gatilho = true;
	public float tempoAtivação = 2.5f;

	void Start () {
		Debug.Log (plataformas = transform.childCount);

		
	}
	
	// Update is called once per frame
	void Update () {
		tempoReal = Time.time;
		tempo += Time.deltaTime;
		if (tempo > tempoAtivação) {
			destruirPlataforma ();
			tempo = 0;
		}


	}


	void destruirPlataforma(){
		transform.GetChild(Random.Range(0,12)).gameObject.SetActive(false);
	}

}
