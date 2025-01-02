using UnityEngine;

public class Basket : MonoBehaviour
{
    bool isClickable = false; // Tracks if the sprite is clickable
    bool isInteractable = true;
    PutSleepBaby putSleepBaby;

    public Transform basketOutline;
    

    void Start()
    {
        basketOutline.gameObject.SetActive(false);
        
        putSleepBaby = FindObjectOfType<PutSleepBaby>();

        isClickable = false;
        isInteractable = true;
    }

    void Update()
    {
        // Check for mouse click
        if (isInteractable && isClickable && Input.GetMouseButtonDown(0))
        {
            putSleepBaby.PlayPutToSleepAnim();
            isInteractable = false;
        }
    }

    void OnMouseEnter()
    {
        // Enable the outline when the cursor hovers over the sprite
        basketOutline.gameObject.SetActive(true);
        isClickable = true;
    }

    void OnMouseExit()
    {
        // Disable the outline when the cursor leaves the sprite
        basketOutline.gameObject.SetActive(false);
        isClickable = false;
    }

}
