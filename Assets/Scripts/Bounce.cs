using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    public float bounceHeight = 1f;
    public float bounceTime = 1f;

    private Vector3 initialPosition;
    private float time;

    void Start()
    {
        initialPosition = transform.position;
        time = 0;
    }

    void Update()
    {
        time += Time.deltaTime;
        while (time > bounceTime) time -= bounceTime;

        // quadratic function for bounce
        float y = initialPosition.y - 4 * bounceHeight / bounceTime * time * (time * bounceTime - 1);
        transform.position = new Vector3(initialPosition.x, y, initialPosition.z);
    }
}
