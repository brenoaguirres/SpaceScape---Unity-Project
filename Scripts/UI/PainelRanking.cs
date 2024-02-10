using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PainelRanking : MonoBehaviour
{
    [SerializeField]
    private Ranking ranking;
    [SerializeField]
    private GameObject prefabColocado;
    private void Start()
    {
        var quantidade = ranking.Quantidade();
        var listaDeColocados = ranking.GetColocados();
        for (var i = 0; i < quantidade; i++)
        {
            if (i >= 5)
            {
                break;
            }
            var colocado = Instantiate(prefabColocado, transform);
            colocado.GetComponent<ItemRanking>().Configurar(i, 
                listaDeColocados[i].nome, 
                listaDeColocados[i].pontos);
        }
    }
}
