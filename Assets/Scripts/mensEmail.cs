using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mensEmail : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
        StartCoroutine("chamarMensagem");
    }

    IEnumerator chamarMensagem()
    {
        yield return new WaitForSeconds(4);
        

    }
}
