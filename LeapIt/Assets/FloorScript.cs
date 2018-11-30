using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorScript : MonoBehaviour {

    // Use this for initialization
    public Collider coll;
    public float lives=1;
    public bool flag = true;
    public Material [] materials;
    public GameObject [] floorsUp;
    public int isLast=0;
    public bool goal = false;


    void Start()
    {
        coll = GetComponent<Collider>();
        floorsUp = GameObject.FindGameObjectsWithTag("Floor");

    }

        // Update is called once per frame
        void Update () {
        if (lives >= 0)
        {
            Material rend = GetComponent<Renderer>().material;
            rend.color = materials[(int)lives].color;
        }

        for (int i = 0; i < floorsUp.Length; i++) //check to see if floors are up
        {

            if (floorsUp[i].transform.position.y > -.02)
            {
                isLast++;
                
            }
        }
        if (isLast == 1&&transform.position.y>-.02)
        {
            goal = true;
            Material rend = GetComponent<Renderer>().material;
            rend.color = Color.green;
        }
        isLast = 0;

        /*if (PlayerScript.moves < 1&& flag)
        {
            Destroy(gameObject.GetComponent<Collider>());
            coll.attachedRigidbody.useGravity = true;
            flag = false;
        }*/
    }

    void OnTriggerExit(Collider other)
    {
      

        if (lives < 1)
        {
            Destroy(gameObject.GetComponent<Collider>());
            coll.attachedRigidbody.useGravity = true;
        }
        lives --;

    }
    void OnCollisionStay(Collision col)
    {
        //rise player if last move. increase rise speed over time
        if (goal)
        {
            gameObject.transform.position += (new Vector3(0, .15f, 0));

        }
    }


}

