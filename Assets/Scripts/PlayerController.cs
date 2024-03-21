using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField]
    float playerSpeed = 5f;

    Rigidbody2D playerRigidbody;
    SpriteRenderer playerSprite;
    GameManager gameManager;

    float xAxis;
    float yAxis;

    void Awake()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
        playerSprite = GetComponent<SpriteRenderer>();
        gameManager = GameManager.Instance;
    }

    // Update is called once per frame
    void Update()
    {
        xAxis = Input.GetAxisRaw("Horizontal");
        yAxis = Input.GetAxisRaw("Vertical");

        movePlayer();
    }

    void movePlayer()
    {
        Vector2 movementVector = new Vector2(xAxis, yAxis);
        playerRigidbody.velocity = movementVector.normalized * playerSpeed;
    }


    public void HoldBook(GameManager.Book book)
    {
        playerSprite.color = book.color;
    }

    public void DropBook()
    {
        playerSprite.color = new Color(1, 0.755348f, 0.495283f);
    }

    void OnMouseDown()
    {
        gameManager.OpenBook();
    }
}
