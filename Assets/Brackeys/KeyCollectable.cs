using UnityEngine;

public class KeyCollectible : MonoBehaviour
{
    [Header("What condition does this key activate?")]
    public GameObject targetCondition; 

    // This built-in Unity function listens for another 2D collider entering this object's trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the object that bumped into the key is the Player
        if (collision.CompareTag("Player"))
        {
            // 1. Activate the target condition (e.g., KeyCondition1)
            if (targetCondition != null)
            {
                targetCondition.SetActive(true);
                
                // Note: If your condition requires a specific script to be updated rather 
                // than just turning the game object on, you would call that here instead.
            }

            // 2. Destroy the key game object so it disappears from the screen
            Destroy(gameObject);
        }
    }
}
