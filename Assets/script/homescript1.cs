using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class homescript1 : MonoBehaviour
{
    public GameObject panelsetting;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void gotogameplay()
    {
        SceneManager.LoadScene("game");
    }
   public void backgame()
    {
        SceneManager.LoadScene("home");
    }
    public void openGamesetting()
    {
        panelsetting.SetActive(true);
    }
    public void closeGame()
    {
        panelsetting.SetActive(false);
    }
    public void GameQuite()
    {
        Application.Quit();
    }
}
