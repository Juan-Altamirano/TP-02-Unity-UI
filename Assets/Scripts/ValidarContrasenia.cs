using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValidarContrasenia : MonoBehaviour
{
    string ContraseniaCorrecta;
    string ContraseniaUsr;
    Text IngresoUsr;
    // Start is called before the first frame update
    void Start()
    {
        ContraseniaCorrecta = "12345";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void validarContrasenia()
    {
        ContraseniaUsr = IngresoUsr.text;
    }
}
