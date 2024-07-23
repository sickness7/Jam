using UnityEngine;

public class LevelCounter : MonoBehaviour
{
    public int currentLevel = 1;

    void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the player has reached the end of the map
        if (collision.gameObject.CompareTag("MapEnd"))
        {
            // Load the next map
            LoadNextMap();
            currentLevel++;
        }
    }

    void LoadNextMap()
    {
        // Implement your map loading logic here
        // For example, you could use SceneManager.LoadScene("NextMap");
    }
}