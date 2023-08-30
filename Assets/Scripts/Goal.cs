using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    // when playyer hits the endgoal collider, prints you win in console
    void OnTriggerEnter(Collider collider) {
        if (collider.tag == "Player") {
            Debug.Log("You Win!");
        }
    }
}
