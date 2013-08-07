using UnityEngine;
using System.Collections;

public class BoxGenerator : MonoBehaviour {
	
	public float interval;
	public GameObject redBoxPrefab;
	public GameObject blueBoxPrefab;
	
	private bool nextIsRed;
	private float timer;

	// Use this for initialization
	void Start () {
		nextIsRed = true;
		timer = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		if ( timer < 0.0f ) {
			float offsx = Random.Range(-8.0f, 8.0f);
			float offsz = Random.Range(-4.0f, 4.0f);
			Vector3 position = transform.position + new Vector3( offsx, 0, offsz );
			GameObject prefab = nextIsRed ? redBoxPrefab : blueBoxPrefab;
			Instantiate( prefab, position, Random.rotation );
			
			timer = interval;
			nextIsRed = !nextIsRed;
		}
	}
}
