using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeMove : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 10;
    public float destroyPosition = -43;
    public LogicManager logic;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicManager>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        if (transform.position.x < destroyPosition)
        {
            Destroy(gameObject);
        }
        if(logic.score >= 19)
        {
            speed = 0;
        }

    }
}
