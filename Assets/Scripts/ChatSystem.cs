using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ChatSystem : MonoBehaviour
{
    public TMP_Text messageDisplay;
    public Image userAAvatar;
    public Image userBAvatar;

    public Sprite userAOriginal;
    public Sprite userBOriginal;

    public Sprite sharedHappy;
    public Sprite sharedSad;
    public Sprite sharedAngry;

    private bool userAIsEmotionSelected = false;
    private bool userBIsEmotionSelected = false;

    private int totalMessageCount = 0;

    public void OnHappyClickedUserA()
    {
        if(totalMessageCount < 10)
        {
            userAAvatar.sprite = sharedHappy;
            userAIsEmotionSelected = true;
            totalMessageCount++;
        }
    }

    public void OnSadClickedUserA()
    {
        if(totalMessageCount < 10)
        {
            userAAvatar.sprite = sharedSad;
            userAIsEmotionSelected = true;
            totalMessageCount++;
        }
    }

    public void OnAngryClickedUserA()
    {
        if(totalMessageCount < 10)
        {
            userAAvatar.sprite = sharedAngry;
            userAIsEmotionSelected = true;
            totalMessageCount++;
        }
    }

    public void OnRestoreClickedUserA()
    {
        userAAvatar.sprite = userAOriginal;
        userAIsEmotionSelected = false;
    }

    public void OnHappyClickedUserB()
    {
        if(totalMessageCount < 10)
        {
            userBAvatar.sprite = sharedHappy;
            userBIsEmotionSelected = true;
            totalMessageCount++;
        }
    }

    public void OnSadClickedUserB()
    {
        if(totalMessageCount < 10)
        {
            userBAvatar.sprite = sharedSad;
            userBIsEmotionSelected = true;
            totalMessageCount++;
        }
    }

    public void OnAngryClickedUserB()
    {
        if(totalMessageCount < 10)
        {
            userBAvatar.sprite = sharedAngry;
            userBIsEmotionSelected = true;
            totalMessageCount++;
        }
    }

    public void OnRestoreClickedUserB()
    {
        userBAvatar.sprite = userBOriginal;
        userBIsEmotionSelected = false;
    }

    public void OnSendMessageUserA(string message)
    {
        if(totalMessageCount < 20)
        {
            DisplayMessage($"UserA : {message}", userAAvatar.sprite);
            totalMessageCount++;
        }
    }

    public void OnSendMessageUserB(string message)
    {
        if(totalMessageCount < 20)
        {
            DisplayMessage($"UserB : {message}", userBAvatar.sprite);
            totalMessageCount++;
        }
    }

    private void DisplayMessage(string message, Sprite avatar)
    {
        messageDisplay.text += message + "\n";
        messageDisplay.text += "------------------------" + "\n";
        messageDisplay.text += "\n";
    }

    public void OnSendSharedMessage()
    {
        if(userAIsEmotionSelected && userBIsEmotionSelected)
        {
            DisplayMessage($"UserA : I am happy", userAAvatar.sprite);
            DisplayMessage($"UserB : I am happy", userBAvatar.sprite);
            totalMessageCount += 2;
        }
    }

    public void OnSendSharedMessageSad()
    {
        if(userAIsEmotionSelected && userBIsEmotionSelected)
        {
            DisplayMessage($"UserA : I am sad", userAAvatar.sprite);
            DisplayMessage($"UserB : I am sad", userBAvatar.sprite);
            totalMessageCount += 2;
        }
    }

    public void OnSendSharedMessageAngry()
    {
        if(userAIsEmotionSelected && userBIsEmotionSelected)
        {
            DisplayMessage($"UserA : I am angry", userAAvatar.sprite);
            DisplayMessage($"UserB : I am angry", userBAvatar.sprite);
            totalMessageCount += 2;
        }
    }

    public void OnSendSharedMessageMixed()
    {
        if(userAIsEmotionSelected && userBIsEmotionSelected)
        {
            DisplayMessage($"UserA : I am happy", userAAvatar.sprite);
            DisplayMessage($"UserB : I am sad", userBAvatar.sprite);
            totalMessageCount += 2;
        }
    }

    public void OnSendSharedMessageMixed2()
    {
        if(userAIsEmotionSelected && userBIsEmotionSelected)
        {
            DisplayMessage($"UserA : I am sad", userAAvatar.sprite);
            DisplayMessage($"UserB : I am happy", userBAvatar.sprite);
            totalMessageCount += 2;
        }
    }

    public void OnSendSharedMessageMixed3()
    {
        if(userAIsEmotionSelected && userBIsEmotionSelected)
        {
            DisplayMessage($"UserA : I am happy", userAAvatar.sprite);
            DisplayMessage($"UserB : I am angry", userBAvatar.sprite);
            totalMessageCount += 2;
        }
    }

    public void OnSendSharedMessageMixed4()
    {
        if(userAIsEmotionSelected && userBIsEmotionSelected)
        {
            DisplayMessage($"UserA : I am angry", userAAvatar.sprite);
            DisplayMessage($"UserB : I am happy", userBAvatar.sprite);
            totalMessageCount += 2;
        }
    }

    public void OnSendSharedMessageMixed5()
    {
        if(userAIsEmotionSelected && userBIsEmotionSelected)
        {
            DisplayMessage($"UserA : I am sad", userAAvatar.sprite);
            DisplayMessage($"UserB : I am angry", userBAvatar.sprite);
            totalMessageCount += 2;
        }
    }

    public void OnSendSharedMessageMixed6()
    {
        if(userAIsEmotionSelected && userBIsEmotionSelected)
        {
            DisplayMessage($"UserA : I am angry", userAAvatar.sprite);
            DisplayMessage($"UserB : I am sad", userBAvatar.sprite);
            totalMessageCount += 2;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}