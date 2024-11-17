using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.VirtualTexturing;

public class characterscript2 : MonoBehaviour
{
    public Rigidbody2D myCharacter;
    public float charStrenght;
    public logicSystem logic;
    public bool birdIsAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive == true)
        {
            myCharacter.velocity = Vector2.up * charStrenght;
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
       logic.gameOver();
        birdIsAlive = false;
    }
}
