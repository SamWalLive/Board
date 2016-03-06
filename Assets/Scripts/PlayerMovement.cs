using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    private Transform rb;

	void Start () {
        rb = GetComponent<Transform>();
	}
	
	void Update () {
        if (Input.GetButtonDown("Up"))
        {
            rb.transform.Translate(0,1,0);
        }
        if (Input.GetButtonDown("Down"))
        {
            rb.transform.Translate(0, -1, 0);
        }
        if(Input.GetButtonDown("Left"))
        {
            rb.transform.Translate(-1, 0, 0);
        }
        if(Input.GetButtonDown("Right"))
        {
            rb.transform.Translate(1, 0, 0);
        }
	}

}
