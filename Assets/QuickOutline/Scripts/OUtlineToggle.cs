using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OUtlineToggle : MonoBehaviour
{
    Outline outline;

    void Awake()
    {
        outline = GetComponent<Outline>();
    }

    private void Start()
    {
        outline.enabled = false;
    }

    public void OutlineEnable()
    {
        outline.enabled = true;
    }

    public void OutlineDisable()
    {
        outline.enabled = false;
    }


}
