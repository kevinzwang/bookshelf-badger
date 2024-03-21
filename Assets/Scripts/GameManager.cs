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
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
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
        public string text;
        public Color color;

        public Book(string title, string author, string authorLetter, string text, Color color) {
            this.title = title;
            this.author = author;
            this.authorLetter = authorLetter;
            this.text = text;
            this.color = color;
        }
    }

    Book[] books = {
        new Book("The Great Catsby", "F. Scott Fuzzgerald", "F", "meow meow meow", Color.red),
        new Book("Pride and Prejufish", "Jane Austail", "A", "bloop bloop bloop", Color.blue)
    };

    [HideInInspector]
    public Book currentBook;

    public int[] levelScores = { 0, 5, 15, 30 };
    #endregion

    #region Scene Management
    public void StartGame() {
        SceneManager.LoadScene("MapScene");
    }

    public void EndGame() {
        SceneManager.LoadScene("EndScene");
    }

    public void EnterMiniGame(string sceneName) {
        var asyncOp = SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);
        asyncOp.completed += (AsyncOperation op) => {
            SceneManager.SetActiveScene(SceneManager.GetSceneByName(sceneName));
        };
    }

    public void ExitMiniGame() {
        Debug.Log("Exiting minigame");
        if (SceneManager.loadedSceneCount > 1) {
            SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
        } else {
            Debug.LogError("No minigame to exit");
        }
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

        int bookIndex = Random.Range(0, books.Length);
        currentBook = books[bookIndex];

        player.GetComponent<PlayerController>().HoldBook(currentBook);

        OpenBook();
    }

    public void DropBook() {
        if (currentBook == null) return;

        player.GetComponent<PlayerController>().DropBook();
        currentBook = null;
    }

    public void OpenBook() {
        if (currentBook == null) return;

        bookUI.SetActive(true);
        bookUI.GetComponent<Image>().color = currentBook.color;
        bookUI.transform.Find("Title").GetComponent<TMP_Text>().text = currentBook.title;
        bookUI.transform.Find("Author").GetComponent<TMP_Text>().text = currentBook.author;
    }

    public void CloseBook() {
        bookUI.SetActive(false);
    }
    #endregion
}
