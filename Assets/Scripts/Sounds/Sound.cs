//Thanks to https://twitter.com/TheSarahChimera for the Script!
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : ScriptableObject
{
{
    [Header("Clip and Output")]
    public AudioClip clip = null;
    public AudioMixerGroup output = null;
    public bool loop = false;
    public bool playOnAwake = false;
 
    [Header("Volume and Pitch")]
    [Range(0f, 1f)]
    public float volume = 0.5f;
    [Range(-3f, 3f)]
    public float pitch = 1f;
 
    public float pitchMin;
    public float pitchMax;
 
    [Header("3D Sound")]
    [Range(0, 1f)]
    public float spatialBlend = 1f;
 
    public AudioRolloffMode audioMode;
    public float maxRange = 3000f;
}
}
