using UnityEngine;
using System.Collections;

public class FlickerEffect : MonoBehaviour {
	
	private Color originalColor;

	// Use this for initialization
	void Start () {
		originalColor = renderer.material.color;
	}
	
	// Update is called once per frame
	void Update () {
		float level = Mathf.Abs(Mathf.Sin(Time.time * 20));
		renderer.material.color = originalColor * level;
	}
}
