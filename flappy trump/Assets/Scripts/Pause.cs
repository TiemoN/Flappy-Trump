using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    private float currentTimeScale;
    public GameObject pauseMenu;
    public void Start()
    {
        currentTimeScale = 1;
        pauseMenu.SetActive(false);
    }
   
        public void PauseGame()
    {
        if (Time.timeScale == 0)
        {
            Time.timeScale = currentTimeScale;
            pauseMenu.SetActive(false);
        } else
        {
            Time.timeScale = 0;
            pauseMenu.SetActive(true);
        }
        
    }
    

        
        

}
