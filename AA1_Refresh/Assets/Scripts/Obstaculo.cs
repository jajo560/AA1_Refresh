using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    public Transform[] puntosMov;
    public int punto1 = 0;
    public float speed;

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, puntosMov[punto1].transform.position) < 0.1f)
        {
            punto1++;
        }

        if (punto1 == 3) 
        {
            punto1 = 0;
        }
        transform.position = Vector3.MoveTowards(transform.position, puntosMov[punto1].transform.position, speed * Time.deltaTime);
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Puntuacion.puntuacion.puntuacionGlobal -= 200;
    }

}
