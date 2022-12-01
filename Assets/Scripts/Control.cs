using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{

    public float velocidad = 5.0f;
    public float velocidadGiro = 10.0f;
    public float controlHorizontal;
    public float controlAvance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Mover el carro
        //transform.Translate(0,0,1);
        controlHorizontal = Input.GetAxis("Horizontal");
        controlAvance = Input.GetAxis("Vertical");
        //transform.position += Vector3.forward * Time.deltaTime * velocidad * controlAvance;
        transform.Translate(Vector3.forward * Time.deltaTime * velocidad * controlAvance);
        //transform.Translate(Vector3.right * Time.deltaTime * 3 * controlHorizontal);
        transform.Rotate(Vector3.up, Time.deltaTime * 15 * controlHorizontal);
    }
}
