using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementAI : MonoBehaviour
{
    public Transform player1;
    public Transform player2;
    private float player1Input;
    private float player2Input;
    public Transform ballPos = null;
    public float speed = 7f;
    public float AIspeed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        player1Input = Input.GetAxisRaw("Vertical1");
        player1.position += new Vector3(0, speed*player1Input*Time.deltaTime, 0);
        player2.Translate(new Vector3(0, (ballPos.position.y - player2.position.y), 0f)* AIspeed);
    }
    
}