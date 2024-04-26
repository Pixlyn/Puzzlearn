using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class KolayTasima : MonoBehaviour
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

    Vector2 P1Pos, P2Pos, P3Pos, P4Pos, P5Pos, P6Pos, P7Pos, P8Pos, P9Pos;

    void Start()
    {
        menuQuestion.SetActive(false);
        game.GetComponent<CanvasGroup>().DOFade(1, 0.5f);
        resmiGorme.SetActive(false);
        resmiGor.SetActive(true);
        resim.SetActive(false);
    
    /* -------------------- Drag Puzzle Piece -------------------- */
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

    public void Tasi()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Pressed Left Mouse");
        }
    }

    

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Pressed Left Mouse");
        }
    }

}
