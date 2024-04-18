using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    public TextMeshProUGUI output;
    public GameObject returnButton;

    public List<TMP_InputField> inputFields;
    public Button saveButton;

    private List<string> prompts = new List<string> { "Name", "DOB", "ID", "Address" };

    public GameObject image;

    public GameObject imageborder;

    public GameObject InText;

    void Start()
    {
        saveButton.onClick.AddListener(OnSaveButtonClick);
    }

    private void OnSaveButtonClick()
    {
        List<string> userInputList = new List<string>();
        foreach (TMP_InputField inputField in inputFields)
        {
            userInputList.Add(inputField.text);
        }

        DisplayUserInputs(userInputList);
    }

    private void DisplayUserInputs(List<string> userInputList)
    {
        string outputText = "New Library Card Registered!:\n\n";
        for (int i = 0; i < prompts.Count; i++)
        {
            outputText += $"{prompts[i]}: {userInputList[i]}\n";
        }
        output.text = outputText;

        foreach (TMP_InputField inputField in inputFields)
        {
            inputField.gameObject.SetActive(false);
        }
        saveButton.gameObject.SetActive(false);
        returnButton.SetActive(true);
        image.SetActive(false);
        imageborder.SetActive(false);
        InText.SetActive(false);
    }
}