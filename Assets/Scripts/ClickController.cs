using UnityEngine;
using System.Collections;

public class ClickController : MonoBehaviour {

    public GameObject particle;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
                Instantiate(particle, hit.point, transform.rotation);
        }
    }
}
