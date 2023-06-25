using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceScript : MonoBehaviour
{
    static Rigidbody rb;
    public static Vector3 diceVelocity;
    public static bool roll = false;
    public static bool canPressSpace = true;

    public static bool? IsMoving = null;


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true;
    }


    void Update()
    {
        diceVelocity = rb.velocity;
        
        if (!GameControl.gameOver && Input.GetKeyDown(KeyCode.Space) && canPressSpace)
        {
            rb.isKinematic = false;
            IsMoving = true;
            Coin.qesRenderer.enabled = false;
            RollDice();
            canPressSpace = false;
        }
    }
   
    //private IEnumerator RollDice()
    void RollDice()
    {
        // Generate random force
        Vector3 force = new Vector3(Random.Range(-100, 100), Random.Range(800, 1500), Random.Range(-100, 100));
        rb.AddForce(force);

        // Generate random torque
        Vector3 torque = new Vector3(Random.Range(-50, 50), Random.Range(-50, 50), Random.Range(-50, 50));
        rb.AddTorque(torque);
        roll = true;
    }
}
