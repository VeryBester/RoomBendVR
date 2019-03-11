using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterAudioSource : MonoBehaviour
{
    public List<AudioClip> clips = new List<AudioClip>();
    public List<AudioSource> sources = new List<AudioSource>();
    
    void Start()
    {   
        // Guarentees that #clips == #audiosources
        if(clips.Count != sources.Count){
            throw new System.IndexOutOfRangeException("clip size != sources size");
        }

        // Sets the clips and starts/loops them
        // Initial Volume is 0
        for(int i = 0; i < clips.Count; i++){
            AudioClip clip = clips[i];
            AudioSource source = sources[i];
            source.clip = clip;
            source.loop = true;
            source.volume = 0f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //TODO : Slowly add in sounds

    }

    //TODO : find way to store/get what objects are suppose to be playing in game

}
