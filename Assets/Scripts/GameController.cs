using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    bool isEndGame;
    
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        isEndGame = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isEndGame)
        {
            if (Input.GetMouseButtonDown(0))
            {
                //Time.timeScale = 1;
                //isEndGame = false ;
                //Load lai man choi
                SceneManager.LoadScene(0);

            }
        }    
        else
        {
            if (Input.GetMouseButtonDown(0))
            {
                Time.timeScale = 1;
            }
        }
    }
    public void EndGame()
    {
        isEndGame = true;

        //Debug.Log("End game!");
        Time.timeScale = 0;
        
    }    
}
