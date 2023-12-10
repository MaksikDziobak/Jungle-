using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enter : MonoBehaviour
{
    public AudioClip musicClip;
    private AudioSource musicSource;

    void Start()
    {
        musicSource = GetComponent<AudioSource>();
    }

    
    void Update()
    {
        if (transform.position.x > 45 && !musicSource.isPlaying)
        {
            // Włącz muzykę tylko jeśli nie jest już odtwarzana
            musicSource.PlayOneShot(musicClip);
        }

    }
}    
