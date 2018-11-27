using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour {
    // Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.anyKey)
        {
            if (PlayerScript.moves <= 1)
                Change();
        }


    }
    public void Change()
    {
        Renderer rend = GetComponent<Renderer>();
        rend.material.shader = Shader.Find("_Color");
        rend.material.SetColor("_Color", Color.black);
    }

    void OnCollisionStay(Collision col)
    {
        //rise player if last move. increase rise speed over time
        if (PlayerScript.moves <= 1)
        {
            gameObject.transform.position += (new Vector3(0, .15f, 0));

        }
    }
}
