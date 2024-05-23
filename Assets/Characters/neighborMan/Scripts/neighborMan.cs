using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Animator neighborManAnimator;
    string currentState;
    // Start is called before the first frame update
    void Start()
    {
        neighborManAnimator.Play("Sitting Talking");
    }

}
