using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    GameObject startButton;
    GameObject endButton;
    VerticalScroll verticalScroll;
    bool hasScrolled;   // Set when the scroll starts so it can't start again

    void OnEnable()
    {
        // Find the buttons by tag, then the (disabled) VerticalScroll on the start button's parent
        startButton = GameObject.FindWithTag("StartButton");
        endButton = GameObject.FindWithTag("EndButton");

        if (startButton != null)
        {
            verticalScroll = startButton.GetComponentInParent<VerticalScroll>();
        }
    }

    void OnControllerColliderHit(ControllerColliderHit collision)
    {
        if (verticalScroll == null)
        {
            return;
        }

        if (collision.gameObject == startButton && !hasScrolled)
        {
            verticalScroll.enabled = true;
            hasScrolled = true;
        }
        else if (collision.gameObject == endButton && verticalScroll.enabled)
        {
            verticalScroll.enabled = false;
        }
    }
}
