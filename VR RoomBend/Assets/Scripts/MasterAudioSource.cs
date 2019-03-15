using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MasterAudioSource : MonoBehaviour
{
    public ChalkboardManager chalkboard;
    public AudioSource win;

    class AudioBoolPair{
        public AudioBoolPair(AudioSource a){
            audioSource = a;
            isOn = false;
        }
        public AudioSource audioSource;
        public bool isOn;
    }
    private bool hasWon;
    Dictionary<string, AudioBoolPair> controller = new Dictionary<string, AudioBoolPair>();
    void Awake()
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
        hasWon = false;
        chalkboard.SetTotalSounds(controller.Count);
        chalkboard.UpdateGameMessage();
    }

    // Update is called once per frame
    public void makeChange(string tag,  bool change){
        AudioBoolPair curr = controller[tag];
        if(change){
            
            curr.audioSource.volume = 1f;

            int count = controller.Count(kv => kv.Value.isOn);

            if(count == controller.Count){
                chalkboard.ShowCustomMessage("\n\nYou WIN!!", "\n\nThank you\n\n for playing.");
                if(!hasWon){
                    win.Play(0);
                    hasWon = true;
                }
            }
            else{
                chalkboard.SetSoundsLocated(count);
                chalkboard.UpdateGameMessage();
            }
            

        }
        else
        {
            curr.audioSource.volume = 0f;
        }
        curr.isOn = change;
    }


}
