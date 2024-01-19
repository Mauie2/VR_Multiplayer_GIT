using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class GameManager : MonoBehaviour
{
    public GameObject PlayerPrefab;


    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.Instantiate(PlayerPrefab.name, new Vector3(0,1,0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
