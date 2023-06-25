using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
//using static UnityEditor.Experimental.GraphView.GraphView;

public class GameControl : MonoBehaviour {

    private static GameObject whoWinsTextShadow, player1MoveText, player2MoveText;

    public static GameObject player1, player2;

    public static GameObject wall1, wall2, wall3;

    public static int diceSideThrown = 0;
    public static int player1StartWaypoint = 0;
    public static int player2StartWaypoint = 0;

    public static int limit = 33;

    public static bool gameOver = false;

    // Use this for initialization
    void Start () {
        whoWinsTextShadow = GameObject.Find("Pass");
        player1MoveText = GameObject.Find("PlayerMove_1");
        player2MoveText = GameObject.Find("PlayerMove_2");

        player1 = GameObject.Find("Player_1");
        player2 = GameObject.Find("Player_2");

        wall1 = GameObject.Find("Wall1");
        wall2 = GameObject.Find("Wall2");
        wall3 = GameObject.Find("Wall2");

        player1.GetComponent<FollowThePath>().moveAllowed = false;
        player2.GetComponent<FollowThePath>().moveAllowed = false;

        whoWinsTextShadow.gameObject.SetActive(false);
        player1MoveText.gameObject.SetActive(true);
        player2MoveText.gameObject.SetActive(false);

        //test
        /*
        limit = 63;
        player1StartWaypoint = 53;
        player2StartWaypoint = 53;
        player1.GetComponent<FollowThePath>().waypointIndex = 53;
        player2.GetComponent<FollowThePath>().waypointIndex = 53;
        player1.transform.rotation = Quaternion.Euler(0f, 90f, 0f);
        player2.transform.rotation = Quaternion.Euler(0f, 90f, 0f);
        */
    }

