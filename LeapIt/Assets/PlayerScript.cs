using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour {

    public int startMoves;
    public static int moves;
    public Collider coll;
    public bool falling =false;

    // Use this for initialization
    void Start () {
        moves = startMoves;
        coll = GetComponent<Collider>();

    }
	
	// Update is called once per frame
	void Update () {

        /*if(moves<1)
        {
            coll.attachedRigidbody.useGravity = true;
            falling = true;
        }*/

        if(transform.position.y<-2) //restart level if fallen down
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if(transform.position.y > 2.5)//go to next level if platform rises you up
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        if (!falling) //if not falling, move the player the direction they press.
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                Move(new Vector3(0, 0, 1));
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                Move(new Vector3(0, 0, -1));
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                Move(new Vector3(-1, 0, 0));
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                Move(new Vector3(1, 0, 0));
            }
        }
    }

    void Move(Vector3 v)
    {
        if (moves > 0)
        {
            transform.position += v;
            moves--;
        }
      
        
    }
    void OnTriggerExit(Collider other)
    {
        coll.attachedRigidbody.useGravity = true;
        falling = true;

    }

    void OnTriggerEnter(Collider other)
    {
        coll.attachedRigidbody.useGravity = false;
        falling = false;
    }

    void OnGUI()
    {
        GUI.Label(new Rect(50, 50, 500, 100), "Moves Left: "+moves.ToString());
    }
}
