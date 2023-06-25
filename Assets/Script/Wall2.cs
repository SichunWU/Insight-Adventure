using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using static UnityEditor.Experimental.GraphView.GraphView;

public class Wall2 : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            if (collision.gameObject.name == "Player_1")
            {
                GameControl.player1.transform.position = Vector3.MoveTowards(GameControl.player1.transform.position,
                GameControl.player1.GetComponent<FollowThePath>().waypoints[33].position, 5);

                GameControl.player1StartWaypoint = 33;
                GameControl.player1.GetComponent<FollowThePath>().waypointIndex = 33;
                GameControl.diceSideThrown = 0;
            }
            if (collision.gameObject.name == "Player_2")
            {
                GameControl.player2.transform.position = Vector3.MoveTowards(GameControl.player2.transform.position,
                GameControl.player2.GetComponent<FollowThePath>().waypoints[33].position, 5);

                GameControl.player2StartWaypoint = 33;
                GameControl.player2.GetComponent<FollowThePath>().waypointIndex = 33;
                GameControl.diceSideThrown = 0;
            }

        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
