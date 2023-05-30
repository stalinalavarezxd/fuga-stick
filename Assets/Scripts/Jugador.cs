using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    public float fuerzaCorrer;
    private Rigidbody2D rigidbody2D;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            animator.SetBool("estaCorriendo",true);
            rigidbody2D.AddForce(new Vector2(fuerzaCorrer, 0));
        }
    }
}
