using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class Reset : MonoBehaviour
    {
        // Start is called before the first frame update
        public GameObject masterAudio;
        private void OnCollisionEnter(Collision other) {
            Debug.Log("Hitting");
            GameObject hitObject = other.gameObject;
            ScriptMaterial otherMat = hitObject.GetComponent<ScriptMaterial>();
            GameObject spawner = null;
            if(otherMat != null){
                //TODO: Send sound name to master audio
                //      Set otherMat's first to false;
                spawner = otherMat.spawn;
            }
            if(spawner != null){
                hitObject.transform.position = spawner.transform.position;
            }
        }   
    }
}