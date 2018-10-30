using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * [@30/10/18] by [Joao G. L. Trindade]
 * [1] Inicializacao da variavel booleana 'isShow' movida da declaracao para metodo Start()
 * [2] Codigo comentado para melhor entendimento de suas funcoes.
 */
[RequireComponent(typeof(Animator))]
public class OptionsPanel : MonoBehaviour
{
    public static OptionsPanel instance;
    public bool isShow;

    private Animator anim;

    private void Start()
    {
        isShow = false;
        InstanceGuarantee();
        anim = GetComponent<Animator>();
    }

    /* O QUE FAZ
     * Garantindo a existencia de um unico OptionsPanel
     * Provavelmente sera removido
     */
    private void InstanceGuarantee()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            return;
        }
    }

    /* QUESTIONAMENTO
     * Esse Getter pode ser removido futuramente?
     * Um '.transform' nao faz a mesma coisa?
     */
    public Transform GetTransform()
    {
        return transform;
    }

    /* O QUE FAZ
     * Destroi todas as childrens
     */
    public void ClearOptions()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            Destroy(transform.GetChild(i).gameObject);
        }
    }

    /* O QUE FAZ
     * Controladores da pequena animacao de FadeIn e FadeOut dos botoes, para deixar sua aparicao mais sutil.
     */
    public void ShowOptions()
    {
        anim.Play("FadeIn");
        isShow = true;
    }

    public void HideOptions()
    {
        anim.Play("FadeOut");
        isShow = false;
    }
}
