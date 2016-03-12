using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeSet : MonoBehaviour {

    public Text txt;

	void Update ()
    {
        txt.text = "Time: " + ((int)GlobalVariables.gameTime).ToString();
	}
}
