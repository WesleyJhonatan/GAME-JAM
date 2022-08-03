using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class borda : MonoBehaviour
{
    public GameObject Borda;
    private ControlerCartas GJ;
    public BTcartas scriBotoes;
    public GameObject MeuGuarda;
    public float Meuvalor;
    void Start()
    {
        GJ = GameObject.FindGameObjectWithTag("GameController").GetComponent<ControlerCartas>();
    }

    void Update()
    {
        
    }

    public void Guarda2()
    {
        MeuGuarda.GetComponent<Animator>().Play("guardaponto");
    }
    public void vermelho()
    {
        Borda.SetActive(false);
        GJ.DesativaAmarelas = false;
        scriBotoes.AperteiAma = false;
        scriBotoes.MudSprite();
        GJ.Folha.Play();
        scriBotoes.PodeClic1 = true;
        scriBotoes.PodeClic2 = true;
    }

    public void SomaPonto()
    {
        GJ.RecebesPontosCartas(Meuvalor);
        GJ.DesativaAmarelas = false;
        if (GJ.ContPontosCartas <= 4)
        {
            GJ.PainelBloqueia.SetActive(false);
        }
        GJ.Ponto.Play();
    }

    public void LigaCLicsGeral()
    {
        scriBotoes.PodeClic1 = true;
        scriBotoes.PodeClic2 = true;
    }

    public void SomFolhaInicio()
    {
        GJ.Folha.Play();
    }


}
