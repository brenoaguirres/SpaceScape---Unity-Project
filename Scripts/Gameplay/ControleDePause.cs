using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleDePause : MonoBehaviour
{
    [SerializeField]
    private GameObject PainelPause;
    private float fixedTimeStep = 0.02f;
    [SerializeField, Range(0, 1)]
    private float escalaDeTempoDurantePause = 0f;
    private bool jogoEstaParado;

    private void Update()
    {
        if(EstaoTocandoNaTela())
        {
            if (jogoEstaParado)
                ContinuarJogo();
        }
        else
        {
            if (!jogoEstaParado)
                PararJogo();
        }
    }

    private void ContinuarJogo()
    {
        StartCoroutine(EsperarEContinuarOJogo());
    }

    private IEnumerator EsperarEContinuarOJogo()
    {
        yield return new WaitForSecondsRealtime(0.1f);
        PainelPause.SetActive(false);
        MudarEscalaDeTempo(1);
        jogoEstaParado = false;
    }

    private void PararJogo()
    {
        PainelPause.SetActive(true);
        MudarEscalaDeTempo(escalaDeTempoDurantePause);
        jogoEstaParado = true;
    }

    private bool EstaoTocandoNaTela()
    {
        return Input.touchCount > 0;
    }

    private void MudarEscalaDeTempo(float escala)
    {
        Time.timeScale = escala;
        Time.fixedDeltaTime = fixedTimeStep * Time.timeScale;
    }
}
