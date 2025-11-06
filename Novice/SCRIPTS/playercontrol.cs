using UnityEngine;
using UnityEngine.InputSystem;
[RequireComponent(typeof(Rigidbody2D), typeof(Touchdirection))]
public class playercontrol : MonoBehaviour
{
    public float walkspeed = 5f;
    public float jumpimpulse = 10f;
    Vector2 moveinput;
    [SerializeField]
    private bool _IsMoving;
    Touchdirection touchdirection;

    public bool IsMoving
    {
        get
        {
            return _IsMoving;
        }
        private set
        {
            _IsMoving = value;
        }
    }
    [SerializeField]
    private bool _IsRunning;
    public bool IsRunning
    {
        get
        {
            return _IsRunning;
        }
        private set
        {
            _IsRunning = value;
        }
    }
    Rigidbody2D rb;
    

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        touchdirection = GetComponent<Touchdirection>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(moveinput.x * walkspeed , rb.linearVelocity.y);
    }
    public void onmove(InputAction.CallbackContext context)
    {
        moveinput = context.ReadValue<Vector2>();

        IsMoving = moveinput != Vector2.zero;
    }
    public void onrun(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            IsRunning = true;
            walkspeed = walkspeed * 2;
        }
        if (context.canceled)
        {
            IsRunning = false;
            walkspeed = walkspeed / 2;
        }
    }
    public void onjump(InputAction.CallbackContext context)
    {
        // TODO: Check if alive as well
        if (context.started && touchdirection.IsGrounded)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpimpulse );
        }
    }
}
