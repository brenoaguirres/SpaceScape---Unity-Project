using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NovaPontuacao : MonoBehaviour
{
    [SerializeField]
    private TextoDinamico textoPontuacao;
    private Pontuacao pontuacao;
    [SerializeField]
    private Ranking ranking;

    private void Start()
    {
        pontuacao = FindObjectOfType<Pontuacao>();
        int totalDePontos = -1;
        if (pontuacao != null)
        {
            totalDePontos = pontuacao.Pontos;
        }
        textoPontuacao.AtualizarTexto(totalDePontos);
        ranking.AdicionarPontuacao("Nome", totalDePontos);
    }
}
