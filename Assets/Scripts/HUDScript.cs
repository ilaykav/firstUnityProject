using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUDScript : MonoBehaviour {

    // Use this for initialization
    float playerScore = 0;

    public void increaseScore (int amount) {
        playerScore += amount;
	}
	
	// Update is called once per frame
	void Update () {
        playerScore += Time.deltaTime;
	}

    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 30), "Score: " + (int)(playerScore * 100));
    }
}
