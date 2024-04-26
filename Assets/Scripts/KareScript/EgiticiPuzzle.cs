using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EgiticiPuzzle : MonoBehaviour
{
    [SerializeField]
    private GameObject game,menuQuestion,resim,resmiGor,resmiGorme;

    [SerializeField]
    public int Skor = 0;
    
    /* -------------------- Puzzle Piece -------------------- */

    [SerializeField]
    public GameObject p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31, p32, p33, p34, p35, p36;

    /* -------------------- Puzzle Shadow -------------------- */

    [SerializeField]
    public GameObject s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12, s13, s14, s15, s16, s17, s18, s19, s20, s21, s22, s23, s24, s25, s26, s27, s28, s29, s30, s31, s32, s33, s34, s35, s36;

    /* -------------------- Puzzle Check -------------------- */

    bool p1Check, p2Check, p3Check, p4Check, p5Check, p6Check, p7Check, p8Check, p9Check, p10Check, p11Check, p12Check = false;

    bool p13Check, p14Check, p15Check, p16Check, p17Check, p18Check, p19Check, p20Check, p21Check, p22Check, p23Check, p24Check = false;

    bool p25Check, p26Check, p27Check, p28Check, p29Check, p30Check, p31Check, p32Check, p33Check, p34Check, p35Check, p36Check = false;

    void Start()
    {
        menuQuestion.SetActive(false);
        game.GetComponent<CanvasGroup>().DOFade(1, 0.5f);
        resmiGorme.SetActive(false);
        resmiGor.SetActive(true);
        resim.SetActive(false);
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

    public void DragP10()
    {
        p10.transform.position = Input.mousePosition;
    }

    public void DragP11()
    {
        p11.transform.position = Input.mousePosition;
    }

    public void DragP12()
    {
        p12.transform.position = Input.mousePosition;
    }

    public void DragP13()
    {
        p13.transform.position = Input.mousePosition;
    }
 
    public void DragP14()
    {
        p14.transform.position = Input.mousePosition;
    }

    public void DragP15()
    {
        p15.transform.position = Input.mousePosition;
    }

    public void DragP16()
    {
        p16.transform.position = Input.mousePosition;
    }

    public void DragP17()
    {
        p17.transform.position = Input.mousePosition;
    }

    public void DragP18()
    {
        p18.transform.position = Input.mousePosition;
    }

    public void DragP19()
    {
        p19.transform.position = Input.mousePosition;
    }

    public void DragP20()
    {
        p20.transform.position = Input.mousePosition;
    }

    public void DragP21()
    {
        p21.transform.position = Input.mousePosition;
    }

    public void DragP22()
    {
        p22.transform.position = Input.mousePosition;
    }

    public void DragP23()
    {
        p23.transform.position = Input.mousePosition;
    }
 
    public void DragP24()
    {
        p24.transform.position = Input.mousePosition;
    }

    public void DragP25()
    {
        p25.transform.position = Input.mousePosition;
    }

    public void DragP26()
    {
        p26.transform.position = Input.mousePosition;
    }

    public void DragP27()
    {
        p27.transform.position = Input.mousePosition;
    }

    public void DragP28()
    {
        p28.transform.position = Input.mousePosition;
    }

    public void DragP29()
    {
        p29.transform.position = Input.mousePosition;
    }

    public void DragP30()
    {
        p30.transform.position = Input.mousePosition;
    }

    public void DragP31()
    {
        p31.transform.position = Input.mousePosition;
    }

    public void DragP32()
    {
        p32.transform.position = Input.mousePosition;
    }

    public void DragP33()
    {
        p33.transform.position = Input.mousePosition;
    }
 
    public void DragP34()
    {
        p34.transform.position = Input.mousePosition;
    }

    public void DragP35()
    {
        p35.transform.position = Input.mousePosition;
    }

    public void DragP36()
    {
        p36.transform.position = Input.mousePosition;
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

    public void DropP10()
    {
        float distance = Vector3.Distance(p10.transform.position, s10.transform.position);
        
        if (distance < 50)
        {
            p10.transform.position = s10.transform.position;
            p10Check = true;
        }
    }

    public void DropP11()
    {
        float distance = Vector3.Distance(p11.transform.position, s11.transform.position);
        
        if (distance < 50)
        {
            p11.transform.position = s11.transform.position;
            p11Check = true;
        }
    }

    public void DropP12()
    {
        float distance = Vector3.Distance(p12.transform.position, s12.transform.position);
        
        if (distance < 50)
        {
            p12.transform.position = s12.transform.position;
            p12Check = true;
        }
    }

    public void DropP13()
    {
        float distance = Vector3.Distance(p13.transform.position, s13.transform.position);
        
        if (distance < 50)
        {
            p13.transform.position = s13.transform.position;
            p13Check = true;
        }
    }

    public void DropP14()
    {
        float distance = Vector3.Distance(p14.transform.position, s14.transform.position);
        
        if (distance < 50)
        {
            p14.transform.position = s14.transform.position;
            p14Check = true;
        }
    }

    public void DropP15()
    {
        float distance = Vector3.Distance(p15.transform.position, s15.transform.position);
        
        if (distance < 50)
        {
            p15.transform.position = s15.transform.position;
            p15Check = true;
        }
    }

    public void DropP16()
    {
        float distance = Vector3.Distance(p16.transform.position, s16.transform.position);
        
        if (distance < 50)
        {
            p16.transform.position = s16.transform.position;
            p16Check = true;
        }
    }

    public void DropP17()
    {
        float distance = Vector3.Distance(p17.transform.position, s17.transform.position);
        
        if (distance < 50)
        {
            p17.transform.position = s17.transform.position;
            p17Check = true;
        }
    }

    public void DropP18()
    {
        float distance = Vector3.Distance(p18.transform.position, s18.transform.position);
        
        if (distance < 50)
        {
            p18.transform.position = s18.transform.position;
            p18Check = true;
        }
    }

    public void DropP19()
    {
        float distance = Vector3.Distance(p19.transform.position, s19.transform.position);
        
        if (distance < 50)
        {
            p19.transform.position = s19.transform.position;
            p19Check = true;
        }
    }

    public void DropP20()
    {
        float distance = Vector3.Distance(p20.transform.position, s20.transform.position);
        
        if (distance < 50)
        {
            p20.transform.position = s20.transform.position;
            p20Check = true;
        }
    }

    public void DropP21()
    {
        float distance = Vector3.Distance(p21.transform.position, s21.transform.position);
        
        if (distance < 50)
        {
            p21.transform.position = s21.transform.position;
            p21Check = true;
        }
    }

    public void DropP22()
    {
        float distance = Vector3.Distance(p22.transform.position, s22.transform.position);
        
        if (distance < 50)
        {
            p22.transform.position = s22.transform.position;
            p22Check = true;
        }
    }

    public void DropP23()
    {
        float distance = Vector3.Distance(p23.transform.position, s23.transform.position);
        
        if (distance < 50)
        {
            p23.transform.position = s23.transform.position;
            p23Check = true;
        }
    }

    public void DropP24()
    {
        float distance = Vector3.Distance(p24.transform.position, s24.transform.position);
        
        if (distance < 50)
        {
            p24.transform.position = s24.transform.position;
            p24Check = true;
        }
    }

    public void DropP25()
    {
        float distance = Vector3.Distance(p25.transform.position, s25.transform.position);
        
        if (distance < 50)
        {
            p25.transform.position = s25.transform.position;
            p25Check = true;
        }
    }

    public void DropP26()
    {
        float distance = Vector3.Distance(p26.transform.position, s26.transform.position);
        
        if (distance < 50)
        {
            p26.transform.position = s26.transform.position;
            p26Check = true;
        }
    }

    public void DropP27()
    {
        float distance = Vector3.Distance(p27.transform.position, s27.transform.position);
        
        if (distance < 50)
        {
            p27.transform.position = s27.transform.position;
            p27Check = true;
        }
    }

    public void DropP28()
    {
        float distance = Vector3.Distance(p28.transform.position, s28.transform.position);
        
        if (distance < 50)
        {
            p28.transform.position = s28.transform.position;
            p28Check = true;
        }
    }

    public void DropP29()
    {
        float distance = Vector3.Distance(p29.transform.position, s29.transform.position);
        
        if (distance < 50)
        {
            p29.transform.position = s29.transform.position;
            p29Check = true;
        }
    }

    public void DropP30()
    {
        float distance = Vector3.Distance(p30.transform.position, s30.transform.position);
        
        if (distance < 50)
        {
            p30.transform.position = s30.transform.position;
            p30Check = true;
        }
    }

    public void DropP31()
    {
        float distance = Vector3.Distance(p31.transform.position, s31.transform.position);
        
        if (distance < 50)
        {
            p31.transform.position = s31.transform.position;
            p31Check = true;
        }
    }

    public void DropP32()
    {
        float distance = Vector3.Distance(p32.transform.position, s32.transform.position);
        
        if (distance < 50)
        {
            p32.transform.position = s32.transform.position;
            p32Check = true;
        }
    }

    public void DropP33()
    {
        float distance = Vector3.Distance(p33.transform.position, s33.transform.position);
        
        if (distance < 50)
        {
            p33.transform.position = s33.transform.position;
            p33Check = true;
        }
    }

    public void DropP34()
    {
        float distance = Vector3.Distance(p34.transform.position, s34.transform.position);
        
        if (distance < 50)
        {
            p34.transform.position = s34.transform.position;
            p34Check = true;
        }
    }

    public void DropP35()
    {
        float distance = Vector3.Distance(p35.transform.position, s35.transform.position);
        
        if (distance < 50)
        {
            p35.transform.position = s35.transform.position;
            p35Check = true;
        }
    }

    public void DropP36()
    {
        float distance = Vector3.Distance(p36.transform.position, s36.transform.position);
        
        if (distance < 50)
        {
            p36.transform.position = s36.transform.position;
            p36Check = true;
        }
    }
    
    /* -------------------- Completed Puzzle On -------------------- */

    public void ResmiGor()
    {
        resmiGorme.SetActive(true);
        resmiGor.SetActive(false);
        resim.SetActive(true);
    }

    /* -------------------- Completed Puzzle Off -------------------- */

    public void ResmiGorme()
    {
        resmiGorme.SetActive(false);
        resmiGor.SetActive(true);
        resim.SetActive(false);
    }

    /* -------------------- Are You Sure -------------------- */

    public void AreYouSure()
    {
        game.GetComponent<CanvasGroup>().interactable = false;
        menuQuestion.SetActive(true);
        menuQuestion.GetComponent<CanvasGroup>().DOFade(1, 0.5f);
    }
    
    /* -------------------- Yes -------------------- */

    public void Yes()
    {
        SceneManager.LoadScene("mainMenu");
    }

    /* -------------------- No -------------------- */

    public void No()
    {
        menuQuestion.GetComponent<CanvasGroup>().DOFade(0, 0.5f);
        menuQuestion.SetActive(false);
        game.GetComponent<CanvasGroup>().interactable = true;
    }
    
    void Update()
    {
        if(p1Check && p2Check && p3Check && p4Check && p5Check && p6Check && p7Check && p8Check && p9Check && p10Check && p11Check && p12Check
        && p13Check && p14Check && p15Check && p16Check && p17Check && p18Check && p19Check && p20Check && p21Check && p22Check && p23Check && p24Check 
        && p25Check && p26Check && p27Check && p28Check && p29Check && p30Check && p31Check && p32Check && p33Check && p34Check && p35Check && p36Check)
        {
            if(Skor == 0)
            {
                Debug.Log("Tebrikler...");
                Skor +=1;
            }
        }
    }
}
