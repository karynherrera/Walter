using UnityEngine;

public class Jugador : MonoBehaviour
{
    public Animator anim;
    public float movementX;
    public float movementY;
    public float vlcdd;
    public Rigidbody2D rgby2d;
    public Vector2 vt2;
    public bool lookRight;
    public bool lookLeft;
    public bool lookUp;


    
    void Start()
    {
        rgby2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {

        movementX = Input.GetAxisRaw("Horizontal");
        movementY = Input.GetAxisRaw("Vertical");
        vt2 = new Vector2(movementX, movementY).normalized;
        rgby2d.linearVelocity = vt2 * vlcdd;

        if (movementX < 0)
        {
            anim.SetBool("Izquierda", true);
        }
        else
        {
            anim.SetBool("Izquierda", false);
        }

        if (movementX > 0)
        {
            anim.SetBool("Derecha", true);
        }
        else
        {
            anim.SetBool("Derecha", false);
        }

        if (movementY > 0)
        {
            anim.SetBool("Arriba", true);
        }
        else
        {
            anim.SetBool("Arriba", false);
        }
    }

}
