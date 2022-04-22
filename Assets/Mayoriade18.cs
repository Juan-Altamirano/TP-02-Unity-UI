using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mayoriade18 : MonoBehaviour
{
    public int edad;
    public Text mitexto;
    // Start is called before the first frame update
    void Start()
    {
        if (edad >= 18)
        {
            mitexto.text = "Sos mayor de edad";
            Debug.Log("Sos mayor de edad");
        }

        else if (edad < 18)
        {
            mitexto.text = "Sos menor de edad";
            Debug.Log("Sos menor de edad");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
