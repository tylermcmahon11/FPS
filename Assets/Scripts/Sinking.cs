using UnityEngine;

public class Sinking : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter (Collider other) 
    {
        if (collision.gameObject.Player) 
        {
                Debug.Log("True");
        }
    }
}
