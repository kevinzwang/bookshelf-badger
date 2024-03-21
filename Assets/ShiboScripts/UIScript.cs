using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    public TextMeshProUGUI output;
    public TMP_InputField input;
    public TextMeshProUGUI promptText;

    public Button button;
    public GameObject dialoguePrefab;

    private List<string> prompts = new List<string> { "Name", "Address", "Height", "Weight"};
    private List<string> userInputList = new List<string>();
    private int currentPromptIndex = 0;

    GameManager gameManager;

    void Awake() {
        gameManager = GameManager.Instance;
    }

    private void Start()
    {
        ShowNextPrompt();
    }

    public void Button() 
    {
        userInputList.Add(input.text);

        currentPromptIndex++;

        if (currentPromptIndex < prompts.Count)
        {
            ShowNextPrompt();
        }
        else
        {
            DisplayUserInputs();
        }
    }

    private void ShowNextPrompt()
    {
        promptText.text = prompts[currentPromptIndex];

        input.text = "";
    }

    private void DisplayUserInputs()
    {
        promptText.text = "";

        string outputText = "New Library Card Registered!:\n";
        for (int i = 0; i < prompts.Count; i++)
        {
            outputText += $"{prompts[i]}: {userInputList[i]}\n";
        }
        output.text = outputText;

        input.gameObject.SetActive(false);
        button.gameObject.SetActive(false);

        Canvas canvas = FindObjectOfType<Canvas>();
        if (canvas != null)
        {
            GameObject dialogueInstance = Instantiate(dialoguePrefab, canvas.transform);

            Canvas dialogueCanvas = dialogueInstance.GetComponent<Canvas>();
            if (dialogueCanvas != null)
            {
                dialogueCanvas.sortingOrder = 999;
            }
            gameManager.ExitMiniGame();
        }
        else
        {
            Debug.LogWarning("Canvas not found in the scene. Dialogue prefab not instantiated.");
        }
    }
}