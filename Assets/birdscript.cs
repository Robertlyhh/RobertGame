using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdscript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float jumpForce = 5;
    public LogicManager logic;
    public bool isDead = false;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isDead)
        {
            myRigidbody.velocity = new Vector2(0, jumpForce);
        }
        FallOutOfScreen();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(logic.score < 19)
        {
            isDead = true;
            logic.GameOver();
        }
    }

    private void FallOutOfScreen()
    {
        if (transform.position.y < -20 && logic.score < 19)
        {
            isDead = true;
            logic.GameOver();
        }
    }

}
