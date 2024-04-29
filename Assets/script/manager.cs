using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;

public class manager : MonoBehaviour
{
    public Animator hand, ball1red, ball2redblue, ball3blue, ball4black;
    public GameObject handball,gamesetting,gameover,closepointa;
    public int score,highscore;
    public Text txtscore,ptxtscore,ptxthighscore;

    void Start()
    {
        highscore = PlayerPrefs.GetInt("Highscore");
        ptxthighscore.text = "HIGH SCORE:" + highscore.ToString();
        ball1red.Play("reddle");
        handball.SetActive(true);
        hand.Play("hand");
        ball2redblue.Play("red&bluetdle");
        ball3blue.Play("bluedle");
        ball4black.Play("blackdle");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Savescore()
    {
        PlayerPrefs.SetInt("Highscore", highscore);
    }
    public void updateScore()
    {
        score++;
        txtscore.text = "SCORE:" + score.ToString();
        ptxtscore.text="SCORE:"+score.ToString();
        if (score > highscore)
        {
            Savescore();
            highscore = score;
            ptxthighscore.text = "HIGH SCORE:" + highscore.ToString();

        }

    }
    public void handGame()
    {
        handball.SetActive(false);
    }
    public void opensitting()
    {
        gamesetting.SetActive(true);
    }
    public void closesetting()
    {
        gamesetting.SetActive(false);
    }
    
     public void btnbackhome()
    {
        SceneManager.LoadScene("home");
    }
    public void PlayAgain()
    {
       // print("true");
        gameover.SetActive(false);
    }
    public void restartgame()
    {
        //highscore = 0;
        txtscore.text = "SCORE:0";
        ptxtscore.text = "SCORE:0";
        score = 0;
    }
    public void closepoint()
    {
        closepointa.SetActive(true);
    }
    //IEnumerator waitclose()
    //{
    //    yield return new WaitForSeconds(1f);
    //     closepointa.SetActive(false);
    //}
    public void openpoint()
    {
        closepointa.SetActive(false);
    }
}
