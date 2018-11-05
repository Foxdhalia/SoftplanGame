using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class email : MonoBehaviour {
    GameObject avisoEmail;
    GameObject emailSoftPlan;
    // Use this for initialization
    void Start () {
        avisoEmail = GetComponent<GameObject>();
        emailSoftPlan = FindObjectOfType<GameObject>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void abrirEmail()
    {
        emailSoftPlan.gameObject.CompareTag("image_2");
        Destroy(avisoEmail);
    }
}
