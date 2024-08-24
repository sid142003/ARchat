using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;
using TMPro;

public class Player : MonoBehaviour
{
    public Joystick joystick;
    public Rigidbody2D rb;
    public GameObject CanvasName;
    public TMP_Text Name;
    // Start is called before the first frame update
    void Start()
    {
        CanvasName.SetActive(true);
        Name.text = GetComponent<PhotonView>().Controller.NickName;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(GetComponent<PhotonView>().IsMine == true)
        {
            Vector2 Input = new Vector2(joystick.Horizontal, joystick.Vertical);
            rb.MovePosition((Vector2)transform.position + Input * 6.5f * Time.deltaTime);
            if(Input.x > 0)
            {
                transform.rotation = Quaternion.Euler(0,0,0);
                GetComponent<Animator>().SetInteger("Node", 1);
            }
            else if(Input.x < 0)
            {
                transform.rotation = Quaternion.Euler(0,180,0);
                GetComponent<Animator>().SetInteger("Node", 1);
            }
            else
            {
                GetComponent<Animator>().SetInteger("Node", 0);
            }
        }
    }
}
