using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundLoop : MonoBehaviour
{
    public float lenghtParam = 2f;
    private float length;

    public float obspeed = 10f;

    public GameObject lengthTopObject;

    private void Awake()
    {
        BoxCollider2D backgroundCollider = GetComponent<BoxCollider2D>();
        length = backgroundCollider.size.y;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * obspeed * Time.deltaTime);

        if (transform.position.y > lengthTopObject.transform.position.y)
        {
            Reposition();
        }
    }
    private void Reposition()
    {
        //Debug.Log("Reposition");
        // Vector2 offset = new Vector2(transform.position.x, length * lenghtParam);
        transform.position = Vector2.zero;
    }
}