using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effects : MonoBehaviour
{
    public GameObject effectss;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.tag == "ball")
        {
            GameObject eff = Instantiate(effectss, other.transform.position, Quaternion.identity);

            Destroy(eff, 2f);
        }
    }
}
