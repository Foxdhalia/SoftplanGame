using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class catraca : MonoBehaviour
{
    //Máximo Michael Colodetti Dias
    //Angulo Original:X:0, Y:220, Z:275;

    Transform girarCatraca;
    public float velZ = 240;

    //Trava e destrava
    bool ladoFora;
    bool ladoDentro;
    // Use this for initialization
    void Start()
    {
        girarCatraca = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //Verifica se o gameObject com a tag barreira se encontra no jogo
        if (GameObject.FindGameObjectWithTag("barreira") == null)
        {
            //Girar para direita
            if (ladoFora == true)
            {
                transform.Rotate(0, 0, velZ  * Time.deltaTime);
                StartCoroutine("pararCatraca");
            }
            //Girar para esqueda
            if (ladoDentro == true)
            {
                transform.Rotate(0, 0, -velZ * Time.deltaTime);
                StartCoroutine("pararCatraca");
            }
        }
    }

    void OnTriggerEnter(Collider colliderEnter)
    {
        //Verifica se o personagem esta colodindo a catraca
        if (colliderEnter.gameObject.tag == "npcs" || colliderEnter.gameObject.tag == "Player")
        {
            //Verifica se o personagem se encontra antes ou depois da catraca
            if (colliderEnter.transform.position.z <= -21.97f)
            {
                ladoFora = true;
            }
            if (colliderEnter.transform.position.z >= -21.97f)
            {
                ladoDentro = true;
            }
        }

    }

    void OnTriggerExit(Collider colliderExit)
    {
        //Verifica se o personagem saiu da colisão
        if (colliderExit.gameObject.tag == "npcs" || colliderExit.gameObject.tag == "Player")
        {
            StartCoroutine("PosicaoCatraca");
            ladoFora = false;
            ladoDentro = false;
        }
        
    }

    IEnumerator pararCatraca()
    {
        //Se o personagem se encontra parado na catraca  a mesma para de girar
        yield return new WaitForSeconds(0.5f);
        ladoFora = false;
        ladoDentro = false;
    }

    IEnumerator PosicaoCatraca()
    {
        yield return new WaitForSeconds(10f);
        
        
    }
}
