using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalScript : MonoBehaviour
{
    public GameObject door;


    public void OnClick() 
    {
        Destroy(door);



        Destroy(this.gameObject);
    }
        
}
