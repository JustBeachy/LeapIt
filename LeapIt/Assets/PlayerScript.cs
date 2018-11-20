using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    public int startMoves;
    public static int moves; 

    // Use this for initialization
    void Start () {
        moves = startMoves;
    }
	
	// Update is called once per frame
	void Update () {

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

    void Move(Vector3 v)
    {
        if (moves > 0)
        {
            transform.position += v;
            moves--;
        }
      
        
    }
}
