using UnityEngine;
using System.Collections;

public class AccelReverb : MonoBehaviour {
	AudioSource audio;
    AudioReverbFilter reverb;
    public int reverbFactor;

    void Start() {
        reverb = GetComponent<AudioReverbFilter>();
	}

    void Update() {
       
        Debug.Log(Input.acceleration.y);
        Debug.Log(Input.acceleration.x);

        reverb.dryLevel = Input.acceleration.y * -1000;

    }
}