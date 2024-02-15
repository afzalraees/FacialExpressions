using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using Unity.Properties;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class ExpressionControl : MonoBehaviour
{
    [SerializeField] private Animator anim;
    public void SetExpression_Default()
    {
        anim.SetTrigger("Default");
    }
    public void SetExpression_Joy()
    {
        anim.SetTrigger("Joy");
    }
    public void SetExpression_Surprised()
    {
        anim.SetTrigger("Surprised");
    }
    public void SetExpression_Angry()
    {
        anim.SetTrigger("Angry");
    }
    public void SetExpression_Fun()
    {
        anim.SetTrigger("Fun");
    }
    public void SetExpression_Sorrow()
    {
        anim.SetTrigger("Sorrow");
    }

    public void SetAnimationIntensity(float intensity)
    {
        float intensity_ = intensity / 100f;
    }

    public void StartAnimation()
    {
        anim.enabled = true;
    }
    public void StopAnimation()
    {
        anim.enabled = false;
    }
}
