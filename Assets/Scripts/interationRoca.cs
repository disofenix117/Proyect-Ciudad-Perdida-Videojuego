using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interationRoca : MonoBehaviour , IAction
{

    [SerializeField] private Color activeColor;
    [SerializeField] private Color inactiveColor;
    [SerializeField] private Material material;

    private bool activated;

    public void Start()
    {
        material.color = inactiveColor;
    }

    public void Activate()
    {
        activated = !activated;
        if (activated)
        {
            material.color = activeColor;
        }
        else
        {
            material.color = inactiveColor;
        }

    }

}
