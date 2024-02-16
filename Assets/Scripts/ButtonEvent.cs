using System.Collections;
using System.Collections.Generic;
using UnityEditor;
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
    }
    public void LeftBtnUp()
    {
        control.LeftMove = false;
    }
    public void RightBtnDown()
    {
        control.RightMove = true;
    }
    public void RightBtnUp()
    {
        control.RightMove = false;
    }
}
