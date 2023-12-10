using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LevelReset2 : MonoBehaviour
{
    public AudioClip fallSound;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if(transform.position.y < -1 && !audioSource.isPlaying)
            {
                audioSource.PlayOneShot(fallSound);   
            }

        if(transform.position.y < -80)   
        {
            SceneManager.LoadSceneAsync("Level_1");
        } 
    }
}
