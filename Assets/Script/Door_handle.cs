using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_handle : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("START DOOR");
	}
	
	// Update is called once per frame
	void Update () {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            GetComponent<Animator>().SetBool("open", true);
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
            GetComponent<Animator>().SetBool("open", false);
    }
}
