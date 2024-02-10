using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seguir : MonoBehaviour
{
    [SerializeField]
    private Transform Alvo { get; set; }
    [SerializeField]
    private float forca = 1;
    private Rigidbody2D fisica;

    private void Awake()
    {
        fisica = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        var deslocamento = ((Alvo.position - transform.position).normalized) * forca;
        fisica.AddForce(deslocamento, ForceMode2D.Force);
    }

    public void SetAlvo(Transform transformAlvo)
    {
        Alvo = transformAlvo;
    }
}
