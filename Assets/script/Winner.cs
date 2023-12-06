using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Winner : MonoBehaviour
{
    public Text NumeroGanadorGenerado;
    public Text WinMessaje;
    public Button PlayButton;
    public ParticleSystem ConfettiParticulas;
    // Start is called before the first frame update
    void Start()
    {
        var emission = ConfettiParticulas.emission;
        emission.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Comparar(int numero)
    {
        var emission = ConfettiParticulas.emission;
        if (NumeroGanadorGenerado.text.Length != 0)
        {
            int NumeroGanadorParse = int.Parse(NumeroGanadorGenerado.text);
            if (NumeroGanadorParse == numero)
            {
                WinMessaje.text = "Bien Lanzado!!";
                emission.enabled = true;
                PlayButton.gameObject.SetActive(true);
            }
            else {
                WinMessaje.text = "Que lastima intenta de nuevo!!";
                PlayButton.gameObject.SetActive(true);
                NumeroGanadorGenerado.text = "";
            }
        }
    }
}
