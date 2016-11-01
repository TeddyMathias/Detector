using UnityEngine;
using System.Collections;

public class AccelPitch : MonoBehaviour {
	AudioSource audio;
    public float speed = 10.0F;

    void Start() {
		audio = GetComponent<AudioSource>();
	}

    void Update() {
        Vector3 dir = Vector3.zero;
       
        dir.x = -Input.acceleration.y;
        dir.z = Input.acceleration.x;
        if (dir.sqrMagnitude > 1)
            dir.Normalize();
        
        dir *= Time.deltaTime;
        transform.Translate(dir * speed);
        
        audio.pitch = Input.acceleration.y * 3;
    }
}