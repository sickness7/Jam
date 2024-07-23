using UnityEngine;

public class MapEndTrigger : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the player has entered the trigger
        if (collision.gameObject.CompareTag("Player"))
        {
            /*única linha que deu erro na unity  (inacessivel por causa do nivel de proteção) "?"
            GameObject.FindGameObjectWithTag("LevelCounter").GetComponent<LevelCounter>().OnTriggerEnter2D(collision);
            */
        }
    }
}