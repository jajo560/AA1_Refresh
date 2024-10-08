using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Puntuacion : MonoBehaviour
{
    public float puntuacionGlobal = 0f;
    public GameObject texto_puntuacion;
    public TextMeshProUGUI text;
    public static Puntuacion puntuacion;
    // Start is called before the first frame update
    void Start()
    {
        if (puntuacion == null)
        {
            puntuacion = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        text.text = puntuacionGlobal.ToString("F0");
    }
}
