using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntaje : MonoBehaviour
{
    public float valor;
    public Puntaje puntaje;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        valor = 0;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Puntaje " + puntaje.valor;
    }
}
