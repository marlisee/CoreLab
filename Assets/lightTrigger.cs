﻿using UnityEngine;
using System.Collections;

public class lightTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	void Update() {
		
	} 
		
	void OnTriggerEnter() {
		
		GetComponent<Light> ().enabled = true;
	}

	void OnTriggerExit() {
		GetComponent<Light> ().enabled = false; 
	}

	public class ExampleClass : MonoBehaviour {
		public Light lt;
		void Start() {
			lt = GetComponent<Light>();
		}
		void Update() {
			lt.color -= Color.white / 2.0F * Time.deltaTime;
		}
	}
}