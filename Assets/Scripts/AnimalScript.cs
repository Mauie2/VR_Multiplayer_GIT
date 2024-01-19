using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalScript : MonoBehaviour
{
    public AudioSource ping;

    public bool animal_1;
    public bool animal_2;



    public destroDoor destrodoor;


    public void OnClick() 
    {

        Destroy(this.gameObject);

        if (animal_1)
        {
            destrodoor.animal_found_1 = true;
        }
        else if (animal_2)
        {
            destrodoor.animal_found_2 = true;
        }

    }

    public void Ping()
    {
            ping.Play();
    }



}
