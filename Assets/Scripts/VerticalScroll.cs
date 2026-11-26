using UnityEngine;

public class VerticalScroll : MonoBehaviour
{
    [SerializeField] float sinkSpeed = 2f;   // Units per second, downward

    // Runs each time the component is enabled (PlayerCollisions enables it on button press)
    void OnEnable()
    {
        print("Button Pressed.");
    }

    void Update()
    {
        // Sinks continuously from wherever the objects currently are
        transform.position += Vector3.down * sinkSpeed * Time.deltaTime;
    }
}
