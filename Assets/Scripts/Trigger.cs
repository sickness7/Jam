using UnityEngine;

public class MapEndTrigger : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the player has entered the trigger
        if (collision.gameObject.CompareTag("Player"))
        {
            /*�nica linha que deu erro na unity  (inacessivel por causa do nivel de prote��o) "?"
            GameObject.FindGameObjectWithTag("LevelCounter").GetComponent<LevelCounter>().OnTriggerEnter2D(collision);
            */
        }
    }
}