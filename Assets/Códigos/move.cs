using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 14, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += 5f * Time.deltaTime * Vector3.down;
        if (transform.position.y > -13)

        {
        }
        
    }
}
