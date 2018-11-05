using UnityEngine;

public class email : MonoBehaviour {
    GameObject avisoEmail;
    GameObject emailSoftPlan;
    // Use this for initialization
    void Start () {
        avisoEmail = GetComponent<GameObject>();
    }

    void abrirEmail()
    {
        emailSoftPlan.CompareTag("ima ge_2");
        Destroy(avisoEmail);
    }
}
