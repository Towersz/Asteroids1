using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public Rigidbody2D rdb;
    public float velocidade = 10;
    public SpriteRenderer fogo1;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, -7, 0);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate() // fixed update é chamado a cada frame, porém com um tempo fixo
    {
        Movimentos();

    }

    void Movimentos()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rdb.AddTorque(velocidade);  //adciona força para a direita
        }
        if (Input.GetKey(KeyCode.A))
        {
            rdb.AddTorque(-velocidade);
        }
        if ((Input.GetKey(KeyCode.W)))
        {
            rdb.AddRelativeForce(Vector2.up * velocidade);
            fogo1.enabled = true;
        }
        else
        {
            fogo1.enabled = false;
        }

    }

    void Retorno()
    {
        if (transform.position.y <= -10)
        {
           
        }
        if (transform.position.y >= 10)
        {

        }
    }
}
