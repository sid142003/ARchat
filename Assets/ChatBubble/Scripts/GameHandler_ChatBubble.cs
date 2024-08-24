using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public class GameHandler_ChatBubble : MonoBehaviour {

    [SerializeField] private Transform playerTransform;
    [SerializeField] private Transform[] npcTransformArray;

    private int npcIndex;

    private void Start() {
        ChatBubble.Create(playerTransform, new Vector3(3, 8), ChatBubble.IconType.Neutral, "Here is some text!");

        FunctionPeriodic.Create(() => {
            Transform npcTransform = npcTransformArray[npcIndex];
            npcIndex = (npcIndex + 1) % npcTransformArray.Length;
            string message = GetRandomMessage();

            ChatBubble.IconType[] iconArray = 
                new ChatBubble.IconType[] { ChatBubble.IconType.Happy, ChatBubble.IconType.Neutral, ChatBubble.IconType.Angry };
            ChatBubble.IconType icon = iconArray[Random.Range(0, iconArray.Length)];

            ChatBubble.Create(npcTransform, new Vector3(3, 8), icon, message);
            
        }, 1.5f);
    }

    private string GetRandomMessage() {
        string[] messageArray = new string[] { 
            "Hello Everyone!",
            "Very Nice Project by Smurf_AR!",
            "I'm having so much fun walking around!",
            "I'm really sad about something.",
            "Can you be more clear?",
            "We lost the Worldcup!",
            "Rohit deserved to win, guys",
            "Choro yrr hatao ab jo ho gaya so ho gaya",
            "2023 => 2 + 0 + 2 + 3 = 7",
            "Bole jo koyal, baago mein",
        };

        return messageArray[Random.Range(0, messageArray.Length)];
    }

}
