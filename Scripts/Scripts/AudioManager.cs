using UnityEngine.Audio;
using UnityEngine;
using System;
using UnityEngine.UI;
public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;

    public Timer timer;
    // Start is called before the first frame update
    void Awake()
    {
         foreach (Sound s in sounds)
        {

            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
        }
    }

    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Play();
    }
}
