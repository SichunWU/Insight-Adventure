using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceCheckZone : MonoBehaviour
{
    Vector3 diceVelocity;

    private int whosTurn = 1;
    public GameObject Dice3d;
    public static Camera Cam, Cam1, Cam2;

    void Start()
    {
        Dice3d = GameObject.Find("Dice3d");
        Cam = GameObject.Find("Main Camera").GetComponent<Camera>();
        Cam1 = GameObject.Find("Camera1").GetComponent<Camera>();
        Cam2 = GameObject.Find("Camera2").GetComponent<Camera>();
    }
  
    private void FixedUpdate()
    {
        diceVelocity = DiceScript.diceVelocity;
    }

    private void OnTriggerStay(Collider col)
    {
        if (diceVelocity.x == 0f && diceVelocity.y == 0f && diceVelocity.z == 0f 
            && DiceScript.roll == true)
        {
            switch (col.gameObject.name)
            {
                case "side1":
                    DiceNumberText.diceNumber = 6;
                    break;
                case "side2":
                    DiceNumberText.diceNumber = 5;
                    break;
                case "side3":
                    DiceNumberText.diceNumber = 4;
                    break;
                case "side4":
                    DiceNumberText.diceNumber = 3;
                    break;
                case "side5":
                    DiceNumberText.diceNumber = 2;
                    break;
                case "side6":
                    DiceNumberText.diceNumber = 1;
                    break;
            }
           
            GameControl.diceSideThrown = DiceNumberText.diceNumber;
            //Debug.Log("Case:" + DiceNumberText.diceNumber);
            
            if (whosTurn == 1)
            {
                if (Cam.enabled)
                {
                    Cam.enabled = false;
                }
                if (!Cam1.enabled)
                {
                    Cam1.enabled = true;
                }
                if (Cam2.enabled)
                {
                    Cam2.enabled = false;
                }
                AnimationCtrl1.animator.SetBool("isPlay1", true);
                GameControl.MovePlayer(1);
            }
            else if (whosTurn == -1)
            {
                if (Cam.enabled)
                {
                    Cam.enabled = false;
                }
                if (Cam1.enabled)
                {
                    Cam1.enabled = false;
                }
                if (!Cam2.enabled)
                {
                    Cam2.enabled = true;
                }
                GameControl.MovePlayer(2);
                AnimationCtrl2.animator.SetBool("isPlay2", true);
            }
            whosTurn *= -1;
            DiceScript.roll = false;

            Dice3d.transform.position = new Vector3(16, 72, -211);
            Dice3d.GetComponent<Rigidbody>().isKinematic = true;
        }
    }
}
