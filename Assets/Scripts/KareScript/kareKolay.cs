using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class kareKolay : MonoBehaviour
{
    [SerializeField]
    private GameObject game,menuQuestion,resim,resmiGor,resmiGorme;

    [SerializeField]
    public int Skor = 0;
    
    /* -------------------- Puzzle Piece -------------------- */

    [SerializeField]
    public GameObject p1, p2, p3, p4, p5, p6, p7, p8, p9;


    /* -------------------- Puzzle Shadow -------------------- */

    [SerializeField]
    public GameObject s1, s2, s3, s4, s5, s6, s7, s8, s9;

    
    /* -------------------- Puzzle Position -------------------- */

    Vector2 initialP1Position, initialP2Position, initialP3Position, initialP4Position, initialP5Position;

    Vector2 initialP6Position, initialP7Position, initialP8Position, initialP9Position;

    /* -------------------- Puzzle Check -------------------- */

    bool p1Check, p2Check, p3Check, p4Check, p5Check = false;

    bool p6Check, p7Check, p8Check, p9Check = false;

    void Start()
    {
        menuQuestion.SetActive(false);
        game.GetComponent<CanvasGroup>().DOFade(1, 0.5f);
        resmiGorme.SetActive(false);
        resmiGor.SetActive(true);
        resim.SetActive(false);
        
        /* -------------------- Puzzle Piece First Position -------------------- */

        initialP1Position = p1.transform.position;
        initialP2Position = p2.transform.position;
        initialP3Position = p3.transform.position;
        initialP4Position = p4.transform.position;
        initialP5Position = p5.transform.position;
        initialP6Position = p6.transform.position;
        initialP7Position = p7.transform.position;
        initialP8Position = p8.transform.position;
        initialP9Position = p9.transform.position;
    }
    
    /* -------------------- Drag Puzzle Piece -------------------- */

    public void DragP1()
    {
        p1.transform.position = Input.mousePosition;
    }

    public void DragP2()
    {
        p2.transform.position = Input.mousePosition;
    }

    public void DragP3()
    {
        p3.transform.position = Input.mousePosition;
    }
 
    public void DragP4()
    {
        p4.transform.position = Input.mousePosition;
    }

    public void DragP5()
    {
        p5.transform.position = Input.mousePosition;
    }

    public void DragP6()
    {
        p6.transform.position = Input.mousePosition;
    }

    public void DragP7()
    {
        p7.transform.position = Input.mousePosition;
    }

    public void DragP8()
    {
        p8.transform.position = Input.mousePosition;
    }

    public void DragP9()
    {
        p9.transform.position = Input.mousePosition;
    }

    /* -------------------- Drop Puzzle Piece 1 -------------------- */

    public void DropP1()
    {
        float distance = Vector3.Distance(p1.transform.position, s1.transform.position);
        
        if (distance < 50)
        {
            p1.transform.position = s1.transform.position;
            p1Check = true;
        }
    }
    
    public void DropP2()
    {
        float distance = Vector3.Distance(p2.transform.position, s2.transform.position);
        
        if (distance < 50)
        {
            p2.transform.position = s2.transform.position;
            p2Check = true;
        }
    }

    public void DropP3()
    {
        float distance = Vector3.Distance(p3.transform.position, s3.transform.position);
        
        if (distance < 50)
        {
            p3.transform.position = s3.transform.position;
            p3Check = true;
        }
    }

    public void DropP4()
    {
        float distance = Vector3.Distance(p4.transform.position, s4.transform.position);
        
        if (distance < 50)
        {
            p4.transform.position = s4.transform.position;
            p4Check = true;
        }
    }

    public void DropP5()
    {
        float distance = Vector3.Distance(p5.transform.position, s5.transform.position);
        
        if (distance < 50)
        {
            p5.transform.position = s5.transform.position;
            p5Check = true;
        }
    }

    public void DropP6()
    {
        float distance = Vector3.Distance(p6.transform.position, s6.transform.position);
        
        if (distance < 50)
        {
            p6.transform.position = s6.transform.position;
            p6Check = true;
        }
    }

    public void DropP7()
    {
        float distance = Vector3.Distance(p7.transform.position, s7.transform.position);
        
        if (distance < 50)
        {
            p7.transform.position = s7.transform.position;
            p7Check = true;
        }
    }

    public void DropP8()
    {
        float distance = Vector3.Distance(p8.transform.position, s8.transform.position);
        
        if (distance < 50)
        {
            p8.transform.position = s8.transform.position;
            p8Check = true;
        }
    }

    public void DropP9()
    {
        float distance = Vector3.Distance(p9.transform.position, s9.transform.position);
        
        if (distance < 50)
        {
            p9.transform.position = s9.transform.position;
            p9Check = true;
        }
    }

    public void ResmiGor()
    {
        resmiGorme.SetActive(true);
        resmiGor.SetActive(false);
        resim.SetActive(true);
    }

    public void ResmiGorme()
    {
        resmiGorme.SetActive(false);
        resmiGor.SetActive(true);
        resim.SetActive(false);
    }

    public void AreYouSure()
    {
        game.GetComponent<CanvasGroup>().interactable = false;
        menuQuestion.SetActive(true);
        menuQuestion.GetComponent<CanvasGroup>().DOFade(1, 0.5f);
    }

    public void Yes()
    {
        SceneManager.LoadScene("mainMenu");
    }

    public void No()
    {
        menuQuestion.GetComponent<CanvasGroup>().DOFade(0, 0.5f);
        menuQuestion.SetActive(false);
        game.GetComponent<CanvasGroup>().interactable = true;
    }
    
    void Update()
    {
        if(p1Check && p2Check && p3Check && p4Check && p5Check 
        && p6Check && p7Check && p8Check && p9Check )
        {
            if(Skor == 0)
            {
                Debug.Log("Tebrikler...");
                Skor +=1;
            }
        }
    }
}
