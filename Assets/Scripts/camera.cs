using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    private Vector3 Desplazamiento = new Vector3(7,4,4);
    public GameObject jugador;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position = jugador.transform.position + Desplazamiento;
        
    }
}
