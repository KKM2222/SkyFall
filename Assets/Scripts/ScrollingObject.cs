using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour
{

    public float obspeed = 10f;

    void Update()
    {
        transform.Translate(Vector3.up * obspeed * Time.deltaTime);
    }
}
