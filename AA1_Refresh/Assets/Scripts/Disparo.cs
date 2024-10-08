using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    public GameObject bullet;
    public GameObject mira;
    public float speed;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
       if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bala = Instantiate(bullet, mira.transform.position, Quaternion.Euler(90,0,0));

            rb = bala.GetComponent<Rigidbody>();
            rb.AddForce(mira.transform.forward * speed, ForceMode.Impulse);  

            Destroy(bala, 3f);
        }

    }
}
