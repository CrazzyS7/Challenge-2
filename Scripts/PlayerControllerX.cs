using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private int mDelay = 0;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (mDelay <= 0)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                mDelay = 70;
            }
        }
        mDelay--;
    }
}
