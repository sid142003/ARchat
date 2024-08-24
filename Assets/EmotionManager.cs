using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EmotionManager : MonoBehaviour
{
    public Image happyButton;
    public Image sadButton;
    public Image angryButton;
    public Image restoreButton;

    public Sprite sharedHappy;
    public Sprite sharedSad;
    public Sprite sharedAngry;

    private Sprite originalHappy;
    private Sprite originalSad;
    private Sprite originalAngry;

    private bool emotionSelected = false;

    private void Start()
    {
        originalHappy = happyButton.sprite;
        originalSad = sadButton.sprite;
        originalAngry = angryButton.sprite;
        // Attach the click event listeners
        happyButton.GetComponent<Button>().onClick.AddListener(OnHappyClicked);
        sadButton.GetComponent<Button>().onClick.AddListener(OnSadClicked);
        angryButton.GetComponent<Button>().onClick.AddListener(OnAngryClicked);

        // Initially disable the Restore button
        SetImageRaycastTarget(restoreButton, false);
    }

    private void DisableOtherButtons(Image clickedButton)
    {
        // Disable other buttons when one is clicked
        if (clickedButton != happyButton)
        {
            SetButtonInteractable(happyButton, false);
        }
        if (clickedButton != sadButton)
        {
            SetButtonInteractable(sadButton, false);
        }
        if (clickedButton != angryButton)
        {
            SetButtonInteractable(angryButton, false);
        }
    }

    private void EnableAllButtons()
    {
        // Enable all emotion buttons
        SetButtonInteractable(happyButton, true);
        SetButtonInteractable(sadButton, true);
        SetButtonInteractable(angryButton, true);
    }

    private void SetButtonInteractable(Image buttonImage, bool interactable)
    {
        // Disable or enable the button by setting Raycast Target
        buttonImage.GetComponent<Button>().interactable = interactable;
        SetImageRaycastTarget(buttonImage, interactable);
    }

    private void SetImageRaycastTarget(Image image, bool raycastTarget)
    {
        // Enable or disable Raycast Target for the Image
        image.raycastTarget = raycastTarget;
    }

    public void OnHappyClicked()
    {
        happyButton.sprite = sharedHappy;
        emotionSelected = true;
        DisableOtherButtons(happyButton);
        SetButtonInteractable(restoreButton, true);
    }

    public void OnSadClicked()
    {
        sadButton.sprite = sharedSad;
        emotionSelected = true;
        DisableOtherButtons(sadButton);
        SetButtonInteractable(restoreButton, true);
    }

    public void OnAngryClicked()
    {
        angryButton.sprite = sharedAngry;
        emotionSelected = true;
        DisableOtherButtons(angryButton);
        SetButtonInteractable(restoreButton, true);
    }

    public void OnRestoreClicked()
    {
        // Restore all buttons to their initial state
        happyButton.sprite = originalHappy; // You might want to set it to a default sprite if needed
        sadButton.sprite = originalSad;
        angryButton.sprite = originalAngry;

        EnableAllButtons();

        // Disable the Restore button again
        SetButtonInteractable(restoreButton, false);
    }
}
