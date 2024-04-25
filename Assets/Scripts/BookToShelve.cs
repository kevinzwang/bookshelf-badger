using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BookToShelve : MonoBehaviour
{
    public float followSpeed = 0.025f;
    public Sprite[] bookSprites;

    GameManager gameManager;
    SpriteRenderer spriteRenderer;

    private void Awake()
    {
        gameManager = GameManager.Instance;
        spriteRenderer = GetComponentInParent<SpriteRenderer>();

        int variant = 0;
        if (gameManager.currentBook != null)
        {
            variant = gameManager.currentBook.variant;
        }

        spriteRenderer.sprite = bookSprites[variant];
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        transform.position = Vector3.Lerp(transform.position, mousePos, followSpeed);
    }

    public void Shelve() {
        StartCoroutine(ShelveAnimation());
    }

    IEnumerator ShelveAnimation() {
        float totalTime = 1f;
        float timeInterval = 0.01f;


        float startRotation = transform.eulerAngles.z;
        float startScale = transform.localScale.x;

        float endRotation = startRotation + 360f;
        float endScale = 0;

        for (float i = 0; i < totalTime; i += timeInterval) {
            float currRotation = Mathf.Lerp(startRotation, endRotation, i / totalTime);
            float currScale = Mathf.Lerp(startScale, endScale, i / totalTime);

            transform.eulerAngles = new Vector3(0f, 0f, currRotation);
            transform.localScale = new Vector3(currScale, currScale, currScale);
            yield return new WaitForSeconds(timeInterval);
        }

        gameManager.DropBook();
        gameManager.AddScore(1);
        gameManager.ExitMiniGame();

        yield return null;
    }
}
