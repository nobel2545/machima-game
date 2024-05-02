using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour 
{
    [SerializeField]
    private GameObject canvas;

    [SerializeField]
    private TMP_Text dialogue;

    [SerializeField]
    [TextArea]
    private string[] dialogueTexts;

    private bool dialogueActivated;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Interact")) {

            canvas.SetActive(true);
            dialogue.text = dialogueTexts[0];

        }

     void OnTriggerSkill() {
        dialogueActivated = false;
    }
    }
}
