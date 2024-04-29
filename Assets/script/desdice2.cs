using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroydice2 : MonoBehaviour
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
            FindObjectOfType<AudioManager>().sfxAudio[2].Play();
            FindObjectOfType<manager>().updateScore();
            FindObjectOfType<manager>().ball2redblue.Play("red&bluet");
            print("Red&blue1");
            StartCoroutine(wait());
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
            FindObjectOfType<manager>().ball2redblue.Play("red&bluetdle");
        }
    }
}
