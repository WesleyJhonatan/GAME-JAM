using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlerCartas : MonoBehaviour
{
    private ControlerCartas GJ;
    public int Casa = 0;
    public int ApertoGJ;
    public int cont = 0;
    public bool DesativaAmarelas;

    public GameObject VerdeA1;
    public GameObject AmarelaA1;
    public GameObject VermelhoA1;

    public GameObject VerdeA2;
    public GameObject AmarelaA2;
    public GameObject VermelhoA2;

    public GameObject VerdeA3;
    public GameObject AmarelaA3;
    public GameObject VermelhoA3;

    public GameObject VerdeA4;
    public GameObject AmarelaA4;
    public GameObject VermelhoA4;

    public GameObject VerdeA5;
    public GameObject AmarelaA5;
    public GameObject VermelhoA5;

    public GameObject VerdeA6;
    public GameObject AmarelaA6;
    public GameObject VermelhoA6;

    public GameObject VerdeA7;
    public GameObject AmarelaA7;
    public GameObject VermelhoA7;

    public GameObject VerdeA8;
    public GameObject AmarelaA8;
    public GameObject VermelhoA8;

    public GameObject VerdeA9;
    public GameObject AmarelaA9;
    public GameObject VermelhoA9;

    public GameObject VerdeA10;
    public GameObject AmarelaA10;
    public GameObject VermelhoA10;

    public int Contador1;
    public int Contador2;
    public int Contador3;
    public int Contador4;
    public int Contador5;
    public int Contador6;
    public int Contador7;
    public int Contador8;
    public int Contador9;
    public int Contador10;

    public GameObject Guarda1;
    public GameObject Guarda2;
    public GameObject Guarda3;
    public GameObject Guarda4;
    public GameObject Guarda5;
    public GameObject Guarda6;
    public GameObject Guarda7;
    public GameObject Guarda8;
    public GameObject Guarda9;
    public GameObject Guarda10;

    public bool VaiAtrascentro = false;

    public float PegaCasa1 = 0;
    public float PegaCasa2 = 0;

    public float ContPontosCartas;

    public GameObject PainelBloqueia;

    public AudioSource Clic;
    public AudioSource Folha;
    public AudioSource Certo;
    public AudioSource Errado;
    public AudioSource Ponto;

    void Start()
    {
       
    }

    void Update()
    {
        EscolheLigaSegue();

        if (DesativaAmarelas == true)
        {
            AmarelaA1.SetActive(false);
            AmarelaA2.SetActive(false);
            AmarelaA3.SetActive(false);
            AmarelaA4.SetActive(false);
            AmarelaA5.SetActive(false);
            AmarelaA6.SetActive(false);
            AmarelaA7.SetActive(false);
            AmarelaA8.SetActive(false);
            AmarelaA9.SetActive(false);
            AmarelaA10.SetActive(false);
        }

        
        if(ApertoGJ == 1)
        {
            PegaCasa1 = Casa;
        }

        if (ApertoGJ == 2)
        {
            PegaCasa2 = Casa;

                if (PegaCasa1 != PegaCasa2)
                {
                    Negado();
                    Errado.Play();
                }

                if (PegaCasa1 == PegaCasa2)
                {
                    PainelBloqueia.SetActive(true);
                    Afirmado();
                    Certo.Play();
                }

            ApertoGJ = 0;
            PegaCasa1 = 0;
            PegaCasa2 = 0;
        }

    }

    public void Negado()
    {
        cont = 0;
        DesativaAmarelas = true;
        Casa = 0;

        if (Contador1 == 1)
        {
            Contador1 = 0;
            VermelhoA1.SetActive(true);
        }

        if (Contador2 == 2)
        {
            Contador2 = 0;
            VermelhoA2.SetActive(true);
        }

        if (Contador3 == 3)
        {
            Contador3 = 0;
            VermelhoA3.SetActive(true);
        }

        if (Contador4 == 4)
        {
            Contador4 = 0;
            VermelhoA4.SetActive(true);
        }

        if (Contador5 == 5)
        {
            Contador5 = 0;
            VermelhoA5.SetActive(true);
        }

        if (Contador6 == 6)
        {
            Contador6 = 0;
            VermelhoA6.SetActive(true);
        }

        if (Contador7 == 7)
        {
            Contador7 = 0;
            VermelhoA7.SetActive(true);
        }

        if (Contador8 == 8)
        {
            Contador8 = 0;
            VermelhoA8.SetActive(true);
        }

        if (Contador9 == 9)
        {
            Contador9 = 0;
            VermelhoA9.SetActive(true);
        }

        if (Contador10 == 10)
        {
            Contador10 = 0;
            VermelhoA10.SetActive(true);
        }

        Reseta();
    }

    public void Afirmado()
    {
            if (cont == 2)
            {
                if (Casa == 2)
                {
                    VerdeA1.SetActive(true);
                    VerdeA2.SetActive(true);
                    DesativaAmarelas = true;
                    VaiAtrascentro = true;
                }

            }


            if (cont == 4)
            {
                if (Casa == 4)
                {
                    VerdeA3.SetActive(true);
                    VerdeA4.SetActive(true);
                    DesativaAmarelas = true;
                    VaiAtrascentro = true;
                }
            }

            if (cont == 6)
            {
                if (Casa == 6)
                {
                    VerdeA5.SetActive(true);
                    VerdeA6.SetActive(true);
                    DesativaAmarelas = true;
                    VaiAtrascentro = true;
                }
            }

            if (cont == 8)
            {
                if (Casa == 8)
                {
                    VerdeA7.SetActive(true);
                    VerdeA8.SetActive(true);
                    DesativaAmarelas = true;
                    VaiAtrascentro = true;
                }
            }

            if (cont == 10)
            {
                if (Casa == 10)
                {
                    VerdeA9.SetActive(true);
                    VerdeA10.SetActive(true);
                    DesativaAmarelas = true;
                    VaiAtrascentro = true;
                    
                }
            }
    }
    public void EscolheLigaSegue()
    {
        if(VaiAtrascentro == true)
        {
            if (Contador1 == 1)
            {
                Contador1 = 0;
                Guarda1.GetComponent<Animator>().Play("guardabta1");
                Guarda1.transform.SetSiblingIndex(30);
                DesativaAmarelas = true;
            }

            if (Contador2 == 2)
            {
                Contador2 = 0;
                Guarda2.GetComponent<Animator>().Play("guardabta2");
                Guarda2.transform.SetSiblingIndex(31);
                DesativaAmarelas = true;
            }

            if (Contador3 == 3)
            {
                Contador3 = 0;
                Guarda3.GetComponent<Animator>().Play("guardabtb1");
                Guarda3.transform.SetSiblingIndex(30);
                DesativaAmarelas = true;
            }

            if (Contador4 == 4)
            {
                Contador4 = 0;
                Guarda4.GetComponent<Animator>().Play("guardabtb2");
                Guarda4.transform.SetSiblingIndex(30);
                DesativaAmarelas = true;
            }

            if (Contador5 == 5)
            {
                Contador5 = 0;
                Guarda5.GetComponent<Animator>().Play("guardabtc1");
                Guarda5.transform.SetSiblingIndex(30);
                DesativaAmarelas = true;
            }

            if (Contador6 == 6)
            {
                Contador6 = 0;
                Guarda6.GetComponent<Animator>().Play("guardabtc2");
                Guarda6.transform.SetSiblingIndex(30);
                DesativaAmarelas = true;
            }

            if (Contador7 == 7)
            {
                Contador7 = 0;
                Guarda7.GetComponent<Animator>().Play("guardabtd1");
                Guarda7.transform.SetSiblingIndex(30);
                DesativaAmarelas = true;
            }

            if (Contador8 == 8)
            {
                Contador8 = 0;
                Guarda8.GetComponent<Animator>().Play("guardabtd2");
                Guarda8.transform.SetSiblingIndex(30);
                DesativaAmarelas = true;
            }

            if (Contador9 == 9)
            {
                Contador9 = 0;
                Guarda9.GetComponent<Animator>().Play("guardabtf1");
                Guarda9.transform.SetSiblingIndex(30);
                DesativaAmarelas = true;
            }

            if (Contador10 == 10)
            {
                Contador10 = 0;
                Guarda10.GetComponent<Animator>().Play("guardabtf2");
                Guarda10.transform.SetSiblingIndex(30);
                DesativaAmarelas = true;
            }

            Reseta();
        }
       

    }

    public void Reseta()
    {
        VaiAtrascentro = false;
        ApertoGJ = 0;
        cont = 0;
        Casa = 0;
    }

    public void RecebesPontosCartas(float pontos_cartas)
    {
        ContPontosCartas = ContPontosCartas + pontos_cartas;
    }

    public float RetornaPontosCartas()
    {
        return ContPontosCartas;
    }

}
