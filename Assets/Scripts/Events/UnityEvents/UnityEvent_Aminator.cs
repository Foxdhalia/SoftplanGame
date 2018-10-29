using UnityEngine;
using UnityEngine.AI;
public class UnityEvent_Aminator : MonoBehaviour
{
    NavMeshAgent agent;
    Animator npcAnimator;
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
        if (varFloat.Length != 0)
        {
            animatorDef();
        }
    }
    void animatorDef()
    {
        for (int countArray = 0; countArray <= varFloat.Length - 1; countArray++)
        {
            npcAnimator.SetFloat(varFloat[countArray], agent.velocity.magnitude);
        }
    }
}
