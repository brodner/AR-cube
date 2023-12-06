using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomNumberDisplay : MonoBehaviour
{
    public Text displayText; // Referencia al componente Text de la UI
    public Button PlayButton;
    public Text WinMessaje;
    public ParticleSystem ConfettiParticulas;
    public Image ContornoNumero;

    void Start()
    {
        
    }

     public void NumberRandom() 
    {
        if (displayText == null)
        {
            Debug.LogError("0");
            return;
        }

        int randomNumber = Random.Range(1, 7); // Genera un n�mero aleatorio entre 1 y 100
        displayText.text =  randomNumber.ToString(); // Muestra el n�mero aleatorio en el Texto UI
        PlayButton.gameObject.SetActive(false);
        WinMessaje.text = "";
        var emission = ConfettiParticulas.emission;
        emission.enabled = false;
        ContornoNumero.gameObject.SetActive(true);

    }

}
