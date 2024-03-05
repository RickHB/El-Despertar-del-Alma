using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje1 : MonoBehaviour
{
    public float velocidadMov = 5.0f;
    public float velocidadRota = 200.0f;
    public float x, y;
    private Animator anim; // Declare anim variable

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        transform.Rotate(0, x * Time.deltaTime * velocidadRota, 0);
        transform.Translate(0, 0, y * Time.deltaTime * velocidadMov);

        anim.SetFloat("VelX", x);
        anim.SetFloat("VelY", y);
    }
}
