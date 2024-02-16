using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public enum InfoType { Time }
    public InfoType type;


    Text myText;

    void Awake()
    {
        myText = GetComponent<Text>();
    }

    void LateUpdate()
    {
        //시간이 안보임
        switch(type)
        {
            case InfoType.Time:
                float score = GameManager.instance.gameTime * 5f;
                myText.text = string.Format("{0:F0}", score);
                break;
        }
    }
}
