using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShatterManager : MonoBehaviour
{
    public GameObject shatterObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
       Debug.Log("Collider Tag: "+other.collider.tag);
        if(other.collider.tag == "Floor")
        {
            shatterObject.SetActive(true);
            shatterObject.transform.parent = gameObject.transform.parent;
            gameObject.SetActive(false);
        }
    }
}
