using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorScript : MonoBehaviour {

    // Use this for initialization
    public Collider coll;
    public float lives=1;
    public bool flag = true;
    public Material [] materials;
   


    void Start()
    {
        coll = GetComponent<Collider>();

       
    }

        // Update is called once per frame
        void Update () {
        if (lives >= 0)
        {
            Material rend = GetComponent<Renderer>().material;
            rend.color = materials[(int)lives].color;
        }
        /*if (PlayerScript.moves < 1&& flag)
        {
            Destroy(gameObject.GetComponent<Collider>());
            coll.attachedRigidbody.useGravity = true;
            flag = false;
        }*/
    }

    void OnTriggerExit(Collider other)
    {

        if (lives < 0)
        {
            Destroy(gameObject.GetComponent<Collider>());
            coll.attachedRigidbody.useGravity = true;
        }
        lives -= .5f;

    }


}

