using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemRanking : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI textoColocacao;
    [SerializeField]
    private TextMeshProUGUI textoNome;
    [SerializeField]
    private TextMeshProUGUI textoPontuacao;

    public void Configurar(int colocacao, string nome, int pontuacao)
    {
        textoColocacao.text = colocacao.ToString();
        textoNome.text = nome;
        textoPontuacao.text = pontuacao.ToString();
    }
}
