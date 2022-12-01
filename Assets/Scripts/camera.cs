using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    private Vector3 Desplazamiento = new Vector3(-9,4,5);
    public GameObject jugador;
    public float controlHorizontal;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        controlHorizontal = Input.GetAxis("Horizontal");
        transform.position = jugador.transform.position + Desplazamiento;
        transform.Rotate = jugador.transform.Rotate;
    }
}
