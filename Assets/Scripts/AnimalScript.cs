using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalScript : MonoBehaviour
{
    public GameObject door;
    public AudioSource ping;


    public void OnClick() 
    {
        Destroy(door);

        ping.Play();

        Destroy(this.gameObject);


        
    }
        
}
