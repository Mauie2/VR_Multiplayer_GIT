using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroDoor : MonoBehaviour
{
    public bool animal_found_1;
    public bool animal_found_2;


    private void FixedUpdate()
    {
        if (animal_found_1 && animal_found_2)
        Destroy(gameObject);
    }
}
