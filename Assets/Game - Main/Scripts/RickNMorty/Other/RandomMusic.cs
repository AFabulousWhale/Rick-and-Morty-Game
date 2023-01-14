using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMusic : MonoBehaviour
{
    public AudioClip[] Music;
    public AudioSource _AS;

    void Awake()
    {
        _AS = GetComponent<AudioSource>();
        _AS.volume = 0.5f;

        GameMusic();
    }

    void Update()
    {
        if(!_AS.isPlaying)
        {
            GameMusic();
        }
    }

    public void GameMusic()
    {
            _AS.clip = Music[Random.Range(0, Music.Length)];
            _AS.PlayOneShot(_AS.clip);
    }
}
