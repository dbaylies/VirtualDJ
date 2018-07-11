using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Uses the Microphone class to read audio into an AudioSource's clip from an external audio source, while simultaneously playing back the
/// audio clip. This takes input from two external sources and plays them back through two AudioSources.
/// To have 3D spatial blend, you MUST start the scene with completely 2D spatial blend, then change the slider to 3D AFTER the scene has started.
/// Not sure why this is, it's likely a bug.
/// 
/// There are also occasionally audio glitches, as well as a persitent reverberation whose sources I cannot locate.
/// 
/// -David B.
/// </summary>


public class StreamAudio1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        // Check the console to see which devices Unity is recognizing
        foreach (string device in Microphone.devices)
        {
            Debug.Log("Name: " + device);
        }
        

        var audio = GetComponent<AudioSource>();
        // Change the index of Microphone.devices[0] to choose the input device for this audio source
        audio.clip = Microphone.Start(deviceName: Microphone.devices[0], loop: true, lengthSec: 5, frequency: 44100);
        audio.loop = true;
        // Change it here too
        while (!(Microphone.GetPosition(Microphone.devices[0]) > 0)) { }
        audio.Play();

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
