using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExpressionIntensityController : MonoBehaviour
{
    private SkinnedMeshRenderer skinnedMeshRenderer;

    [SerializeField] private ExpressionControl expression;
    
    public Slider expressionIntensity;

    int blendShapeIndex;
    private void Awake()
    {
        skinnedMeshRenderer = GetComponent<SkinnedMeshRenderer>();
    }

    public void ExpressionSelect(int index)
    {
        skinnedMeshRenderer.SetBlendShapeWeight(blendShapeIndex, 0);
        expressionIntensity.value = 100;
        blendShapeIndex = index;
        expression.StartAnimation();
    }

    public void OnSliderValueChange()
    {
        expression.StopAnimation();
        expression.SetAnimationIntensity(expressionIntensity.value);
        skinnedMeshRenderer.SetBlendShapeWeight(blendShapeIndex, expressionIntensity.value);
    }



}
