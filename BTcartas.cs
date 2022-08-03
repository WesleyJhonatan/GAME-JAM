using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BTcartas : MonoBehaviour
{
    private ControlerCartas GJ;
    public Sprite Sp1;
    public Sprite Sp2;
    public GameObject Amarela;
    public bool AperteiAma = false;
    public int MeuValorContador;
    public bool PodeClic1 = false;
    public bool PodeClic2 = false;

    public bool ParaAlmenta = true;
    public Image MeuBotaoImage;
    public float contador;
    public float Velocidade;

    public GameObject MeuGuardaAnimator;

    void Start()
    {
        GJ = GameObject.FindGameObjectWithTag("GameController").GetComponent<ControlerCartas>();
    }

    void Update()
    {
        if (ParaAlmenta == true)
        {
            MeuBotaoImage.color = new Color(1, 1, 1, contador += Velocidade * Time.unscaledDeltaTime);

            if (contador >= 1)
            {
                ParaAlmenta = false;
                contador = 1;
                MeuBotaoImage.color = new Color(1, 1, 1, 1);
                MeuGuardaAnimator.GetComponent<Animator>().enabled = true;
            }
        }
    }

    public void CartaA1()
    {
        if(PodeClic1 == true)
        {
            PodeClic1 = false;
            OnMouseEnter();
            GetComponent<Image>().sprite = Sp1;
            GJ.cont = GJ.cont + 1;
            GJ.Casa = 2;
            GJ.ApertoGJ = GJ.ApertoGJ + 1;
            AperteiAma = true;
            GJ.Clic.Play();
            GJ.Folha.Play();
        }
        
        
    }

    public void CartaB1()
    {
        if (PodeClic1 == true)
        {
            PodeClic1 = false;
            OnMouseEnter();
            GetComponent<Image>().sprite = Sp1;
            GJ.cont = GJ.cont + 2;
            GJ.Casa = 4;
            GJ.ApertoGJ = GJ.ApertoGJ + 1;
            AperteiAma = true;
            GJ.Clic.Play();
            GJ.Folha.Play();
        }
           
    }

    public void CartaC1()
    {
        if (PodeClic1 == true)
        {
            PodeClic1 = false;
            OnMouseEnter();
            GetComponent<Image>().sprite = Sp1;
            GJ.cont = GJ.cont + 3;
            GJ.Casa = 6;
            GJ.ApertoGJ = GJ.ApertoGJ + 1;
            AperteiAma = true;
            GJ.Clic.Play();
            GJ.Folha.Play();
        }
           
    }

    public void CartaD1()
    {
        if (PodeClic1 == true)
        {
            PodeClic1 = false;
            OnMouseEnter();
            GetComponent<Image>().sprite = Sp1;
            GJ.cont = GJ.cont + 4;
            GJ.Casa = 8;
            GJ.ApertoGJ = GJ.ApertoGJ + 1;
            AperteiAma = true;
            GJ.Clic.Play();
            GJ.Folha.Play();
        }
          
    }

    public void CartaF1()
    {
        if (PodeClic1 == true)
        {
            PodeClic1 = false;
            OnMouseEnter();
            GetComponent<Image>().sprite = Sp1;
            GJ.cont = GJ.cont + 5;
            GJ.Casa = 10;
            GJ.ApertoGJ = GJ.ApertoGJ + 1;
            AperteiAma = true;
            GJ.Clic.Play();
            GJ.Folha.Play();
        }
           
    }

    private void OnMouseEnter()
    {
        if (AperteiAma == false)
        {
            Amarela.SetActive(true);
        }
           
    }

    private void OnMouseExit()
    {
        if(AperteiAma == false)
        {
            Amarela.SetActive(false);
        }
           
    }

    public void BT1()
    {
        if (PodeClic2 == true)
        {
            PodeClic2 = false;
            GJ.Contador1 = MeuValorContador;
        }
           
    }

    public void BT2()
    {
        if (PodeClic2 == true)
        {
            PodeClic2 = false;
            GJ.Contador2 = MeuValorContador;
        }
           
    }

    public void BT3()
    {
        if (PodeClic2 == true)
        {
            PodeClic2 = false;
            GJ.Contador3 = MeuValorContador;
        }
            
    }

    public void BT4()
    {
        if (PodeClic2 == true)
        {
            PodeClic2 = false;
            GJ.Contador4 = MeuValorContador;
        }
           
    }

    public void BT5()
    {
        if (PodeClic2 == true)
        {
            PodeClic2 = false;
            GJ.Contador5 = MeuValorContador;
        }
           
    }

    public void BT6()
    {
        if (PodeClic2 == true)
        {
            PodeClic2 = false;
            GJ.Contador6 = MeuValorContador;
        }
           
    }
    public void BT7()
    {
        if (PodeClic2 == true)
        {
            PodeClic2 = false;
            GJ.Contador7 = MeuValorContador;
        }
           
    }

    public void BT8()
    {
        if (PodeClic2 == true)
        {
            PodeClic2 = false;
            GJ.Contador8 = MeuValorContador;
        }
          
    }

    public void BT9()
    {
        if (PodeClic2 == true)
        {
            PodeClic2 = false;
            GJ.Contador9 = MeuValorContador;
        }
           
    }

    public void BT10()
    {
        if (PodeClic2 == true)
        {
            PodeClic2 = false;
            GJ.Contador10 = MeuValorContador;
        }
           
    }

    public void MudSprite()
    {
            GetComponent<Image>().sprite = Sp2;
       
    }
    //public void OnMouseDown()
    //{

    //}
}

