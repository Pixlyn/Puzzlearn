using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class klasikZor : MonoBehaviour
{
    [SerializeField]
    private GameObject game,menuQuestion,resim,resmiGor,resmiGorme;

    [SerializeField]
    public int Skor = 0;
    
    /* -------------------- Puzzle Piece -------------------- */

    [SerializeField]
    public GameObject p1, p2, p3, p4, p5, p6, p7, p8, p9, p10;

    [SerializeField]
    public GameObject p11, p12, p13, p14, p15, p16, p17, p18, p19, p20;

    [SerializeField]
    public GameObject p21, p22, p23, p24, p25, p26, p27, p28, p29, p30;

    [SerializeField]
    public GameObject p31, p32, p33, p34, p35, p36, p37, p38, p39, p40;

    [SerializeField]
    public GameObject p41, p42, p43, p44, p45, p46, p47, p48, p49, p50;

    [SerializeField]
    public GameObject p51, p52, p53, p54, p55, p56, p57, p58, p59, p60;

    [SerializeField]
    public GameObject p61, p62, p63, p64;

    /* -------------------- Puzzle Shadow -------------------- */

    [SerializeField]
    public GameObject s1, s2, s3, s4, s5, s6, s7, s8, s9, s10;

    [SerializeField]
    public GameObject s11, s12, s13, s14, s15, s16, s17, s18, s19, s20;

    [SerializeField]
    public GameObject s21, s22, s23, s24, s25, s26, s27, s28, s29, s30;

    [SerializeField]
    public GameObject s31, s32, s33, s34, s35, s36, s37, s38, s39, s40;

    [SerializeField]
    public GameObject s41, s42, s43, s44, s45, s46, s47, s48, s49, s50;

    [SerializeField]
    public GameObject s51, s52, s53, s54, s55, s56, s57, s58, s59, s60;

    [SerializeField]
    public GameObject s61, s62, s63, s64;
    
    /* -------------------- Puzzle Position -------------------- */

    Vector2 initialP1Position, initialP2Position, initialP3Position, initialP4Position, initialP5Position;

    Vector2 initialP6Position, initialP7Position, initialP8Position, initialP9Position, initialP10Position;
    
    Vector2 initialP11Position, initialP12Position, initialP13Position, initialP14Position, initialP15Position;

    Vector2 initialP16Position, initialP17Position, initialP18Position, initialP19Position, initialP20Position;

    Vector2 initialP21Position, initialP22Position, initialP23Position, initialP24Position, initialP25Position;

    Vector2 initialP26Position, initialP27Position, initialP28Position, initialP29Position, initialP30Position;

    Vector2 initialP31Position, initialP32Position, initialP33Position, initialP34Position, initialP35Position;

    Vector2 initialP36Position, initialP37Position, initialP38Position, initialP39Position, initialP40Position;
    
    Vector2 initialP41Position, initialP42Position, initialP43Position, initialP44Position, initialP45Position;

    Vector2 initialP46Position, initialP47Position, initialP48Position, initialP49Position, initialP50Position;

    Vector2 initialP51Position, initialP52Position, initialP53Position, initialP54Position, initialP55Position;

    Vector2 initialP56Position, initialP57Position, initialP58Position, initialP59Position, initialP60Position;

    Vector2 initialP61Position, initialP62Position, initialP63Position, initialP64Position;

    /* -------------------- Puzzle Check -------------------- */

    bool p1Check, p2Check, p3Check, p4Check, p5Check = false;

    bool p6Check, p7Check, p8Check, p9Check, p10Check = false;

    bool p11Check, p12Check, p13Check, p14Check, p15Check = false;

    bool p16Check, p17Check, p18Check, p19Check, p20Check = false;

    bool p21Check, p22Check, p23Check, p24Check, p25Check = false;

    bool p26Check, p27Check, p28Check, p29Check, p30Check = false;

    bool p31Check, p32Check, p33Check, p34Check, p35Check = false;

    bool p36Check, p37Check, p38Check, p39Check, p40Check = false;

    bool p41Check, p42Check, p43Check, p44Check, p45Check = false;

    bool p46Check, p47Check, p48Check, p49Check, p50Check = false;

    bool p51Check, p52Check, p53Check, p54Check, p55Check = false;

    bool p56Check, p57Check, p58Check, p59Check, p60Check = false;

    bool p61Check, p62Check, p63Check, p64Check = false;

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
        initialP10Position = p10.transform.position;
        initialP11Position = p11.transform.position;
        initialP12Position = p12.transform.position;
        initialP13Position = p13.transform.position;
        initialP14Position = p14.transform.position;
        initialP15Position = p15.transform.position;
        initialP16Position = p16.transform.position;
        initialP17Position = p17.transform.position;
        initialP18Position = p18.transform.position;
        initialP19Position = p19.transform.position;
        initialP20Position = p20.transform.position;
        initialP21Position = p21.transform.position;
        initialP22Position = p22.transform.position;
        initialP23Position = p23.transform.position;
        initialP24Position = p24.transform.position;
        initialP25Position = p25.transform.position;
        initialP26Position = p26.transform.position;
        initialP27Position = p27.transform.position;
        initialP28Position = p28.transform.position;
        initialP29Position = p29.transform.position;
        initialP30Position = p30.transform.position;
        initialP31Position = p31.transform.position;
        initialP32Position = p32.transform.position;
        initialP33Position = p33.transform.position;
        initialP34Position = p34.transform.position;
        initialP35Position = p35.transform.position;
        initialP36Position = p36.transform.position;
        initialP37Position = p37.transform.position;
        initialP38Position = p38.transform.position;
        initialP39Position = p39.transform.position;
        initialP40Position = p40.transform.position;
        initialP41Position = p41.transform.position;
        initialP42Position = p42.transform.position;
        initialP43Position = p43.transform.position;
        initialP44Position = p44.transform.position;
        initialP45Position = p45.transform.position;
        initialP46Position = p46.transform.position;
        initialP47Position = p47.transform.position;
        initialP48Position = p48.transform.position;
        initialP49Position = p49.transform.position;
        initialP50Position = p50.transform.position;
        initialP51Position = p51.transform.position;
        initialP52Position = p52.transform.position;
        initialP53Position = p53.transform.position;
        initialP54Position = p54.transform.position;
        initialP55Position = p55.transform.position;
        initialP56Position = p56.transform.position;
        initialP57Position = p57.transform.position;
        initialP58Position = p58.transform.position;
        initialP59Position = p59.transform.position;
        initialP60Position = p60.transform.position;
        initialP61Position = p61.transform.position;
        initialP62Position = p62.transform.position;
        initialP63Position = p63.transform.position;
        initialP64Position = p64.transform.position;
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

    public void DragP37()
    {
        p37.transform.position = Input.mousePosition;
    }

    public void DragP38()
    {
        p38.transform.position = Input.mousePosition;
    }

    public void DragP39()
    {
        p39.transform.position = Input.mousePosition;
    }

    public void DragP40()
    {
        p40.transform.position = Input.mousePosition;
    }

    public void DragP41()
    {
        p41.transform.position = Input.mousePosition;
    }

    public void DragP42()
    {
        p42.transform.position = Input.mousePosition;
    }

    public void DragP43()
    {
        p43.transform.position = Input.mousePosition;
    }
 
    public void DragP44()
    {
        p44.transform.position = Input.mousePosition;
    }

    public void DragP45()
    {
        p45.transform.position = Input.mousePosition;
    }

    public void DragP46()
    {
        p46.transform.position = Input.mousePosition;
    }

    public void DragP47()
    {
        p47.transform.position = Input.mousePosition;
    }

    public void DragP48()
    {
        p48.transform.position = Input.mousePosition;
    }

    public void DragP49()
    {
        p49.transform.position = Input.mousePosition;
    }

    public void DragP50()
    {
        p50.transform.position = Input.mousePosition;
    }

    public void DragP51()
    {
        p51.transform.position = Input.mousePosition;
    }

    public void DragP52()
    {
        p52.transform.position = Input.mousePosition;
    }

    public void DragP53()
    {
        p53.transform.position = Input.mousePosition;
    }
 
    public void DragP54()
    {
        p54.transform.position = Input.mousePosition;
    }

    public void DragP55()
    {
        p55.transform.position = Input.mousePosition;
    }

    public void DragP56()
    {
        p56.transform.position = Input.mousePosition;
    }

    public void DragP57()
    {
        p57.transform.position = Input.mousePosition;
    }

    public void DragP58()
    {
        p58.transform.position = Input.mousePosition;
    }

    public void DragP59()
    {
        p59.transform.position = Input.mousePosition;
    }

    public void DragP60()
    {
        p60.transform.position = Input.mousePosition;
    }

    public void DragP61()
    {
        p61.transform.position = Input.mousePosition;
    }

    public void DragP62()
    {
        p62.transform.position = Input.mousePosition;
    }

    public void DragP63()
    {
        p63.transform.position = Input.mousePosition;
    }
 
    public void DragP64()
    {
        p64.transform.position = Input.mousePosition;
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

    public void DropP37()
    {
        float distance = Vector3.Distance(p37.transform.position, s37.transform.position);
        
        if (distance < 50)
        {
            p37.transform.position = s37.transform.position;
            p37Check = true;
        }
    }

    public void DropP38()
    {
        float distance = Vector3.Distance(p38.transform.position, s38.transform.position);
        
        if (distance < 50)
        {
            p38.transform.position = s38.transform.position;
            p38Check = true;
        }
    }

    public void DropP39()
    {
        float distance = Vector3.Distance(p39.transform.position, s39.transform.position);
        
        if (distance < 50)
        {
            p39.transform.position = s39.transform.position;
            p39Check = true;
        }
    }

    public void DropP40()
    {
        float distance = Vector3.Distance(p40.transform.position, s40.transform.position);
        
        if (distance < 50)
        {
            p40.transform.position = s40.transform.position;
            p40Check = true;
        }
    }

    public void DropP41()
    {
        float distance = Vector3.Distance(p41.transform.position, s41.transform.position);
        
        if (distance < 50)
        {
            p41.transform.position = s41.transform.position;
            p41Check = true;
        }
    }

    public void DropP42()
    {
        float distance = Vector3.Distance(p42.transform.position, s42.transform.position);
        
        if (distance < 50)
        {
            p42.transform.position = s42.transform.position;
            p42Check = true;
        }
    }

    public void DropP43()
    {
        float distance = Vector3.Distance(p43.transform.position, s43.transform.position);
        
        if (distance < 50)
        {
            p43.transform.position = s43.transform.position;
            p43Check = true;
        }
    }

    public void DropP44()
    {
        float distance = Vector3.Distance(p44.transform.position, s44.transform.position);
        
        if (distance < 50)
        {
            p44.transform.position = s44.transform.position;
            p44Check = true;
        }
    }

    public void DropP45()
    {
        float distance = Vector3.Distance(p45.transform.position, s45.transform.position);
        
        if (distance < 50)
        {
            p45.transform.position = s45.transform.position;
            p45Check = true;
        }
    }

    public void DropP46()
    {
        float distance = Vector3.Distance(p46.transform.position, s46.transform.position);
        
        if (distance < 50)
        {
            p46.transform.position = s46.transform.position;
            p46Check = true;
        }
    }

    public void DropP47()
    {
        float distance = Vector3.Distance(p47.transform.position, s47.transform.position);
        
        if (distance < 50)
        {
            p47.transform.position = s47.transform.position;
            p47Check = true;
        }
    }

    public void DropP48()
    {
        float distance = Vector3.Distance(p48.transform.position, s48.transform.position);
        
        if (distance < 50)
        {
            p48.transform.position = s48.transform.position;
            p48Check = true;
        }
    }

    public void DropP49()
    {
        float distance = Vector3.Distance(p49.transform.position, s49.transform.position);
        
        if (distance < 50)
        {
            p49.transform.position = s49.transform.position;
            p49Check = true;
        }
    }

    public void DropP50()
    {
        float distance = Vector3.Distance(p50.transform.position, s50.transform.position);
        
        if (distance < 50)
        {
            p50.transform.position = s50.transform.position;
            p50Check = true;
        }
    }

    public void DropP51()
    {
        float distance = Vector3.Distance(p51.transform.position, s51.transform.position);
        
        if (distance < 50)
        {
            p51.transform.position = s51.transform.position;
            p51Check = true;
        }
    }

    public void DropP52()
    {
        float distance = Vector3.Distance(p52.transform.position, s52.transform.position);
        
        if (distance < 50)
        {
            p52.transform.position = s52.transform.position;
            p52Check = true;
        }
    }

    public void DropP53()
    {
        float distance = Vector3.Distance(p53.transform.position, s53.transform.position);
        
        if (distance < 50)
        {
            p53.transform.position = s53.transform.position;
            p53Check = true;
        }
    }

    public void DropP54()
    {
        float distance = Vector3.Distance(p54.transform.position, s54.transform.position);
        
        if (distance < 50)
        {
            p54.transform.position = s54.transform.position;
            p54Check = true;
        }
    }

    public void DropP55()
    {
        float distance = Vector3.Distance(p55.transform.position, s55.transform.position);
        
        if (distance < 50)
        {
            p55.transform.position = s55.transform.position;
            p55Check = true;
        }
    }

    public void DropP56()
    {
        float distance = Vector3.Distance(p56.transform.position, s56.transform.position);
        
        if (distance < 50)
        {
            p56.transform.position = s56.transform.position;
            p56Check = true;
        }
    }

    public void DropP57()
    {
        float distance = Vector3.Distance(p57.transform.position, s57.transform.position);
        
        if (distance < 50)
        {
            p57.transform.position = s57.transform.position;
            p57Check = true;
        }
    }

    public void DropP58()
    {
        float distance = Vector3.Distance(p58.transform.position, s58.transform.position);
        
        if (distance < 50)
        {
            p58.transform.position = s58.transform.position;
            p58Check = true;
        }
    }

    public void DropP59()
    {
        float distance = Vector3.Distance(p59.transform.position, s59.transform.position);
        
        if (distance < 50)
        {
            p59.transform.position = s59.transform.position;
            p59Check = true;
        }
    }

    public void DropP60()
    {
        float distance = Vector3.Distance(p60.transform.position, s60.transform.position);
        
        if (distance < 50)
        {
            p60.transform.position = s60.transform.position;
            p60Check = true;
        }
    }

    public void DropP61()
    {
        float distance = Vector3.Distance(p61.transform.position, s61.transform.position);
        
        if (distance < 50)
        {
            p61.transform.position = s61.transform.position;
            p61Check = true;
        }
    }

    public void DropP62()
    {
        float distance = Vector3.Distance(p62.transform.position, s62.transform.position);
        
        if (distance < 50)
        {
            p62.transform.position = s62.transform.position;
            p62Check = true;
        }
    }

    public void DropP63()
    {
        float distance = Vector3.Distance(p63.transform.position, s63.transform.position);
        
        if (distance < 50)
        {
            p63.transform.position = s63.transform.position;
            p63Check = true;
        }
    }

    public void DropP64()
    {
        float distance = Vector3.Distance(p64.transform.position, s64.transform.position);
        
        if (distance < 50)
        {
            p64.transform.position = s64.transform.position;
            p64Check = true;
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
        && p6Check && p7Check && p8Check && p9Check && p10Check
        && p11Check && p12Check && p13Check && p14Check && p15Check
        && p16Check && p17Check && p18Check && p19Check && p20Check
        && p21Check && p22Check && p23Check && p24Check && p25Check)
        {
            if(Skor == 0)
            {
                Debug.Log("Tebrikler...");
                Skor +=1;
            }
        }
    }
}
