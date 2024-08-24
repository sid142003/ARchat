using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using Photon.Pun;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ConnectToServer : MonoBehaviour
{
    public TMP_InputField usernameInput;
    public TMP_Text buttonText;
    
    public void OnClickConnect()
    {
        SceneManager.LoadScene("GameScene_ChatBubble");
    }

    // public override void OnConnectedToMaster()
    // {
    //     SceneManager.LoadScene("GameScene_ChatBubble");
    //     // PhotonNetwork.JoinRandomRoom();
    // }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
