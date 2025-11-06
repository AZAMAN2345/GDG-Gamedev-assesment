using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    public playercontrol _playercontrol;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "enemy")
        {
            Gameover();
        }
    }
    void Gameover()
    {
        _playercontrol.enabled = false;
        missioncomplete();
    }
    void missioncomplete()
    {
        Debug.Log("Game Over");
    }
}
