using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class gameManeger : MonoBehaviour
{

    public TextMeshProUGUI hud, msgVitoria;

    public int restantes;    
    // Start is called before the first frame update
    void Start()
    {
        restantes = FindObjectsOfType<Moeda>().Length;

        
        hud.text = $"moedas restantes: {restantes}";
    }

    public void SubtrairMoedas(int valor)
    {
        restantes -= valor;
        hud.text = $"moedas restantes: {restantes}";

        if (restantes <= 0)
        {
            //ganhou o jogo 
            msgVitoria.text = "parabéns";
        }
    }
    
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
