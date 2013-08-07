using UnityEngine;
using System.Collections;

public class Box : MonoBehaviour {
	
	public GameObject explosionPrefab;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void ApplyDamage() {
		Instantiate(explosionPrefab, transform.position, transform.rotation);
		Destroy(gameObject);
	}
}
