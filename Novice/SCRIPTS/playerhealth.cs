using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;
public class playerhealth : MonoBehaviour
{
    public float health;
    public float maxhealth;
    public Image healthbar;
    private bool isdead;
    public GAMEMANAGER gamemanager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        maxhealth = health;
    }

    // Update is called once per frame
    void Update()
    {
        healthbar.fillAmount = Mathf.Clamp(health / maxhealth, 0, 1);
        if (health <= 0 && !isdead)
        {
            isdead = true;
            gamemanager.gameOver();
            Destroy(gameObject);
        }
    }
}
