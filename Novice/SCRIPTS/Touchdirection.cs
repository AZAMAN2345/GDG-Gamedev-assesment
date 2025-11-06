using UnityEngine;
//uses the collider to check directions to see if the objrct is currently on the ground , touching the wall, or touching the ceiling
public class Touchdirection : MonoBehaviour
{
    public ContactFilter2D castfilter;
    public float groundDistance = 0.05f;
    RaycastHit2D[] groundHits = new RaycastHit2D[5];
    [SerializeField]
    private bool _IsGrounded;
    CapsuleCollider2D touchcol;

    public bool IsGrounded {
        get
        {
            return _IsGrounded;
        } private set
        {
            _IsGrounded = value;
        } }

    void Awake()
    {
        touchcol = GetComponent<CapsuleCollider2D>();
    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
  IsGrounded = touchcol.Cast(Vector2.down, castfilter, groundHits, groundDistance) > 0;
    }

}
