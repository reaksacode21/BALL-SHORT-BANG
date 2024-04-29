using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroydice4 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("red"))
        {
            FindObjectOfType<blood>().TakeDanger(); 
        }
        else if (collision.gameObject.CompareTag("red&blue"))
        {
            FindObjectOfType<blood>().TakeDanger();
           
        }
        else if (collision.gameObject.CompareTag("blue"))
        {
            FindObjectOfType<blood>().TakeDanger();
            print("blue");
        }
        else if (collision.gameObject.CompareTag("black"))
        {
            FindObjectOfType<AudioManager>().sfxAudio[2].Play();
            FindObjectOfType<manager>().updateScore();
            //FindObjectOfType<blood>().health();
          
            FindObjectOfType<manager>().ball4black.Play("blackt");
            StartCoroutine(wait());
        }
        if (collision != null)
        {
           
            FindObjectOfType<BubbleRotation>().Rn = 1;
            // FindObjectOfType<blood>().TakeDanger();
            Destroy(collision.gameObject);
            FindObjectOfType<manager>().openpoint();
        }
        IEnumerator wait()
        {
            yield return new WaitForSeconds(1f);
            FindObjectOfType<manager>().ball4black.Play("blackdle");
        }
    }
}
