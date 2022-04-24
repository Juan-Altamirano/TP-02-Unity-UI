using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValidarContrasenia : MonoBehaviour
{
    string ContraseniaCorrecta;
    string ContraseniaUsr;
    public Text IngresoUsr;
    public Text textoMsj;
    public GameObject cartelitoMsj;
    // Start is called before the first frame update
    void Start()
    {
        ContraseniaCorrecta = "12345";
        cartelitoMsj.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void validarContrasenia()
    {
        ContraseniaUsr = IngresoUsr.text;

        if (ContraseniaUsr == ContraseniaCorrecta)
        {
            cartelitoMsj.SetActive(true);
            textoMsj.text = "Bienvenido";
            Debug.Log("Bienvenido");
        }

        else
        {
            cartelitoMsj.SetActive(true);
            textoMsj.text = "Contraseña Incorrecta";
            Debug.Log("Cotraseña incorrecta");
        }
    }
}
