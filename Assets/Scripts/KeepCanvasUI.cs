using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepCanvasUI : MonoBehaviour
{
    private static KeepCanvasUI instance;

    // public static KeepCanvasUI Instance
    // {
    //     get
    //     {
    //         if (instance == null)
    //         {
    //             instance = FindObjectOfType<KeepCanvasUI>();
    //         }
    //         return instance;
    //     }
    // }

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);

        // if (instance == null) {
        //     instance = this;
        //     DontDestroyOnLoad(gameObject);
        // } else if (instance != this) {
        //     Destroy(gameObject);
        //     instance = this;
        //     // DontDestroyOnLoad(gameObject);
        // }
    }
}
