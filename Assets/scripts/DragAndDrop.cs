using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class DragAndDrop : MonoBehaviour
{
    public GameObject SelectedPiece;
    int OIL = 1;
   
    // Update is called once per frame
    void Update()
    {
         if (Input.GetMouseButtonDown(0)) {
             
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.transform.CompareTag("Puzzle")){
                if (!hit.transform.GetComponent<PuzzlePiece>().InRightPosition) {
                    SelectedPiece = hit.transform.gameObject;
                    SelectedPiece.GetComponent<PuzzlePiece>().Selected = true;
                    SelectedPiece.GetComponent<SortingGroup>().sortingOrder = OIL;
                    OIL++;
                }
            
            }
        }
        if (Input.GetMouseButtonUp(0)){
            
            if (SelectedPiece != null) {
            SelectedPiece.GetComponent<PuzzlePiece>().Selected = false;
            SelectedPiece = null;}
        }
        if (SelectedPiece != null){
            Vector3 MousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            SelectedPiece.transform.position = new Vector3 (MousePoint.x, MousePoint.y, 0);
        } 
    }
}
