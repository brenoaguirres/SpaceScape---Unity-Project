using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Pontuacao : MonoBehaviour
{
    public int Pontos { get; private set; }
    [SerializeField]
    private MeuEventoPersonalizadoInt aoPontuar;

    public void Pontuar()
    {
        Pontos++;
        aoPontuar.Invoke(Pontos);
    }
}

[Serializable]
public class MeuEventoPersonalizadoInt : UnityEvent<int>
{

}
