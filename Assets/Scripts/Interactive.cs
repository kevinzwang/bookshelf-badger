using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactive : MonoBehaviour
{
    private bool _interactEnabled = false;

    [HideInInspector]
    public bool interactEnabled {
        get {
            return _interactEnabled;
        }
        set {
            _interactEnabled = value;

            if (!_interactEnabled) {
                gameObject.transform.localScale = scale;
            }
        }
    }
    Vector3 scale;

    GameManager gameManager;

    public bool cart = false;

    private void Awake()
    {
        gameManager = GameManager.Instance;
        scale = gameObject.transform.localScale;
    }

    void OnMouseEnter()
    {
        if (!interactEnabled) return;
        if (cart && gameManager.currentBook != null) return;

        gameObject.transform.localScale = scale * 1.2f;
    }

    void OnMouseExit()
    {
        if (!interactEnabled) return;

        gameObject.transform.localScale = scale;
    }
}
