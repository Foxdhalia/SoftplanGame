using UnityEngine;

//By Maximo Michael;
//Version 1.0.0;
//Sexta-Feira, 12 de outubro de 2018;
//Movimentação de camera.


public class camera : MonoBehaviour {
    //A variavel PositionPersonagem captura o vector3.position do personagem.
    public Transform PositionPersonagem;
    //A variavel offSet pode ser definida manualmente pela unity, distancia da camera diante o personagem(X: 0, y: 20, z: -22)
    public Vector3 offSet;
    //A variavel speed define o velocidade de atraso entre o personagem e a camera.
    public float speed;

    //O LateUpdate é chamado depois que todas as funções de atualização foram chamadas. 
    void LateUpdate () {
        //PlusPosition  soma o posição do personagem com a distacia definida pelo offSet.
        Vector3 plusPosition = PositionPersonagem.position + offSet;
        //LerpPosition captura a posição da camera mais o plusPosition para suavizar o movimento da camera;
        Vector3 lerpPosition = Vector3.Lerp(transform.position, plusPosition, speed);
        //Define a posição da camera;
        transform.position = lerpPosition;


    }
}