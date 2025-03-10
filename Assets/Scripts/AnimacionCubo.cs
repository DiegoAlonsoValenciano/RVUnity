using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacionCubo : MonoBehaviour
{
    private bool Espada = false;
    private bool Sombrero = false;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Espada && Sombrero)
        {
            animator.SetBool("Colocado",true);
        }
        else
        {
            animator.SetBool("Colocado", false);
        }
    }

    public void EspadaInteraccion()
    {
        Espada = !Espada;
        Debug.Log("Espada:" + Espada);
    }

    public void SombreInteraccion()
    { 
        Sombrero = !Sombrero;
        Debug.Log("Sombrero:" + Sombrero);
    }
}
