using UnityEngine;

public class collider : MonoBehaviour
{
    public playercontroller _playercontroller;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "enemy")
        {
            Gameover();
        }
    }
    void Gameover()
    {
        _playercontroller.enabled = false;
        missioncomplete();
    }
    void missioncomplete()
    {
        Debug.Log("Game Over");
    }
}
