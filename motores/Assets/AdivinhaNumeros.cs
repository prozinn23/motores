using UnityEngine;
using System;
using Unity.VisualScripting;
using Random = System.Random;

public class AdivinhaNumero : MonoBehaviour
{
    public int numero;
    
    private bool resposta;

    private int menor = 0;
    private int maior = 10;
    private int numeroDeTentativas = 10;
    
    bool oJogoEstaRodando = true;
    
    Random rand = new Random();
    private int sorteado;
    
    void Start()
    {
        sorteado = rand.Next(menor, maior+1);
      
        Debug.Log("Pensei em um número entre "+menor+ " e " + maior+", tente adivinhar.");
    }

    void Update()
    {
        //testa o numero quando aparte a tecla de espaço
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Você tem " + numeroDeTentativas + " tentativas!");
            int numeroDigitaDo = numero;

            if (numeroDigitaDo < sorteado)
            {
                Debug.Log("Muito Bixo. Tente novamente.");
                numeroDeTentativas--;
            }
            else if (numeroDigitaDo > sorteado)
            {
                Debug.Log("Muito Alto. Tente novamente.");
                numeroDeTentativas--;
            }
            else
            {
                Debug.Log("Parabéns, voce acertou!");
            }

            if (numeroDeTentativas == 0)
            {
                Debug.Log("Suas tentavivas acabanram. O número que pessei foi: "+sorteado);
                oJogoEstaRodando = false;
            }

        }
        
        
    }
    
    
    
}