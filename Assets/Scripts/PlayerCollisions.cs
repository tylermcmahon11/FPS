using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    public bool buttonHit = false;

    [SerializeField] GameObject sinkingObject;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }


    // Regular collision detection
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        // Checking if we're hitting the SomeTag
        if(hit.gameObject.tag == "StartButton")
        {
            if (!buttonHit)
            {
                buttonHit = true;

                if (sinkingObject != null)
                {
                    VerticalScroll startMove = sinkingObject.GetComponent<VerticalScroll>();

                    if (startMove != null)
                    {
                        startMove.enabled = true;
                    }
                }
            }
            else
            {
                return;
            }
        }
    }

    // Trigger collision detection
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "SomeTag")
        {
            // Debug.Log("Hit the thing!");
            // Other code here
        }
    }

    // Trigger exit detection
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "SomeTag")
        {
            // Debug.Log("Left the thing!");
            // Other code here
        }
    }
}