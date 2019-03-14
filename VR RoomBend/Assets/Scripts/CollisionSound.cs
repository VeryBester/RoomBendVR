using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class CollisionSound : MonoBehaviour
    {
        private MasterAudioSource control;
        private bool firstHit = false;
        private void Start() {
            GameObject temp = GameObject.FindWithTag("MasterAudio");
            control = temp.GetComponent<MasterAudioSource>();
            if(control == null){
                Debug.Log("Not working");
            }
            else{
                Debug.Log("Working");
            }
        }
        private void OnCollisionEnter(Collision other) {
            /*
            Will use to implement material interaction/pitch
             */
            if(firstHit){
                GameObject hitObject = other.gameObject;
                ScriptMaterial otherMat = hitObject.GetComponent<ScriptMaterial>();
                ScriptMaterial thisMat = this.GetComponent<ScriptMaterial>();
                if(hitObject.tag != "Reset" && otherMat != null){
                    //Do reset
                    control.makeChange(thisMat.soundName, true);
                }

                
                // Make else to reset if
                AudioSource audioSource = this.gameObject.GetComponent<AudioSource>(); 
                audioSource.clip = this.gameObject.GetComponent<ScriptMaterial>().sound;
                if(audioSource != null){
                    Debug.Log("Playing");
                    Debug.Log(this.gameObject.name);

                    audioSource.Play(0);
                }   
            }
        }

        private void OnCollisionExit(Collision other) {
            firstHit = true;
        }

    }    
}

