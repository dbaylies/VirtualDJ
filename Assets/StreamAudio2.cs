using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StreamAudio2 : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        // See StreamAudio1.cs for some useful comments
        var audio = GetComponent<AudioSource>();
        audio.clip = Microphone.Start(deviceName: Microphone.devices[1], loop: true, lengthSec: 5, frequency: 44100);
        audio.loop = true;
        while (!(Microphone.GetPosition(Microphone.devices[1]) > 0)) { }
        audio.Play();
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
