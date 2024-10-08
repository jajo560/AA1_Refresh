using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cañon : MonoBehaviour
{
    public GameObject troncoTorreta;
    float pos_y = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pos_y = Input.GetAxis("Mouse Y");
        troncoTorreta.transform.localEulerAngles = transform.localEulerAngles + new Vector3(-pos_y, 0, 0);
    }
}
