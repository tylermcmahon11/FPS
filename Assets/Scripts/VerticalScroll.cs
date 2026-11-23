using UnityEngine;

public class VerticalScroll : MonoBehaviour
{
    [Header("Movement settings")]
    [SerializeField] float lerpSpeed = 100f;     // How fast it moves (percent per second)
    [SerializeField] float loopTime = 5f;        // Time for one full down cycle (seconds)
    [SerializeField] float startY = 5f;          // Starting Y position
    [SerializeField] float endY = -5f;           // Ending Y position

    private float t = 0f;              // Interpolation value
    private float timeSinceStart;      // Tracks time for loop

    void Start()
    {
        print("Button Pressed.");

        transform.position = new Vector3(0, startY, 0);
        timeSinceStart = Time.time;
    }

    void Update()
    {
        // Calculate progress toward the end position
        float progress = Time.time - timeSinceStart;
        float cycleProgress = progress % loopTime; // Reset progress each cycle

        // Lerp between startY and endY
        transform.position = Vector3.Lerp(
            new Vector3(0, startY, 0),
            new Vector3(0, endY, 0),
            cycleProgress / loopTime
        );

        // Reset cycle after one loop
        timeSinceStart = Time.time; // This keeps the loop running
    }
}
