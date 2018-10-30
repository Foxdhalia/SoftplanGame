using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

/*
 * Praticamente tudo que esse script faz eh permitir que o jogador nao se mova
 * quando clicado em algum lugar da tela atravez do metodo StopPlayerControlls(bool).
 * 
 * [@30/10/18] by [Joao G. L. Trindade]
 * [1] Nomes de metodos corrigidos.
 * [2] Codigo comentado para explicacao e remocao de trechos sem funcao aparente.
 * [3] Criado metodo InstanceGuarantee() para limpeza de codigo.
 */
public class Manager : MonoBehaviour
{
    public static Manager instance;
    public GameObject player;

    //private NavMeshSurface surface;
    //private Transform currentTrans;

    private void Start()
    {
        InstanceGuarantee();

        // JA ESTAVA COMENTADO:
        //surface = GameObject.Find("Navmesh").GetComponent<NavMeshSurface>();
    }

    /* O QUE FAZ
     * Garantindo a existencia de um unico Manager pelo jogo todo
     * Provavelmente sera removido
     */
    private void InstanceGuarantee()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }
    }

    /* O QUE FAZ
     * Metodo que impede o jogador de se mover caso clique em algum lugar.
     */
    public void StopPlayerControlls(bool stop)
    {
        player.GetComponent<controlPlay>().enabled = !stop;
        Debug.Log(!stop);
    }

    /*
     * A PARTIR DAQUI, NAO NOTEI NENHUMA DIFERENCA NO FUNCIONAMENTO DO JOGO SE
     * COMPARA-LO COM QUANDO ESSES CODIGOS ESTAO ATIVOS. POR PRECAUCAO E PELO CODIGO JA ESTAR
     * ESTREMAMENTE ENTRELACADO, DECIDI MANTE-LOS.
     * POR FAVOR, ME AVISEM SE DESCOBRIREM UMA FUNCIONALIDADE OCULTA.
     */

    public void RefreshNavMesh()
    {
        //StartCoroutine(BuildNavMesh());
    }

    public void StartDialog(Transform npcTrans, List<Dialog> dialogs)
    {
        /*
        currentTrans = npcTrans;
        StartCoroutine(DialogCoroutine(dialogs));
        */
    }

    IEnumerator BuildNavMesh()
    {
        yield return new WaitForSeconds(0.1f);
        //surface.BuildNavMesh();        
    }

    IEnumerator DialogCoroutine(List<Dialog> dialogs)
    {
        /*
        Transform anim = currentTrans.GetChild(0).GetChild(0);

        for (int i = 0; i < dialogs.Count; i++)
        {
           
            anim.GetComponentInChildren<Text>().text = dialogs[i].text;
            anim.GetComponent<Animator>().Play("FadeIn");

            Debug.Log(dialogs[i].duration);

            yield return new WaitForSeconds(dialogs[i].duration);
        }

        anim.GetComponent<Animator>().Play("FadeOut");
        */
        yield return null;
    }
}
