using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class Cracha : MonoBehaviour
{
    //VARIAVEL QUE GUARDA O NOME DIGITADO
    public static string nomeJogador;

    //OBJETO DO PAINEL
    public GameObject painelCracha;

    //OBJETO QUE MOSTRA NOME DO JOGADOR
    public GameObject nomeDoJogadorGameObject;

    //CAMPO DE TEXTO PARA INSERIR NOME
    public InputField crachaInput;

    //OBJETO TEXTO PARA ADICIONAR O NOME
    public Text nomeDoJogadorText;

    //BOTAO CONFIRMA
    public void BotaoOK()
    {
        //PEGA O QUE FOI DIGITADO E GUARDA NA VARIAVEL NOME DO JOGADOR
        nomeJogador = crachaInput.text;
        //ADICIONA O NOME DO JOGADOR NA TELA
        nomeDoJogadorText.text = nomeJogador;
        //TORNA O TEXTO VISIVEL
        nomeDoJogadorGameObject.SetActive(true);
    }


}
