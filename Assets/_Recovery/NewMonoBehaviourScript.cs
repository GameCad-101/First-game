using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    [Header("Settings")]
    public string sceneToLoad;
    public int coinsNeeded = 5;

    [Header("Color Settings")]
    public Color lockedColor = Color.red;
    public Color unlockedColor = Color.green;

    // Keep this public so EnemyHealth.cs doesn't break!
    [HideInInspector] public bool unlocked = false;
    
    private int currentCoins = 0;
    private bool playerNear = false;
    private SpriteRenderer spriteRenderer;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        
        // Set the starting color to locked
        if (spriteRenderer != null)
        {
            spriteRenderer.color = lockedColor;
        }
    }

    void Update()
    {
        // Enter the door if unlocked, player is near, and E is pressed
        if (playerNear && unlocked && Input.GetKeyDown(KeyCode.E))
        {
            if (!string.IsNullOrEmpty(sceneToLoad))
            {
                SceneManager.LoadScene(sceneToLoad);
            }
            else
            {
                Debug.LogWarning("Please enter a scene name in the Inspector!");
            }
        }
    }

    public void AddCoin()
    {
        currentCoins++;
        Debug.Log($"Coins: {currentCoins}/{coinsNeeded}");

        if (currentCoins >= coinsNeeded && !unlocked)
        {
            UnlockDoor();
        }
    }

    private void UnlockDoor()
    {
        unlocked = true;
        
        // Change the color to the "Unlocked" color
        if (spriteRenderer != null)
        {
            spriteRenderer.color = unlockedColor;
        }
        
        Debug.Log("Door unlocked! Visual color changed.");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) playerNear = true;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player")) playerNear = false;
    }
}
