using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Transform player1;
    public Transform player2;
    private float player1Input;
    private float player2Input;
    static public float speed = 7f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        player1Input = Input.GetAxisRaw("Vertical1");
        player1.position += new Vector3(0, speed*player1Input*Time.deltaTime, 0);

        player2Input = Input.GetAxisRaw("Vertical2");
        player2.position += new Vector3(0, speed*player2Input*Time.deltaTime, 0);

    }
    
}
