using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
public class PuzzlePiece : MonoBehaviour
{
    private Vector3 RightPosition;
    public bool InRightPosition;
    public bool Selected;

    void Start()
    {
        RightPosition = transform.position;
        ///////// assim que o jogo comeca
        ///////// as pecas ficarao dispostas em posicoes aleatorias
        transform.position = new Vector3(Random.Range(1f, 8.4f), Random.Range(3.2f, -3.2f));
    }
 
    void Update()
    {
        // caso o jogador chegue com a peca perto da sua posicao de origem
        // ela vai encaixar automaticamente
        if (Vector3.Distance(transform.position, RightPosition) < 0.8f) {
            if(!Selected) {
            if(InRightPosition == false) {
            transform.position = RightPosition;
            // quando encaixada, ela nao pode ser selecionada
            InRightPosition = true;
            GetComponent<SortingGroup>().sortingOrder = 0;
            }
            }}
        }
    }
    public class ScaleAndShake : MonoBehaviour {
        
}