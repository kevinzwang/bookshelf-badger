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

    Animator anim;

    void Awake()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
        playerSprite = GetComponent<SpriteRenderer>();
        gameManager = GameManager.Instance;
        anim = GetComponent<Animator>();
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
        anim.SetBool("Walking", true);
        Vector2 movementVector = new Vector2(xAxis, yAxis);
        Vector2 currDir = movementVector.normalized;
        
        if (xAxis == 0 && yAxis == 0) {
            anim.SetBool("Walking", false);
        } else {
            anim.SetFloat("DirX", currDir.x);
            anim.SetFloat("DirY", currDir.y);
        }
        playerRigidbody.velocity = movementVector.normalized * playerSpeed;
    }


    public void HoldBook(GameManager.Book book)
    {
        anim.SetBool("hasBook", true);
        // playerSprite.color = book.color;
    }

    public void DropBook()
    {
        anim.SetBool("hasBook", false);
        // playerSprite.color = new Color(1, 0.755348f, 0.495283f);
    }

    void OnMouseDown()
    {
        gameManager.OpenBook();
    }
}
