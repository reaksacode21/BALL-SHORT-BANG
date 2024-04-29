using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroydice3 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("red"))
        {
            FindObjectOfType<blood>().TakeDanger();
            print("red");
        }
        else if (collision.gameObject.CompareTag("red&blue"))
        {
            FindObjectOfType<blood>().TakeDanger();
            print("Red&blue");
        }
        else if (collision.gameObject.CompareTag("blue"))
        {
            FindObjectOfType<AudioManager>().sfxAudio[2].Play();
            FindObjectOfType<manager>().updateScore();
            FindObjectOfType<manager>().ball3blue.Play("blue");
            StartCoroutine(wait());
            print("blue1");
        }
        else if (collision.gameObject.CompareTag("black"))
        {
            FindObjectOfType<blood>().TakeDanger();
            print("black");
        }
        if (collision != null)
        {
           
            FindObjectOfType<BubbleRotation>().Rn = 2;
            //FindObjectOfType<blood>().TakeDanger();
            Destroy(collision.gameObject);
            FindObjectOfType<manager>().openpoint();
        }
        IEnumerator wait()
        {
            yield return new WaitForSeconds(1f);
            FindObjectOfType<manager>().ball3blue.Play("bluedle");
        }
    }
}
