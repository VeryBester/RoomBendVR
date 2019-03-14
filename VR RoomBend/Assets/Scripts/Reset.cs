using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class Reset : MonoBehaviour
    {
        
        private MasterAudioSource masterAudio;
        private void Awake() {
            GameObject temp = GameObject.FindWithTag("MasterAudio");
            masterAudio = temp.GetComponent<MasterAudioSource>();
        }
        private void OnCollisionEnter(Collision other) {
            //Debug.Log("Hitting");
            GameObject hitObject = other.gameObject;
            ScriptMaterial otherMat = hitObject.GetComponent<ScriptMaterial>();
            CollisionSound otherCS = hitObject.GetComponent<CollisionSound>();
            GameObject spawner = null;
            if(otherMat != null){
                spawner = otherMat.spawn;
                masterAudio.makeChange(otherMat.soundName, false);
            }
            if(spawner != null){
                otherCS.resetFirst();
                hitObject.transform.position = spawner.transform.position;

            }
        }   
    }
}