using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameMeneger : MonoBehaviour
{
    public TextMeshProUGUI hud, msgVitoria;
    public int restantes;
    public AudioClip clipMoeda, clipVitoria;

    private AudioSource source;


    // Start is called before the first frame update
    void Start()
    {
        TryGetComponent(out source);
        restantes = FindObjectsOfType<Moeda>().Length;
        hud.text = $"moedas restantes: {restantes}";

    }

    public void SubtrairMoedas(int valor)
    {
        restantes -= valor;
        hud.text = $"moedas restantes: {restantes}";
        source.PlayOneShot(clipMoeda);
        if (restantes <= 0)
        {
            //ganhou o jogo
            msgVitoria.text = "parabéns";
            
            source.Stop();
            source.PlayOneShot(clipVitoria);
        }



    }
}