using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class CollisionSound : MonoBehaviour
    {

        private void OnCollisionEnter(Collision other) {
            /*
            Will use to implement material interaction/pitch
             */

            GameObject hitObject = other.gameObject;
            ScriptMaterial otherMat = hitObject.GetComponent<ScriptMaterial>();
            if(hitObject.tag == "Reset"){

            }
            else if(otherMat != null){
                Debug.Log(otherMat.name);
            
            }

            AudioSource audioSource = this.gameObject.GetComponent<AudioSource>(); 
            audioSource.clip = this.gameObject.GetComponent<ScriptMaterial>().sound;
            if(audioSource != null){
                audioSource.Play(0);
            }
        }

        // Test combo   N + N = N, N + H = H, N + S = S, S + S = S, S + H = S, H + H = H
        private AudioClip getClip(ScriptMaterial other){
            return null;
        }

    }    
}

