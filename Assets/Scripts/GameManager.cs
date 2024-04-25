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
    public TMP_Text levelText;
    public Slider levelSlider;

    private int score = 0;

    public class Book {
        public string title;
        public string author;
        public string authorLetter;
        public int variant;

        public Book(string title, string author, string authorLetter, int variant) {
            this.title = title;
            this.author = author;
            this.authorLetter = authorLetter;
            this.variant = variant;
        }
    }

    Book[] books = {
        new Book("Moby Duck", "Herman Mallard", "M", 0),
        new Book("Pride and Prejufish", "Jane Austail", "A", 1),
        new Book("A Tale of Two Squirrels", "Charles Dickensquirrel", "D", 2),
        new Book("Ant Gone", "Slothocles", "S", 3),
        new Book("The Fault in Our Starfish", "Jelly Green", "G", 1),
        new Book("The Rabbit", "GRR Tolkien", "T", 0),
        new Book("A Tail of Two Kitties", "Charles Chickens", "C", 3),
        new Book("Harry Otter and the Chamber of Fish", "J. K. Roly-Poly", "R", 2),
        new Book("The Great Catsby", "F. Scott Fuzzgerald", "F", 0),
        new Book("Raccooneo and Jackalette", "Walrus Shakespeare", "S", 3),
        new Book("The Wonderful Wizard of Paws", " L. Frank Clawm", "C", 2),
        new Book("War and Fleece", "Leo Toadstoy", "T", 1)
    };
    int bookIndex = 0;

    [HideInInspector]
    public Book currentBook;

    public int[] levelScores = { 0, 5, 15, 30 };

    // public GameObject tutorial1;
    // public GameObject tutorial2;
    #endregion

    #region Scene Management
    public void StartGame() {
        SceneManager.LoadScene("MapScene");
    }

    public void EndGame() {
        SceneManager.LoadScene("EndScene");
    }

    public void EnterMiniGame(string sceneName) {
        Debug.Log("Entering minigame: " + sceneName);
        SceneManager.LoadScene(sceneName);
        player.SetActive(false);
    }

    public void ExitMiniGame() {
        Debug.Log("Exiting minigame");
        SceneManager.LoadScene("MapScene");
        player.SetActive(true);
    }
    #endregion

    #region Score Management
    public void AddScore(int value) {
        score += value;
        Debug.Log("Score: " + score);

        int level = 0;
        while (level < levelScores.Length && score >= levelScores[level]) {
            level++;
        }

        int levelStartScore = levelScores[level-1];
        int levelEndScore = level == levelScores.Length ? score * 2 : levelScores[level];

        levelText.text = "Level " + level;
        levelSlider.value = (float)(score - levelStartScore) / (levelEndScore - levelStartScore);
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

        OpenBook();
    }

    public void DropBook() {
        Debug.Log("Dropping book");
        if (currentBook == null) return;

        // if (tutorial2.activeSelf) {
        //     tutorial2.SetActive(false);
        // }

        player.GetComponent<PlayerController>().DropBook();
        currentBook = null;
        Debug.Log("End drop book");
    }

    public void OpenBook() {
        if (currentBook == null) return;

        bookUI.SetActive(true);
        // bookUI.GetComponent<Image>().color = currentBook.color;
        bookUI.transform.Find("Title").GetComponent<TMP_Text>().text = currentBook.title;
        bookUI.transform.Find("Author").GetComponent<TMP_Text>().text = currentBook.author;
    }

    public void CloseBook() {
        bookUI.SetActive(false);
    }
    #endregion
}
