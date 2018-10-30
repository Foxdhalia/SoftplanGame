using UnityEngine;
using UnityEngine.AI;
public class UnityEvent_AddCollider : MonoBehaviour {
//Máximo Michael
//30 de dezembro de 2018, 20:44
//maximomichaelfx@gmail.com
 

    NavMeshAgent meshAgent;
    Collider colliderAgent;
    public bool walkBool; 
	// Use this for initialization
	void Start () {
        meshAgent = GetComponent<NavMeshAgent>();
        colliderAgent = GetComponent<Collider>();
	}
	
	// Update is called once per frame
	void Update () {
        addCollider();
    }

    void addCollider()
    {
        //Se walkBool estiver em true o collider só habilita se o gameObject estiver em movimento;
        if (walkBool == true)
        {
            if (meshAgent.velocity.magnitude > 0)
            {
                //habilita o collider;
                colliderAgent.enabled = true;
            }
            else
            {
                //desabilita o collider;
                colliderAgent.enabled = false;
            }
        }
        //Se walkBool estiver em false o collider só habilita se o gameObject estiver parado;
        else
        {
            //Verifica se o gameObject esta em movimento;
            if (meshAgent.velocity.magnitude > 0)
            {
                //desabilita o collider;
                colliderAgent.enabled = false;
            }
            else
            {
                //habilita o collider;
                colliderAgent.enabled = true;
            }
        }
            
    }
}
