using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public GameObject template;

	void Start ()
    {
        for (int y = -5; y <= 4; y++)
        {
            for (int x = -4; x <= 5; x++)
            {
                Instantiate(template, new Vector3(x, y, 0), Quaternion.identity);
            }
        }
	}
	
}
