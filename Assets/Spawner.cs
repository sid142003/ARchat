using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Spawner : MonoBehaviour
{
    public Joystick joystick;
    // Start is called before the first frame update
    void Start()
    {
        GameObject Player = PhotonNetwork.Instantiate("Player", new Vector3(Random.Range(-20 , +20), -10f, 5), Quaternion.identity);
        Player.GetComponent<Player>().joystick = joystick;
    }
}
