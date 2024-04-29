using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spamdice : MonoBehaviour
{
    public GameObject[] dicspawn;
    GameObject go;
    public Transform parentTransform;
    public float scaleSize;
    int speed;
    private void Start()
    {
        int i = Random.Range(0, dicspawn.Length);
        go = Instantiate(dicspawn[i], parentTransform.position, Quaternion.identity);
        if (parentTransform != null)
        {
            go.transform.SetParent(parentTransform, true);
        }

        Move moveComponent = go.AddComponent<Move>();
        moveComponent.speed = speed;

        go.transform.localScale = new Vector3(scaleSize, scaleSize, scaleSize);
    }
    public void spawnOFdice()
    {
        FindObjectOfType<manager>().closepoint();
        FindObjectOfType<AudioManager>().sfxAudio[0].Play();
        int i =Random.Range(0, dicspawn.Length);
        go = Instantiate(dicspawn[i], parentTransform.position, Quaternion.identity);
        if (parentTransform != null)
        {
            go.transform.SetParent(parentTransform, true);
        }

        Move moveComponent = go.AddComponent<Move>();
        moveComponent.speed = speed;

        go.transform.localScale = new Vector3(scaleSize, scaleSize, scaleSize);
    }
    
}
