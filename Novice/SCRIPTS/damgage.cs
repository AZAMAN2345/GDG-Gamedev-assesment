using UnityEngine;

public class damgage : MonoBehaviour
{
    public playerhealth phealth;
    public float damage;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("player"))
        {
           other.gameObject.GetComponent<playerhealth>().health -= damage;
        }
    }
}
