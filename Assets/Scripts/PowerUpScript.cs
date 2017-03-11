using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PowerUpScript : MonoBehaviour
{
    HUDScript hud;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            hud = GameObject.Find("Camera").GetComponent<HUDScript>();
            hud.increaseScore(10);
            Destroy(this.gameObject);
        }
    }
}
