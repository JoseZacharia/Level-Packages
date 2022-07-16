using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpointManager : MonoBehaviour
{
    // Start is called before the first frame update
    private SpriteRenderer checkpointSpriteRenderer;
    public bool checkPointReached;
    void Start()
    {
        checkpointSpriteRenderer = GetComponent<SpriteRenderer>();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            checkpointSpriteRenderer.color = Color.green;
            checkPointReached = true;
        }
    }
}

