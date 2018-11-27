using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorScript : MonoBehaviour {

    // Use this for initialization
    public Collider coll;

    void Start () {
        coll = GetComponent<Collider>();

    }

    // Update is called once per frame
    void Update () {
		
	}

    void OnTriggerExit(Collider other)
    {
        Destroy(gameObject.GetComponent<Collider>());
        coll.attachedRigidbody.useGravity = true;
    }


}

