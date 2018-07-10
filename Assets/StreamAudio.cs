using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StreamAudio : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
        foreach (string device in Microphone.devices)
        {
            Debug.Log("Name: " + device);
        }
        
        
        var audio = GetComponent<AudioSource>();
        // Perhaps change deviceName argument to be other inputs
        // Call Start() multiple times?
        // audio.clip = Microphone.Start("Microphone Array (Realtek High Definition Audio(SST))", true, 10, 44100);
        audio.clip = Microphone.Start("Focusrite USB (2- Focusrite USB Audio)", true, 10, 44100);
        audio.loop = true;
        // sets latency of recording
        // audio source will only begin playing after 0 samples have been recorded
        while (!(Microphone.GetPosition("Focusrite USB (2- Focusrite USB Audio)") > 0)) { }
        audio.Play();

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
