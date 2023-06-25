using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using static UnityEditor.Experimental.GraphView.GraphView;

public class Wall3 : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            if (collision.gameObject.name == "Player_1")
            {
                GameControl.player1.transform.position = Vector3.MoveTowards(GameControl.player1.transform.position,
                GameControl.player1.GetComponent<FollowThePath>().waypoints[53].position, 5);

                GameControl.player1StartWaypoint = 53;
                GameControl.player1.GetComponent<FollowThePath>().waypointIndex = 53;
                GameControl.diceSideThrown = 0;
            }
            if (collision.gameObject.name == "Player_2")
            {
                GameControl.player2.transform.position = Vector3.MoveTowards(GameControl.player2.transform.position,
                GameControl.player2.GetComponent<FollowThePath>().waypoints[53].position, 5);

                GameControl.player2StartWaypoint = 53;
                GameControl.player2.GetComponent<FollowThePath>().waypointIndex = 53;
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
