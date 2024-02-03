using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundLoop : MonoBehaviour
{
    private float length;

    private void Awake()
    {
        BoxCollider2D backgroundCollider = GetComponent<BoxCollider2D>();
        length = backgroundCollider.size.y;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y <= -length) 
        {
            Reposition();
        }
    }
    private void Reposition()
    {
        Vector2 offset = new Vector2(length * 2f, 0);
        transform.position = (Vector2) transform.position + offset;
    }
}
