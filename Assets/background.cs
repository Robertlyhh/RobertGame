using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{
    public float backgroundSpeed = 0.5f;  // Adjust this value to control the speed of the background
    private Vector2 startPos;  // Starting position of the background
    private float backgroundWidth;  // Width of the background image

    void Start()
    {
        // Store the starting position of the background
        startPos = transform.position;
        
        // Calculate the width of the background image
        backgroundWidth = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    void Update()
    {
        // Move the background to the left
        transform.position += Vector3.left * backgroundSpeed * Time.deltaTime;

        // If the background moves completely out of view, reset its position
        if (transform.position.x <= startPos.x - 10)
        {
            transform.position = startPos;
        }
    }
}


