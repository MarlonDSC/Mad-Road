using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gasolina : MonoBehaviour
{
    public Image imageBarraGasolina;

    public float MaxGasolina = 100.00f;
    public float GasolinaAct = 100.00f;

    GameManager manager;

    // Start is called before the first frame update
    void Start()
    {
        imageBarraGasolina.fillAmount = 100;
        manager = GameObject.FindObjectOfType<GameManager>();

    }

    // Update is called once per frame
    void Update()
    {
        //Asegurar que la gasolina no pase de 100 para que no se stackee
        if (GasolinaAct > 100)
            GasolinaAct = 100;

        //Actualizar el fill amount de la imagen
        imageBarraGasolina.fillAmount = GasolinaAct / MaxGasolina;

        //Reducir cantidad de gasolina
        GasolinaAct -= Time.deltaTime * 2;

        //Si me quedo sin gasolina se acabo el juego
        if (GasolinaAct <= 0)
            manager.GameOver();
    }

    
}
