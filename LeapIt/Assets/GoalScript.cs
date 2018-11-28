using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour {
    // Use this for initialization
    public GameObject[] floorsUp;
    public bool finish = false;
    void Start () {
        floorsUp = GameObject.FindGameObjectsWithTag("Floor");
    }
	
	// Update is called once per frame
	void Update () {
       
            if (PlayerScript.moves <= 1||finish)
                Change();

        for (int i = 0; i < floorsUp.Length; i++) //check to see if floors are up
        {
            finish = true;
            if (floorsUp[i].transform.position.y > -.05)
            {
                finish = false;
                break;
            }
        }

    }
    public void Change()
    {
        Material rend = GetComponent<Renderer>().material;
        rend.color = Color.green;
    }

    void OnCollisionStay(Collision col)
    {
        //rise player if last move. increase rise speed over time
        if (PlayerScript.moves <= 1|| finish)
        {
            gameObject.transform.position += (new Vector3(0, .15f, 0));

        }
    }
}
