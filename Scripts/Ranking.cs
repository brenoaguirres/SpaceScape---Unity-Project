using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using UnityEngine;

public class Ranking : MonoBehaviour
{
    public static string NOME_DO_ARQUIVO = "Ranking.json";
    [SerializeField]
    private List<Colocado> listaDeColocados;
    private string caminhoParaOArquivo;

    private void Awake()
    {
        caminhoParaOArquivo = Path.Combine(Application.persistentDataPath,
            NOME_DO_ARQUIVO);
        if(File.Exists(caminhoParaOArquivo))
        {
            string textoJson = File.ReadAllText(caminhoParaOArquivo);
            JsonUtility.FromJsonOverwrite(textoJson, new ListaColocadosJson(listaDeColocados));
        }
        else
        {
            listaDeColocados = new List<Colocado>();
        }
    }

    public void AdicionarPontuacao(string nome, int pontos)
    {
        Colocado novoColocado = new Colocado(nome, pontos);
        listaDeColocados.Add(novoColocado);
        SalvarRanking();
    }

    public int Quantidade()
    {
        return listaDeColocados.Count;
    }

    public ReadOnlyCollection<Colocado> GetColocados()
    {
        return listaDeColocados.AsReadOnly();
    }

    private void SalvarRanking()
    {
        //XML, JSON, BIN
        string textoJson = JsonUtility.ToJson(new ListaColocadosJson(listaDeColocados));
        File.WriteAllText(caminhoParaOArquivo, textoJson);
    }
}

[Serializable]
public class Colocado
{
    public string nome;
    public int pontos;

    public Colocado(string nome, int pontos)
    {
        this.nome = nome;
        this.pontos = pontos;
    }
}

[Serializable]
public class ListaColocadosJson
{
    public List<Colocado> lista;
    public ListaColocadosJson(List<Colocado> lista)
    {
        this.lista = lista;
    }
}