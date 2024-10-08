using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Tronco : MonoBehaviour
{
    public GameObject troncoTorreta;
    float pos_x = 0;

        // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {

        pos_x = Input.GetAxis("Mouse X");
        troncoTorreta.transform.localEulerAngles = transform.localEulerAngles + new Vector3(0, pos_x, 0);

    }
}
