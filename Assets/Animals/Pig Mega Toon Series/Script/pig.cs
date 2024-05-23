using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class pig : MonoBehaviour
{
    public Animator pigAnimator;
    string currentState;

    private void Start()
    {
        StartCoroutine(Animations());
    }

    void ChangeAnimationState(string newState)
    {
        if (currentState == newState) return;
        pigAnimator.Play(newState);
        currentState = newState;
    }

    IEnumerator Animations()
    {   
        while (true)
        {
            yield return new WaitForSeconds(3f);
            Debug.Log("cerdo comiendo");
            ChangeAnimationState("Eating");
            yield return new WaitForSeconds(3f);
            ChangeAnimationState("Idle");
        }
    }
}