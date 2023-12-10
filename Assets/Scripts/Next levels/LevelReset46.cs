using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LevelReset46 : MonoBehaviour
{
    public AudioClip impact;

    private void Update()
    {

        if(transform.position.y < -80)   
        {
            SceneManager.LoadSceneAsync("Level_4");
        } 
    }
}