   void turnAngel()
    { 
        if (player1.GetComponent<FollowThePath>().waypointIndex == 1 ||
            player1.GetComponent<FollowThePath>().waypointIndex - 1 == 29 || 
            player1.GetComponent<FollowThePath>().waypointIndex == 33 ||
            player1.GetComponent<FollowThePath>().waypointIndex - 1 == 51)
        {
            player1.transform.rotation = Quaternion.Euler(0f, 90f, 0f);
        }

        if (player2.GetComponent<FollowThePath>().waypointIndex == 1 ||
            player2.GetComponent<FollowThePath>().waypointIndex - 1 == 29 ||
            player2.GetComponent<FollowThePath>().waypointIndex == 33 ||
            player2.GetComponent<FollowThePath>().waypointIndex - 1 == 51)
        {
            player2.transform.rotation = Quaternion.Euler(0f, 90f, 0f);
        }

        if (player1.GetComponent<FollowThePath>().waypointIndex - 1 == 5 ||
            player1.GetComponent<FollowThePath>().waypointIndex - 1 == 36 ||
            player1.GetComponent<FollowThePath>().waypointIndex == 53)
        {
            player1.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }

        if (player2.GetComponent<FollowThePath>().waypointIndex - 1 == 5 ||
            player2.GetComponent<FollowThePath>().waypointIndex - 1 == 36 ||
            player2.GetComponent<FollowThePath>().waypointIndex == 53)
        {
            player2.transform.rotation = Quaternion.Euler(0f, 0, 0f);
        }

        if (player1.GetComponent<FollowThePath>().waypointIndex - 1 == 13 ||
            player1.GetComponent<FollowThePath>().waypointIndex - 1 == 41)
        {
            player1.transform.rotation = Quaternion.Euler(0f, -90f, 0f);
        }

        if (player2.GetComponent<FollowThePath>().waypointIndex - 1 == 13 ||
            player2.GetComponent<FollowThePath>().waypointIndex - 1 == 41)
        {
            player2.transform.rotation = Quaternion.Euler(0f, -90f, 0f);
        }

        if (player1.GetComponent<FollowThePath>().waypointIndex - 1 == 21 ||
            player1.GetComponent<FollowThePath>().waypointIndex - 1 == 46 ||
            player1.GetComponent<FollowThePath>().waypointIndex - 1 == 62 ||
            player1.GetComponent<FollowThePath>().waypointIndex - 1 == 63)
        {
            player1.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }

        if (player2.GetComponent<FollowThePath>().waypointIndex - 1 == 21 ||
            player2.GetComponent<FollowThePath>().waypointIndex - 1 == 46 ||
            player2.GetComponent<FollowThePath>().waypointIndex - 1 == 62 ||
            player2.GetComponent<FollowThePath>().waypointIndex - 1 == 63)
        {
            player2.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }


        if (player1.GetComponent<FollowThePath>().waypointIndex - 1 == 55)
        {
            player1.transform.rotation = Quaternion.Euler(0f, 22.5f, 0f);
        }
        if (player1.GetComponent<FollowThePath>().waypointIndex - 1 == 56)
        {
            player1.transform.rotation = Quaternion.Euler(0f, 45f, 0f);
        }
        if (player1.GetComponent<FollowThePath>().waypointIndex - 1 == 57)
        {
            player1.transform.rotation = Quaternion.Euler(0f, 67.5f, 0f);
        }
        if (player1.GetComponent<FollowThePath>().waypointIndex - 1 == 58)
        {
            player1.transform.rotation = Quaternion.Euler(0f, 90f, 0f);
        }
        if (player1.GetComponent<FollowThePath>().waypointIndex - 1 == 59)
        {
            player1.transform.rotation = Quaternion.Euler(0f, 112.5f, 0f);
        }
        if (player1.GetComponent<FollowThePath>().waypointIndex - 1 == 60)
        {
            player1.transform.rotation = Quaternion.Euler(0f, 135f, 0f);
        }
        if (player1.GetComponent<FollowThePath>().waypointIndex - 1 == 61)
        {
            player1.transform.rotation = Quaternion.Euler(0f, 157.5f, 0f);
        }
        if (player1.GetComponent<FollowThePath>().waypointIndex - 1 == 62)
        {
            player1.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }

        if (player2.GetComponent<FollowThePath>().waypointIndex - 1 == 55)
        {
            player2.transform.rotation = Quaternion.Euler(0f, 22.5f, 0f);
        }
        if (player2.GetComponent<FollowThePath>().waypointIndex - 1 == 56)
        {
            player2.transform.rotation = Quaternion.Euler(0f, 45f, 0f);
        }
        if (player2.GetComponent<FollowThePath>().waypointIndex - 1 == 57)
        {
            player2.transform.rotation = Quaternion.Euler(0f, 67.5f, 0f);
        }
        if (player2.GetComponent<FollowThePath>().waypointIndex - 1 == 58)
        {
            player2.transform.rotation = Quaternion.Euler(0f, 90f, 0f);
        }
        if (player2.GetComponent<FollowThePath>().waypointIndex - 1 == 59)
        {
            player2.transform.rotation = Quaternion.Euler(0f, 112.5f, 0f);
        }
        if (player2.GetComponent<FollowThePath>().waypointIndex - 1 == 60)
        {
            player2.transform.rotation = Quaternion.Euler(0f, 135f, 0f);
        }
        if (player2.GetComponent<FollowThePath>().waypointIndex - 1 == 61)
        {
            player2.transform.rotation = Quaternion.Euler(0f, 157.5f, 0f);
        }
        if (player2.GetComponent<FollowThePath>().waypointIndex - 1 == 62)
        {
            player2.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // turning angle

        turnAngel();
        Debug.Log(player1.GetComponent<FollowThePath>().waypointIndex);
        Debug.Log(player1StartWaypoint + diceSideThrown);
        if (player1.GetComponent<FollowThePath>().waypointIndex > 
            player1StartWaypoint + diceSideThrown)
        {
            if (player1.GetComponent<FollowThePath>().waypointIndex < limit)
            {
                Debug.Log(player1.GetComponent<FollowThePath>().waypointIndex);
                Debug.Log(limit);
                player1.GetComponent<FollowThePath>().moveAllowed = false;
                player1MoveText.gameObject.SetActive(false);
                player2MoveText.gameObject.SetActive(true);
                player1StartWaypoint = player1.GetComponent<FollowThePath>().waypointIndex - 1;
                DiceScript.IsMoving = false;
                AnimationCtrl1.animator.SetBool("isPlay1", false);


                int pointIndex = player1StartWaypoint;
                GameObject point = GameObject.Find("Point" + pointIndex);
                Transform coin = point.transform.Find("coin");
                // question has been answered
                if (coin == null)
                {
                    // find the next unanswered question
                    int i = pointIndex;
                    for (; i < player1.GetComponent<FollowThePath>().waypoints.Length-1; i++)
                    {
                        GameObject p = GameObject.Find("Point" + i);
                        Transform c = p.transform.Find("coin");
                        if (c != null)
                            break;
                    }

                    // move player
                    player1.GetComponent<FollowThePath>().waypointIndex--;

                    Vector3 Waypoint = player1.transform.position;
                    Vector3 nextWaypoint = player1.GetComponent<FollowThePath>().waypoints[i].position;

                    player1.transform.position = Vector3.MoveTowards(Waypoint, nextWaypoint, 50);
                    turnAngel();
                    player1StartWaypoint = i;
                    player1.GetComponent<FollowThePath>().waypointIndex = i;
                }
            }
            if (player1.GetComponent<FollowThePath>().waypointIndex >= 33 && wall1.GetComponent<Collider>().isTrigger)
            {
                int i = 1;
                for (; i < 33; i++)
                {
                    GameObject p = GameObject.Find("Point" + i);
                    Transform c = p.transform.Find("coin");
                    if (c != null)
                        break;
                }

                if (i == 34)
                {
                    wall1.GetComponent<Collider>().isTrigger = false;
                    limit = 53;
                }
            }

            if (player1.GetComponent<FollowThePath>().waypointIndex >= 53 && wall2.GetComponent<Collider>().isTrigger)
            {
                int i = 33;
                for (; i <= 53; i++)
                {
                    GameObject p = GameObject.Find("Point" + i);
                    Transform c = p.transform.Find("coin");
                    if (c != null)
                        break;
                }

                if (i == 54)
                {
                    wall2.GetComponent<Collider>().isTrigger = false;
                    limit = 62;
                }
            }
        }

        if (player2.GetComponent<FollowThePath>().waypointIndex >
            player2StartWaypoint + diceSideThrown)
        {
            if (player2.GetComponent<FollowThePath>().waypointIndex < limit)
            {
                player2.GetComponent<FollowThePath>().moveAllowed = false;
                player2MoveText.gameObject.SetActive(false);
                player1MoveText.gameObject.SetActive(true);
                player2StartWaypoint = player2.GetComponent<FollowThePath>().waypointIndex - 1;
                DiceScript.IsMoving = false;
                AnimationCtrl2.animator.SetBool("isPlay2", false);

                // if the question has been answered, move to the next unanswered question
                int pointIndex = player2StartWaypoint;
                GameObject point = GameObject.Find("Point" + pointIndex);
                Transform coin = point.transform.Find("coin");

                // question has been answered
                if (coin == null)
                {
                    // find the next unanswered question
                    int i = pointIndex;
                    for (; i < player2.GetComponent<FollowThePath>().waypoints.Length-1; i++)
                    {
                        GameObject p = GameObject.Find("Point" + i);
                        Transform c = p.transform.Find("coin");
                        if (c != null)
                            break;
                    }

                    // move player
                    player2.GetComponent<FollowThePath>().waypointIndex--;

                    Vector3 Waypoint = player2.transform.position;
                    Vector3 nextWaypoint = player2.GetComponent<FollowThePath>().waypoints[i].position;

                    player2.transform.position = Vector3.MoveTowards(Waypoint, nextWaypoint, 50);
                    turnAngel();
                    player2StartWaypoint = i;
                    player2.GetComponent<FollowThePath>().waypointIndex = i;
                }
            }

            if (player2.GetComponent<FollowThePath>().waypointIndex >= 33 && wall1.GetComponent<Collider>().isTrigger)
            {
                int i = 1;
                for (; i <= 33; i++)
                {
                    GameObject p = GameObject.Find("Point" + i);
                    Transform c = p.transform.Find("coin");
                    if (c != null)
                        break;
                }

                if (i == 34)
                {
                    wall1.GetComponent<Collider>().isTrigger = false;
                    limit = 53;
                }
            }

            if (player2.GetComponent<FollowThePath>().waypointIndex >= 53 && wall2.GetComponent<Collider>().isTrigger)
            {
                int i = 33;
                for (; i <= 53; i++)
                {
                    GameObject p = GameObject.Find("Point" + i);
                    Transform c = p.transform.Find("coin");
                    if (c != null)
                        break;
                }

                if (i == 54)
                {
                    wall2.GetComponent<Collider>().isTrigger = false;
                    limit = 62;
                }
            }
        }

        // game over
        if (player1.GetComponent<FollowThePath>().waypointIndex == 
            player1.GetComponent<FollowThePath>().waypoints.Length)
        {
            whoWinsTextShadow.gameObject.SetActive(true);
            player1MoveText.gameObject.SetActive(false);
            player2MoveText.gameObject.SetActive(false);
            whoWinsTextShadow.GetComponent<Text>().text = "Congrats!";
            player1.GetComponent<FollowThePath>().moveAllowed = false;
            AnimationCtrl1.animator.SetBool("isPlay1", false);
            DiceCheckZone.Cam.enabled = true;
            DiceCheckZone.Cam1.enabled = false;
            DiceCheckZone.Cam2.enabled = false;
            gameOver = true;
        }

        if (player2.GetComponent<FollowThePath>().waypointIndex ==
            player2.GetComponent<FollowThePath>().waypoints.Length)
        {
            whoWinsTextShadow.gameObject.SetActive(true);
            player1MoveText.gameObject.SetActive(false);
            player2MoveText.gameObject.SetActive(false);
            whoWinsTextShadow.GetComponent<Text>().text = "Congrats";
            player2.GetComponent<FollowThePath>().moveAllowed = false;
            AnimationCtrl2.animator.SetBool("isPlay2", false);
            DiceCheckZone.Cam.enabled = true;
            DiceCheckZone.Cam1.enabled = false;
            DiceCheckZone.Cam2.enabled = false;
            gameOver = true;
        }
    }


    public static void MovePlayer(int playerToMove)
    {
        switch (playerToMove) { 
            case 1:
                player1.GetComponent<FollowThePath>().moveAllowed = true;
                break;

            case 2:
                player2.GetComponent<FollowThePath>().moveAllowed = true;
                break;
        }
    }
}
