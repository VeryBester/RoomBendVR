using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterAudioSource : MonoBehaviour
{
    class AudioBoolPair{
        public AudioBoolPair(AudioSource a){
            audioSource = a;
            isOn = false;
        }
        public AudioSource audioSource;
        public bool isOn;
    }
    
    //public List<AudioSource> sources = new List<AudioSource>();
    //public List<string> names = new List<string>();
    Dictionary<string, AudioBoolPair> controller = new Dictionary<string, AudioBoolPair>();
    void Start()
    {   
        // Sets the clips and starts/loops them
        // Initial Volume is 0
        foreach(Transform child in transform){
            GameObject curr = child.gameObject;
            string name = curr.name;
            AudioSource audio= curr.GetComponent<AudioSource>();
            audio.loop = true;
            audio.volume = 0f; 
            AudioBoolPair pair = new AudioBoolPair(audio);
            controller.Add(name, pair);
        }
    }

    // Update is called once per frame
    public void makeChange(string tag,  bool change){
        AudioBoolPair curr = controller[tag];
        if(change){
            
            curr.audioSource.volume = 1f;
        }
        else{
            curr.audioSource.volume = 0f;
        }
        curr.isOn = change;
    }

    //TODO : find way to store/get what objects are suppose to be playing in game

}
