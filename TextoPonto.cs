using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TextoPonto : MonoBehaviour
{
    public TMP_Text meuTexto;
    private ControlerCartas GJ1;
    private GameController GJ2;
    public Image Premiu;
    public ObjectVO MeuOB;
    public bool ParaSeringa = true;
    public GameObject MinhaTela;
    public GameObject MeuBtVoltar;
    void Start()
    {
        meuTexto = GetComponent<TMP_Text>();
        GJ1 = GameObject.FindGameObjectWithTag("GameController").GetComponent<ControlerCartas>();
        GJ2 = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
    }

    void Update()
    {
        meuTexto.text = GJ1.RetornaPontosCartas() + "/5";

        if(ParaSeringa == true)
        {
            if (GJ1.ContPontosCartas >= 5)
            {
                MeuBtVoltar.SetActive(true);
                ParaSeringa = false;
                GJ2.inserirObjetoNaBolsa(MeuOB);
                Destroy(MinhaTela);
            }
        }
        
    }
}
