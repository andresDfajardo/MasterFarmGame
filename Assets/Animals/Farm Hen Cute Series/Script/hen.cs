using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class hen : MonoBehaviour
{
    public Animator henAnimator;
    string currentState;

    private void Start()
    {
        StartCoroutine(Animations());
    }

    void ChangeAnimationState(string newState)
    {
        if (currentState == newState) return;
        henAnimator.Play(newState);
        currentState = newState;
    }

    IEnumerator Animations()
    {   
        while (true)
        {
            yield return new WaitForSeconds(3f);
            Debug.Log("gallina comiendo");
            ChangeAnimationState("Eating");
            yield return new WaitForSeconds(3f);
            ChangeAnimationState("Idle");
        }
    }
}