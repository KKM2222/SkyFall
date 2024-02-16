using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonEvent : MonoBehaviour
{
    GameObject Player;
    Control control;

    void Start()
    {
        Player = GameObject.Find("Player");
        control = Player.GetComponent<Control>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LeftBtnDown()
    {
        control.LeftMove = true;
        Debug.Log("LeftMove");
    }
    public void LeftBtnUp()
    {
        control.LeftMove = false;
    }
    public void RightBtnDown()
    {
        control.RightMove = true;
        Debug.Log("RightMove");
    }
    public void RightBtnUp()
    {
        control.RightMove = false;
    }
}
