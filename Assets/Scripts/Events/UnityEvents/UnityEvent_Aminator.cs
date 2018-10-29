using UnityEngine;
using UnityEngine.AI;

//Máximo Michael
//28 de Outubro de 2018, 20:00hs

public class UnityEvent_Aminator : MonoBehaviour
{
    //Chamar NavMeshAgent;
    NavMeshAgent agent;
    //Chamar Animator
    Animator npcAnimator;
    //Passar o nome das variveil
    public string[] varFloat;

    // Use this for initialization
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        npcAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // verifica se a array varFloat esta vazia;
        if (varFloat.Length != 0)
        {
            //Chama a função animação;
            animatorDef();
        }
    }
    void animatorDef()
    {
        //Conta a array varFloat e gera SetFloat
        for (int countArray = 0; countArray <= varFloat.Length - 1; countArray++)
        {
            //Animação
            npcAnimator.SetFloat(varFloat[countArray], agent.velocity.magnitude /*Verifica se o agente esta se movimentando pelo mesh*/);
        }
    }
}
