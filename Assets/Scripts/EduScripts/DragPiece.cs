using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragPiece : MonoBehaviour
{
    
    Camera cam;

    GameObject[] puzzleShadow;

    Vector2 startPos;

    Puzzle yapboz;

    private bool boole = false;
    
    public UI ui;

    private void OnMouseDrag()
    {
        if(boole == false)
        {
            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            pos.z = 0;
            transform.position = pos;
        }
    }

    void Start()
    {
        cam = GameObject.Find("Main Camera").GetComponent<Camera>();
        startPos = transform.position;

        puzzleShadow = GameObject.FindGameObjectsWithTag("puzzleArea");
        yapboz = GameObject.Find("sceneManager").GetComponent<Puzzle>();

        ui = GameObject.Find("Questions").GetComponent<UI>();
    }
  
    void Update()
    {
        if(Input.GetMouseButtonUp(0))
        {
            foreach(GameObject puzzleArea in puzzleShadow)
            {
                if(puzzleArea.name+"(Clone)" == gameObject.name)
                {
                    float distance = Vector2.Distance(puzzleArea.transform.position , transform.position);

                    if(distance <= 2)
                    {
                        transform.position = puzzleArea.transform.position;
                        yapboz.placedPuzzle();
                        boole = true;
                        puzzleArea.GetComponent<PolygonCollider2D>().enabled = false;
                        ui.ClearQuestion();
                        this.enabled = false;
                    }
                }
            }
        }
    }
}
