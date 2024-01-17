using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    public BasicPUN basicPUN;

    private void Awake()
    {
        basicPUN = GetComponent<BasicPUN>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Hand")
        {
            basicPUN.Connect();
        }
    }
}
