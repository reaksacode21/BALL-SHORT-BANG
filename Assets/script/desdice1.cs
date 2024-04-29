using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroydice : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {

       
        if(collision != null)
        {
            
            FindObjectOfType<BubbleRotation>().Rn = 2;
            if (collision.gameObject.CompareTag("red")){
                FindObjectOfType<manager>().updateScore();
                print("red1");
                FindObjectOfType<AudioManager>().sfxAudio[2].Play();
                FindObjectOfType<manager>().ball1red.Play("redt");
                StartCoroutine(wait());
            }
            else if (collision.gameObject.CompareTag("red&blue"))
            {
                FindObjectOfType<blood>().TakeDanger();
                print("Red&blue");
            }
           else if (collision.gameObject.CompareTag("blue"))
            {
                FindObjectOfType<blood>().TakeDanger();
                print("blue");
            } 
           else if (collision.gameObject.CompareTag("black"))
            {
               
                FindObjectOfType<blood>().TakeDanger();
                print("black");
            }
            Destroy(collision.gameObject);
            FindObjectOfType<manager>().openpoint();
        }
    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(1f);
        FindObjectOfType<manager>().ball1red.Play("reddle");
    }
}
