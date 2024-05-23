using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class cow : MonoBehaviour
{
    public Animator cowAnimator;
    string currentState;

    private void Start()
    {
        StartCoroutine(Animations());
    }

    void ChangeAnimationState(string newState)
    {
        if (currentState == newState) return;
        cowAnimator.Play(newState);
        currentState = newState;
    }

    IEnumerator Animations()
    {   
        while (true)
        {
            yield return new WaitForSeconds(3f);
            Debug.Log("Vaca comiendo");
            ChangeAnimationState("Eating");
            yield return new WaitForSeconds(3f);
            ChangeAnimationState("Idle");
        }
    }
}