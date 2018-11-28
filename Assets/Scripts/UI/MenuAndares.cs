using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*  
 *  @[05/11/2018] by[Joao G. L. Trindade]
 *  [1] Script criado.
 */
public class MenuAndares : MonoBehaviour
{
    public GameObject objeto;
    private Manager manager;

    // Use this for initialization
    void Start()
    {
        manager = FindObjectOfType<Manager>();
    }

    public void OnMouseDown()
    {
        LigarPainelEImpedirMovimento();
    }

    private void LigarPainelEImpedirMovimento()
    {
        objeto.SetActive(true);
        manager.StopPlayerControlls(true);
    }

    public void DesligarPainelEPermiterMovimento()
    {
        objeto.SetActive(false);
        manager.StopPlayerControlls(false);
    }
}
