using UnityEngine;

public class ButtonSwitch : MonoBehaviour
{
    bool isClickable = false; // Tracks if the sprite is clickable
    bool isInteractable = true;

    public Transform buttonOutline, buttonOff;

    void Start()
    {
        buttonOutline.gameObject.SetActive(false);
        buttonOff.gameObject.SetActive(false);
        
        isClickable = false;
        isInteractable = true;
    }

    void Update()
    {
        // Check for mouse click
        if (isInteractable && isClickable && Input.GetMouseButtonDown(0))
        {
            isInteractable = false;
            buttonOff.gameObject.SetActive(true);
            buttonOutline.gameObject.SetActive(false);
            gameObject.SetActive(false);
        }
    }

    void OnMouseEnter()
    {
        // Enable the outline when the cursor hovers over the sprite
        buttonOutline.gameObject.SetActive(true);
        isClickable = true;
    }

    void OnMouseExit()
    {
        // Disable the outline when the cursor leaves the sprite
        buttonOutline.gameObject.SetActive(false);
        isClickable = false;
    }

}
