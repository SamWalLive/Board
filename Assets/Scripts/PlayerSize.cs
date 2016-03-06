using UnityEngine;
using System.Collections;

public class PlayerSize : MonoBehaviour {

    public float startSize;

    private Transform player;

	void Start ()
    {
        player = GetComponent<Transform>();
        player.localScale = new Vector3(startSize, startSize, 1f);
	}
	
	void IncreaseSize()
    {
        player.localScale += new Vector3(startSize, startSize, 0f);
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("gfdgdf");
        if (collision.gameObject.tag == ("Food"))
        {
            IncreaseSize();
            Destroy(collision.gameObject);
        }
    }
}
