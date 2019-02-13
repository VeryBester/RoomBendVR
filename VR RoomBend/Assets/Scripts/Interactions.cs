using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class Interactions : MonoBehaviour
    {
        private void OnCollisionEnter(Collision other) {
            /*
            Will use to implement material interaction/pitch
             */

            GameObject hitObject = other.gameObject;
            ScriptMaterial otherMat = hitObject.GetComponent<ScriptMaterial>();
            if(otherMat != null){
                Debug.Log(otherMat.name);
                Debug.Log(otherMat.hardness);
            }

            AudioSource audioSource = this.gameObject.GetComponent<AudioSource>(); 
            audioSource.clip = this.gameObject.GetComponent<ScriptMaterial>().sound;
            if(audioSource != null){
                audioSource.Play(0);
            }
        }


    }    
}

