using UnityEngine;
using System.Collections;

public class GlobalVariables : MonoBehaviour {

    public float timeScale;
    public static float realTime;
    public static float gameTime;

    void Update()
    {
        realTime += Time.deltaTime;
        gameTime += Time.deltaTime * timeScale;
    }

}
