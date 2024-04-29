using System.Collections;
using UnityEngine;

public class BubbleRotation : MonoBehaviour
{
    public Transform bubble;
    public float speed;
    public bool isOn;
    public int Rn = 1;

    // private void Update() => BubbleRotate();
    private void FixedUpdate()
   {
        if (Rn==1)
        {
            BubbleRotate();
        }
        else
        {
            BubbleRotate1();
        }
   }
    public void BubbleRotate() => bubble.Rotate(0f, 0f, speed * Time.deltaTime); 
    public void BubbleRotate1() => bubble.Rotate(0f, 0f, speed * -Time.deltaTime); 
    
   
}
