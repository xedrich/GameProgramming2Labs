using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPlane : MonoBehaviour
{
    //by using GameObject, we can assign "player" to Player object it in the inspector
    public GameObject player;
    Vector3 playerPosition;

    // Start is called before the first frame update
    void Start()
    {
        //saves player position so we can use later
        playerPosition = player.transform.position;
    }

    // when player touches the deathplane it sends the player back to its original position
    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Player") {
            player.transform.position = playerPosition;
        }


        // can also use this method
        // player.transform.position = playerPosition;
    }
}
