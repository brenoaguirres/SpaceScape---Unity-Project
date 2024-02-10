using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextoDinamico : MonoBehaviour
{
    private TextMeshProUGUI texto;

    private void Awake()
    {
        texto = GetComponent<TextMeshProUGUI>();
    }

    public void AtualizarTexto(int numero)
    {
        texto.text = numero.ToString();
    }
}
