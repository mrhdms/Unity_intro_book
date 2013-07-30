using UnityEngine;
using System.Collections;

public class Trap : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter ( Collider other ) {
		Debug.Log(other.gameObject.tag);
		if (other.gameObject.tag == "Ball") {
			GameObject respawn = GameObject.FindWithTag("Respawn");
			other.gameObject.transform.position = respawn.transform.position;
		}
	}
}
