using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Char player;
    public float gameTime;
    public GameObject menu;
   /* public int playerId;*/

    void Awake()
    {
        Time.timeScale = 0f;
        instance = this;
    }

    /*public void CharSelecet(int id)
    {
        playerId = id;
    }*/

    public void GameStart()
    {
        Time.timeScale = 1f;
    }

    void Update()
    {
        gameTime += Time.deltaTime;
        if(Input.GetButtonDown("Cancel"))
        {
            if (menu.activeSelf)
            {
                menu.SetActive(false);
                Time.timeScale = 1f;
            }
                
            else
            {
                menu.SetActive(true);
                Time.timeScale = 0f;
            }
                
        }
        
    }

    public void Option()
    {
        if (menu.activeSelf)
        {
            menu.SetActive(false);
            Time.timeScale = 1f;
        }

        else
        {
            menu.SetActive(true);
            Time.timeScale = 0f;
        }
    }



}
