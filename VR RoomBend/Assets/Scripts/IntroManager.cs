using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class IntroManager : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public VideoClip clip;
    // Start is called before the first frame update
    double length;
    float timepass;
    void Start()
    {
        length = clip.length;
        timepass = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        timepass += Time.deltaTime;
        if(timepass > length){
            Debug.Log("working");
            SceneManager.LoadScene("Main", LoadSceneMode.Single);    
        }
    }
}
