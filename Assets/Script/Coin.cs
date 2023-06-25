using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    private static GameObject question;
    public static Renderer qesRenderer;
    Text textComponent;

    void Start()
    {
        // hide question
        question = GameObject.Find("Question");
        qesRenderer = question.GetComponent<Renderer>();
        qesRenderer.enabled = false;
        textComponent = gameObject.GetComponent<Text>();
    }

    void Update()
    {
        transform.rotation *= Quaternion.Euler(0, 15 * Time.deltaTime, 0);
    }

    void OnTriggerEnter(Collider collision)
    {   
        
        if (collision.gameObject.CompareTag("Player"))
        {
            CharacterController playerController = collision.gameObject.GetComponent<CharacterController>();        
            StartCoroutine(CheckIsMoving(playerController));
        }
        
    }

    private IEnumerator CheckIsMoving(CharacterController playerController)
    {
        yield return new WaitForSeconds(0.4f); // Adjust the delay if needed
        if (playerController != null && DiceScript.IsMoving == false)
        {
            if (!DiceCheckZone.Cam.enabled)
            {
                //Debug.Log("Cam"+DiceCheckZone.Cam.enabled);
                DiceCheckZone.Cam.enabled = true;
                DiceScript.canPressSpace = true;
            }
            if (DiceCheckZone.Cam1.enabled)
            {
                //Debug.Log("Cam1" + DiceCheckZone.Cam1.enabled);
                DiceCheckZone.Cam1.enabled = false;
            }
            if (DiceCheckZone.Cam2.enabled)
            {
                //Debug.Log("Cam2" + DiceCheckZone.Cam2.enabled);
                DiceCheckZone.Cam2.enabled = false;
            }

            question.GetComponent<TextMeshPro>().text = textComponent.text;

            qesRenderer.enabled = true;

            //Debug.Log(gameObject);
            Destroy(gameObject);
        }
    }
}
