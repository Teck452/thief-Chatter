using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public sound[] sounds;

    void Awake()
    {
        foreach (sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;

            s.source.spatialBlend = s.spatialBlend;
        }
    }

void Start()
    {
        Play("Line1");
    }

    public void Play (string name)
    {
        sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Play();
    }
}
