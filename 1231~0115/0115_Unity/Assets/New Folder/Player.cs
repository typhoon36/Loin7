using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Speed = 2f;



    private void Start()
    {

    }

    private void Update()
    {
        //Move
        transform.Translate(Vector3.up * Speed * Time.deltaTime);
    }

}


