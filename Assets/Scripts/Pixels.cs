using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Pixels : MonoBehaviour  {
	// Use this for initialization
	WebCamTexture webcamTexture;
	AudioSource audio;

	public int requestedWidth = 640;
	public int requestedHeight = 480;



	void Start () {
		audio = GetComponent<AudioSource>();
		WebCamDevice[] devices = WebCamTexture.devices;
		for (var i = 0; i < devices.Length; i++) {
			Debug.Log (devices [i].name);
		}
		if (devices.Length > 0) {
			webcamTexture = new WebCamTexture(devices[0].name, requestedWidth, requestedHeight);
			webcamTexture.Play();
		}	
	
	}
	
	// Update is called once per frame
	void Update () {
		Color[] pixels = webcamTexture.GetPixels();
		var grayscale = pixels[200].grayscale;
		audio.pitch = grayscale * 3;
	
	}
}
