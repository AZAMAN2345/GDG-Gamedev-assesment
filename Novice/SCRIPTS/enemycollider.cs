using UnityEngine;

public class enemycollider : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("floor"))
        {
            Destroy(gameObject);
        }
    }
}
    
