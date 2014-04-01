using UnityEngine;
using System.Collections;

public class PlaySound : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnMouseEnter() {
		if (!this.gameObject.audio.isPlaying)
			this.gameObject.audio.Play();
		renderer.material.color -= new Color(0.1F, 0, 0);
	}

	void OnMouseExit() {
		if (this.gameObject.audio.isPlaying)
				this.gameObject.audio.Stop ();
		renderer.material.color += new Color (0.1F, 0, 0);
	}

}
