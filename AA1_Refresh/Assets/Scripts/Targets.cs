using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Targets : MonoBehaviour
{
    private float contadorFinal = 3f;
    private float contador;
    public GameObject target;
    public GameObject targetDestruido;
    public GameObject bullet;    
    public MeshRenderer Mesh;

    private Collider Collider;

    // Start is called before the first frame update
    void Start()
    {
        Collider = GetComponent<Collider>();
        Mesh = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (contador < contadorFinal)
        {
            contador += Time.deltaTime;
            Debug.Log(contador);
        }
        
        if (contador >= 3) {
            Collider.enabled = true;
            Mesh.enabled = true;
            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Bala")) 
        {
            Collider.enabled = false;
            Mesh.enabled = false;

            GameObject roto = Instantiate(targetDestruido, transform.position, Quaternion.Euler(90,0,0));
            Destroy(roto, 2.5f);
            
            contador = 0f;
           
        }
        
    }


}
