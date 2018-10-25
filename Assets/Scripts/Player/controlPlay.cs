using UnityEngine;
using UnityEngine.AI;

//By Maximo Michael;
//Version 1.1.0;
//Sexta-Feira, 12 de outubro de 2018;
//Movimentação e animação do personagem.

public class controlPlay : MonoBehaviour {
    //Chamar o agent mesh.
    NavMeshAgent agent;
    //Chamar camera.
    public Camera cameraPoint;
    //Chamar Animator do personagem.
    Animator animePersonagem;
    //Capturar a posição do personagem
    Transform transformPersonagem;
    //chamar InteractableOdin e PlayerMotor
    public InteractableOdin focus;
    PlayerMotor Motor;
    int countTagAction = 3;
    void Start () {
        animePersonagem = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        transformPersonagem = GetComponent<Transform>();
        Motor = GetComponent<PlayerMotor>();
    }
	
	// Update is called once per frame
	void Update () {
        //verificando se o botão esquedo do mouse foi clicado.
        
        if (Input.GetMouseButtonDown(0))
        {
            //Capturando o raio.
            RaycastHit hit;
            Ray ray = cameraPoint.ScreenPointToRay(Input.mousePosition);
            //GameObject tagAction = GameObject.FindWithTag("ActionB");
            
            //Verificar onde foi clicado
            if (Physics.Raycast(ray, out hit))
            {
                //contar cliques
                if (hit.collider)
                {
                    countTagAction++;
                    print(countTagAction);
                }
                if (hit.collider.tag != "npcs" && countTagAction >= 2)
                {
                    Motor.MoveToPoint(hit.point);
                    RemoveFocus();
                    print(0 + " 0");
                } 
                
                else
                {

                    InteractableOdin interactable = hit.collider.GetComponent<InteractableOdin>();

                    if (interactable != null)
                    {
                        
                        setFocus(interactable);
                        countTagAction = 0;
                        interactable = null;
                    }
                    print(2 + " 0");
                }
            }
        }
        //Verificar se o personagem esta em movimento para definir a animação.
        walkPersonagem(agent.velocity.magnitude);
    }

    //Chamar animação Personagem;
    void  walkPersonagem(float vel)
    {
        animePersonagem.SetFloat("WaltFloat", vel);
    }
    
    void setFocus (InteractableOdin newFocus)
    {
        if(newFocus != focus)
        {
            if (focus != null)
                focus.OnDefocused();


            focus = newFocus;
            Motor.FollowTarget(newFocus);
        }

        newFocus.OnFocused(transform);
    }

    public void RemoveFocus()
    {
        if (focus != null)
            focus.OnDefocused();
        focus = null;
        Motor.StopFollowTarget(); 
    }


    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Turnstile")
        {
            Animator anim = coll.gameObject.GetComponent<Animator>();
            if (transform.position.z <= -22.25f)
            {
                anim.SetTrigger("right");
            }
            if (transform.position.z >= -22.25f)
            {
                anim.SetTrigger("left");
            }
        
        }
    }

}