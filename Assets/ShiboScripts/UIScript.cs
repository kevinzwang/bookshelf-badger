using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    public TextMeshProUGUI output;
    public GameObject returnButton;
    public TMP_InputField[] inputFields;
    public Button saveButton;
    private string[] prompts = new string[] { "Name", "DOB", "ID", "Address" };
    public GameObject imageborder;
    public GameObject InText;
    public GameObject dialoguePrefab;
    public GameObject success;
    GameObject oldDialogue;

    void Start()
    {
        saveButton.onClick.AddListener(OnSaveButtonClick);
    }

    private void OnSaveButtonClick()
    {
        DisplayUserInputs();
    }

    private void DisplayUserInputs()
    {
        foreach (TMP_InputField inputField in inputFields)
        {
            inputField.gameObject.SetActive(false);
        }
        saveButton.gameObject.SetActive(false);
        returnButton.SetActive(true);
        //imageborder.SetActive(false);
        InText.SetActive(false);
        dialoguePrefab.SetActive(true);
        success.SetActive(true);
        oldDialogue = GameObject.FindGameObjectWithTag("dialogue");
        oldDialogue.SetActive(false);
    }
}