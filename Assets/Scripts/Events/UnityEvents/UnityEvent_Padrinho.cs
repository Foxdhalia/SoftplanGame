using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
//Maximo Michael
//28 de outubro de 2018 01:34hs

public class UnityEvent_Padrinho : MonoBehaviour {
    //Array capturar Caminho;
    public Transform [] C4_P = new Transform[0];
    //Contar o caminho percorrido;
    public int countCaminho = 0;
    //Impontar valores abaixo;
    NavMeshAgent navMeshAgente;
    Transform transformPersonagem;
    Collider colliderPersonagem;

    void Start() {
        navMeshAgente = GetComponent<NavMeshAgent>();
        transformPersonagem = GetComponent<Transform>();
        colliderPersonagem = GetComponent<Collider>();
    }

    public void movePadrinho()
   {
        if (C4_P.Length-1 >= countCaminho)
        {
            //enabledCollider();
            countCaminhoDef();
            //Movimentar para o ponto expecificado pelo countCaminho
            navMeshAgente.destination = C4_P[countCaminho].position;            
        }
        
   }
   public void countCaminhoDef()
    {
        //Verificar se o npc chegou no ponto expecificado;
        if (C4_P[countCaminho].position.x == transformPersonagem.position.x && C4_P[countCaminho].position.z == transformPersonagem.position.z && C4_P.Length - 1 >= countCaminho)
        {
            //Somar mais um;
            countCaminho++;
            //enabledCollider();
        }
    }

    void enabledCollider()
    {
        //desabilitar Collider;
        colliderPersonagem.enabled = !colliderPersonagem;
    }
}
