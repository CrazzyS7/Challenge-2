using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float mLeftLimit = -40;
    private float mBottomLimit = -5;

    // Update is called once per frame
    void Update()
    {
        // Destroy dogs if x position less than left limit
        // or balls if y position is less than bottomLimit
        if (transform.position.x <= mLeftLimit || transform.position.y <= mBottomLimit)
        {
            Destroy(gameObject);
        } 
    }
}
