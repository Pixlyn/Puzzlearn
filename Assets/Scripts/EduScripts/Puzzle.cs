using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Puzzle : MonoBehaviour
{
    [SerializeField] private GameObject mainMenu,resim,resmiGor,resmiGorme,audioMenu;
    [SerializeField] Image soundOnIcon;
    [SerializeField] Image soundOffIcon;
    [SerializeField] Camera cam;
    [SerializeField] private string selectableTag = "puzzleArea";

    public int questionNum; 
    public Transform _selection;
    public Color newColor;
    public Color defaultColor;

    private bool muted = false; 

    public int maxPuzzlePiece ;
    public int placedPuzzlePiece ;

    public Transform rewardArea;
    public UI ui;
    public Soru Soru;
    public QuestionGenerator Quests; 
    public List<GameObject> puzzleArea;   
    
    
    void Start()
    {
        mainMenu.SetActive(false);
        resmiGorme.SetActive(false);
        resmiGor.SetActive(true);
        resim.SetActive(false);

        if(!PlayerPrefs.HasKey("muted"))
        {
            PlayerPrefs.SetInt("muted", 0);
            Load();
        }

        else
        {
            Load();
        }

        UpdateButtonIcon();
        AudioListener.pause = muted;
    }

    /* -------------------- Is All Placed ? -------------------- */

    public void placedPuzzle()
    {
        placedPuzzlePiece++;

        if (placedPuzzlePiece == maxPuzzlePiece)
        {
            Debug.Log("Tebrikler !");
        }
    }

    /* -------------------- Completed On -------------------- */

    public void ResmiGor()
    {
        resmiGorme.SetActive(true);
        resmiGor.SetActive(false);
        resim.SetActive(true);
    }

    /* -------------------- Completed Off -------------------- */

    public void ResmiGorme()
    {
        resmiGorme.SetActive(false);
        resmiGor.SetActive(true);
        resim.SetActive(false);
    }

    /* -------------------- Are You Sure -------------------- */

    public void AreYouSure()
    {
        mainMenu.SetActive(true);
        mainMenu.GetComponent<CanvasGroup>().DOFade(1, 0.5f);
    }
    
    /* -------------------- Yes -------------------- */

    public void Yes()
    {
        SceneManager.LoadScene("mainMenu");
    }

    /* -------------------- No -------------------- */

    public void No()
    {
        mainMenu.GetComponent<CanvasGroup>().DOFade(0, 0.5f);
        mainMenu.SetActive(false);
    }
    
    /* -------------------- Sound On/Off When Button Press -------------------- */

    public void OnButtonPress()
    {
        if(muted == false)
        {
            muted = true;
            AudioListener.pause = true;
        }

        else
        {
            muted = false;
            AudioListener.pause = false;
        }

        Save();
        UpdateButtonIcon();
    }

    /* -------------------- Change Icon When Button Press -------------------- */
    
    private void UpdateButtonIcon()
    {
        if(muted == false)
        {
            soundOnIcon.enabled = true;
            soundOffIcon.enabled = false;
        }

        else
        {
            soundOnIcon.enabled = false;
            soundOffIcon.enabled = true;
        }
    }

    /* -------------------- Load Sound Settings -------------------- */

    private void Load()
    {
        muted = PlayerPrefs.GetInt("muted") == 1;
    }
    
    /*________________________________________________________________________________________________________*/

    /* -------------------- Save Sound Settings -------------------- */
    
    private void Save()
    {
        PlayerPrefs.SetInt("muted", muted ? 1 : 0);
    }

    void Update()
    {
        /* -------------------- Answer Control -------------------- */
        
        if (Soru != null && ui.inputAnswer.text.ToLower() == Soru.answer)
        {
            if(Soru.isTrue == false)
            {
                Soru.isTrue = true;
                Debug.Log("Doğru");
                Instantiate(Soru.piece, rewardArea);
                ui.ClearQuestion();
                puzzleArea[questionNum-1].GetComponent<PolygonCollider2D>().enabled = false;
                puzzleArea[questionNum-1].GetComponent<SpriteRenderer>().color = defaultColor;
            }
        }
        
        /* -------------------- Click Control -------------------- */

        if (Input.GetMouseButtonUp(0))
        {  
            /* -------------------- Mouse Position And Selection -------------------- */
            
            Vector2 ray = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray, Vector2.zero);
            if (hit.collider == null)
                return;
            GameObject selection = hit.collider.gameObject;

            /* -------------------- Back To Default Color -------------------- */

            if (_selection != null && selection.gameObject.CompareTag(selectableTag))
            {
                SpriteRenderer selectionRenderer = _selection.GetComponent<SpriteRenderer>();
                selectionRenderer.color = defaultColor ;
                _selection = null;
            }
           
            Debug.Log(selection.name);
            
            /* -------------------- Change To New Color -------------------- */

            if (selection.gameObject.CompareTag(selectableTag))
            {
                SpriteRenderer selectionRenderer = selection.GetComponent<SpriteRenderer>();
                
                if (selectionRenderer != null)
                {
                    selectionRenderer.color = newColor ;
                    questionNum = System.Convert.ToInt32(selection.name);
                    Questions(selection, questionNum-1); 
                }
                _selection = selection.transform;
            }
        }
    }

    /* -------------------- Question Update -------------------- */

    void Questions(GameObject selected, int num)
    {
        for(int i = 0; i<Quests.Sorular.Count ; i++)
        {
            if (Quests.Sorular[num].isTrue == false)
            {
                ui.QuestionUpdater(Quests.Sorular[num].question, Quests.Sorular[num].name);
                Soru = Quests.Sorular[num]; 
            }   
        }
    }
}
