using System.Collections;
using System.Security.Cryptography;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    #region Singleton
    private static GameManager instance;

    public static GameManager Instance {
        get {
            if (instance == null) {
                instance = FindObjectOfType<GameManager>();
            }
            return instance;
        }
    }

    void Awake()
    {
        // if (instance == null)
        // {
        if (instance == null)
        {
        instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
        // }
        // else
        // {
        //     Debug.Log("Duplicate GameManager found, destroying");
        //     Destroy(gameObject);
        // }
    }
    #endregion

    #region Variables
    public GameObject player;
    public GameObject bookUI;
    public GameObject bookInHand;
    public TMP_Text scoreText;

    public GameObject tutorial;
    
    public Sprite[] bookCovers;

    private int score = 0;

    // order to spawn or despawn NPCs
    public GameObject[] interactOrder;
    int interactIndex = -1;
    public GameObject[] regularNPCs;
    
    bool[] activeNPCs = { false, false, false, false, false, false, false };

    public class Book {
        public string title;
        public string author;
        public string authorLetter;
        public int variant;

        public bool nextInteract;

        public Book(string title, string author, string authorLetter, int variant, bool nextInteract = false) {
            this.title = title;
            this.author = author;
            this.authorLetter = authorLetter;
            this.variant = variant;
            this.nextInteract = nextInteract;
        }
    }

    Book[] books = {
        new Book("Moby Duck", "Herman Mallard", "M", 0),
        new Book("Pride and Prejufish", "Jane Austail", "A", 1, true), // cat at whiteboard convo
        new Book("A Tale of Two Squirrels", "Charles Dickensquirrel", "D", 2, true), // bird card
        new Book("Ant Gone", "Slothocles", "S", 3),
        new Book("The Fault in Our Starfish", "Jelly Green", "G", 1, true), // elephant printer
        new Book("The Rabbit", "GRR Tolkien", "T", 0),
        new Book("A Tail of Two Kitties", "Charles Piggens", "P", 3, true), // bird convo
        new Book("Harry Otter and the Chamber of Fish", "J. K. Roly-Poly", "R", 2),
        new Book("The Great Catsby", "F. Scott Fuzzgerald", "F", 0, true), // elephant convo
        new Book("Raccooneo and Jackalette", "Walrus Shakespeare", "S", 3),
        new Book("The Wonderful Wizard of Paws", " L. Frank Clawm", "C", 2, true), // cat card
        new Book("War and Fleece", "Leo Toadstoy", "T", 1, true), // elephant card
    };
    int bookIndex = 0;

    [HideInInspector]
    public Book currentBook;

    #endregion

    #region Scene Management
    void Start() {
        tutorial.SetActive(true);
    }

    public void StartGame() {
        SceneManager.LoadScene("MapScene");
    }

    public void EndGame() {
        SceneManager.LoadScene("EndScene");

        StartCoroutine(AddScoreRoutine());
    }

    public void RestartGame() {
        Destroy(player);
        for (int i = 0; i < interactOrder.Length; i++) {
            Destroy(interactOrder[i]);
        }
        for (int i = 0; i < regularNPCs.Length; i++) {
            Destroy(regularNPCs[i]);
        }
        SceneManager.LoadScene("MainMenuScene");
        Destroy(gameObject);
    }

    IEnumerator AddScoreRoutine() {
        yield return new WaitForSeconds(.2f);

        GameObject canvas = GameObject.Find("EndCanvas");
        GameObject starCount = canvas.transform.Find("StarCount").gameObject;
        TMP_Text starText = starCount.GetComponent<TextMeshProUGUI>();

        for (int i = 1; i <= score; i++) {
            starText.text = i.ToString();
            yield return new WaitForSeconds(.1f);
        }
    }

    public void EnterMiniGame(string sceneName) {
        Debug.Log("Entering minigame: " + sceneName);

        for (int i = 0; i < interactOrder.Length; i++) {
            activeNPCs[i] = interactOrder[i].activeSelf;
            interactOrder[i].SetActive(false);
        }

        for (int i = 0; i < regularNPCs.Length; i++) {
            regularNPCs[i].SetActive(false);
        }

        SceneManager.LoadScene(sceneName);
        player.SetActive(false);
    }

    public void ExitMiniGame() {
        Debug.Log("Exiting minigame");
        SceneManager.LoadScene("MapScene");
        player.SetActive(true);

        for (int i = 0; i < regularNPCs.Length; i++) {
            regularNPCs[i].SetActive(true);
        }

        for (int i = 0; i < interactOrder.Length; i++) {
            interactOrder[i].SetActive(activeNPCs[i]);
        }
    }
    #endregion

    #region Score Management
    public void AddScore(int value) {
        score += value;
        scoreText.text = score.ToString();
    }

    public int GetScore() {
        return score;
    }
    #endregion

    #region Book Management
    public void GetNewBook() {
        if (currentBook != null) return;

        // if (tutorial1.activeSelf) {
        //     tutorial1.SetActive(false);
        //     tutorial2.SetActive(true);
        // }

        currentBook = books[bookIndex];
        bookIndex = (bookIndex + 1) % books.Length;

        if (player == null) {
            Debug.Log("Player is null");
        }
        Debug.Log(player);

        player.GetComponent<PlayerController>().HoldBook(currentBook);

        bookInHand.SetActive(true);
        bookInHand.GetComponent<SpriteRenderer>().sprite = bookCovers[currentBook.variant];

        OpenBook();
    }

    public void DropBook() {
        Debug.Log("Dropping book");
        if (currentBook == null) return;

        player.GetComponent<PlayerController>().DropBook();

        if (currentBook.nextInteract) {
            interactIndex = (interactIndex + 1) % interactOrder.Length;
            interactOrder[interactIndex].SetActive(true);
        }

        currentBook = null;

        bookInHand.SetActive(false);
        Debug.Log("End drop book");
    }

    public void OpenBook() {
        if (currentBook == null) return;

        bookUI.SetActive(true);
        // bookUI.GetComponent<Image>().color = currentBook.color;
        bookUI.GetComponent<Image>().sprite = bookCovers[currentBook.variant];
        bookUI.transform.Find("Title").GetComponent<TMP_Text>().text = currentBook.title;
        bookUI.transform.Find("Author").GetComponent<TMP_Text>().text = currentBook.author;
    }

    public void CloseBook() {
        bookUI.SetActive(false);
    }
    #endregion

    #region Library Card
    private string patron = null;

    public void SetPatron(string name) {
        patron = name;
    }

    public string GetPatron() {
        return patron;
    }
    #endregion
}
