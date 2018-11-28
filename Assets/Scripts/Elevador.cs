using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevador : MonoBehaviour
{
    public GameObject painelElevador;
    private bool buttonIsUp;
    GameObject player, aux;
    public int zOffSet, xOffSet;

    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        zOffSet = 7;
        xOffSet = 8;
        buttonIsUp = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerOnElevatorArea())
        {
            painelElevador.SetActive(true);
        }
        else
        {
            painelElevador.SetActive(false);
        }
    }

    private bool PlayerOnElevatorArea()
    {
        return (player.transform.position.x <= (transform.position.x + xOffSet) && player.transform.position.x >= (transform.position.x - xOffSet)
            && player.transform.position.z <= (transform.position.z + zOffSet) && player.transform.position.z >= (transform.position.z - zOffSet));
    }

    public void MudarDeCena()
    {
        print("=====[mudar de cena]=====");
    }
}
