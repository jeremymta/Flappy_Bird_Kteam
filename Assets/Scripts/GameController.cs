using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    bool isStartFirstTime = true;
    public bool isEndGame;
    int gamePoint = 0;
    public Text txtPoint;
    public GameObject pnlEndGame;
    public Text txtEndPoint;
    public Button btnRestart;

    public Sprite btnIdle; // Trang thai mac dinh button
    public Sprite btnHover; // Di chuot qua button
    public Sprite btnClick; // click hoac cham vao button


    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1; //0
        isEndGame = false;
        pnlEndGame.SetActive(false);
        isStartFirstTime = true;  
    }

    // Update is called once per frame
    void Update()
    {
        if (isEndGame)
        {
            if (Input.GetMouseButtonDown(0) && isStartFirstTime)
            {
                //Time.timeScale = 1;
                //isEndGame = false ;
                //Load lai man choi
                
                StartGame();    
            }
        }    
        else
        {
            if (Input.GetMouseButtonDown(0) && Time.timeScale == 0)
            {
                Time.timeScale = 1;
            }
        }
    }

    public void ReStartButtonClick()
    {
        btnRestart.GetComponent<Image>().sprite = btnClick;
    }

    public void ReStartButtonHover()
    {
        btnRestart.GetComponent<Image>().sprite = btnHover;
    }

    public void ReStartButtonIdle()
    {
        btnRestart.GetComponent<Image>().sprite = btnIdle;
    }

    public void GetPoint()
    {
        gamePoint++;
        txtPoint.text = "Point: " + gamePoint.ToString();
    }    

    void StartGame()
    {
        SceneManager.LoadScene(0);
    }    

    public void ReStart()
    {
        Debug.Log("Test Restart");
        StartGame();
    }    

    public void EndGame()
    {
        isEndGame = true;
        isStartFirstTime = false;

        //Debug.Log("End game!");
        Time.timeScale = 0;
        pnlEndGame.SetActive(true);
        txtEndPoint.text = "Your point\n" + gamePoint.ToString();
    }    
}
