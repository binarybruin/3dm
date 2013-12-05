using UnityEngine;
using System.Collections;

public class play_sound : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision box) {

		if (!box.gameObject.audio.isPlaying)
			box.gameObject.audio.Play();
	
	}
}
