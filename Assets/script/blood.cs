using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class blood : MonoBehaviour
{
    // Start is called before the first frame update
    public Image healthbar;
    public float healthamount = 100f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if(healthamount <= 0)
        //{
        //    //Application.loadedLevel(Application.loadedLevel);
        //}
        //if(Input.GetKeyUp(KeyCode.Return))
        //{
        //    TakeDanger(20);
        //}
        //if (Input.GetKeyUp(KeyCode.Space))
        //{
        //    health(5);
        //}
    }
    public void TakeDanger(float danger=20)
    {
        //danger = 25;
        healthamount-=danger;
       healthbar.fillAmount = healthamount/100f;
        //healthbar.fillAmount = healthamount-20;
        if(healthamount == 0)
        {
            FindObjectOfType<manager>().Savescore();
            FindObjectOfType<manager>().gameover.SetActive(true);
            FindObjectOfType<AudioManager>().sfxAudio[1].Play();
        }
    }
    public void health(float healingAmount=100)
    {
        healthamount+=healingAmount;
        healthamount = Mathf.Clamp(healthamount, 0, 100);

        healthbar.fillAmount = healthamount / 100f;
    }

}
