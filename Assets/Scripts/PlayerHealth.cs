using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // How much damage the player can take before it dies.
    [SerializeField] float hitPoints = 100f;

    public void TakeDamage(float damage)
    {
        hitPoints -= damage;

        if(hitPoints <= damage)
        {
            print("Player died!");
        }
    }
}
