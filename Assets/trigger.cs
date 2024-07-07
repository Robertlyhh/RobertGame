using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    public LogicManager logic;
    // Start is called before the first frame update
    public bool hasWon = false;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        logic.AddScore(1);
        if (logic.score >= 19 && !hasWon)
        {
            logic.GameWon();
        }
    }


}
