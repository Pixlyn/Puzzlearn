using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class englishMenuManager : MonoBehaviour
{
    [SerializeField] private GameObject englishMenu,english2Menu,audioMenu;
    [SerializeField] Image soundOnIcon;
    [SerializeField] Image soundOffIcon;
    private bool muted = false; 

    void Start()
    {
        englishMenu.SetActive(true);
        english2Menu.SetActive(false);
        audioMenu.SetActive(true);

        FadeOut();
        
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
    
    /*________________________________________________________________________________________________________*/ 
    
    void FadeOut()
    {
        englishMenu.GetComponent<CanvasGroup>().DOFade(1, 1f);
        englishMenu.GetComponent<CanvasGroup>().interactable = true;
        audioMenu.GetComponent<CanvasGroup>().DOFade(1, 1f);
        audioMenu.GetComponent<CanvasGroup>().interactable = true;
    }
    
    /*________________________________________________________________________________________________________*/
    
    public void Page2()
    {
        englishMenu.GetComponent<CanvasGroup>().DOFade(0, 1f);
        englishMenu.GetComponent<CanvasGroup>().interactable = false;
        englishMenu.SetActive(false);
        //---------------------------------------------------------------------
        english2Menu.SetActive(true);
        english2Menu.GetComponent<CanvasGroup>().DOFade(1, 1f);
        english2Menu.GetComponent<CanvasGroup>().interactable = true;
    }
    
    /*________________________________________________________________________________________________________*/
    
    public void Page1()
    {
        english2Menu.GetComponent<CanvasGroup>().DOFade(0, 1f);
        english2Menu.GetComponent<CanvasGroup>().interactable = false;
        english2Menu.SetActive(false);
        //---------------------------------------------------------------------
        englishMenu.SetActive(true);
        englishMenu.GetComponent<CanvasGroup>().DOFade(1, 1f);
        englishMenu.GetComponent<CanvasGroup>().interactable = true;
    }
    /*________________________________________________________________________________________________________*/
     
    public void Animals()
    {
        SceneManager.LoadScene("Animals");
    }
    /*________________________________________________________________________________________________________*/
     
    public void Fruits()
    {
        SceneManager.LoadScene("Fruits");
    }
    /*________________________________________________________________________________________________________*/
     
    public void Vegetables()
    {
        SceneManager.LoadScene("Vegetables");
    }
    /*________________________________________________________________________________________________________*/
     
    public void Numbers()
    {
        SceneManager.LoadScene("Numbers");
    }
    /*________________________________________________________________________________________________________*/
     
    public void School()
    {
        SceneManager.LoadScene("School");
    }
    
    /*________________________________________________________________________________________________________*/
     
    public void MainMenu()
    {
        SceneManager.LoadScene("mainMenu");
    }
    
    /*________________________________________________________________________________________________________*/

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

    /*________________________________________________________________________________________________________*/
    
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
    
    /*________________________________________________________________________________________________________*/
    
    private void Load()
    {
        muted = PlayerPrefs.GetInt("muted") == 1;
    }
    
    /*________________________________________________________________________________________________________*/
    
    private void Save()
    {
        PlayerPrefs.SetInt("muted", muted ? 1 : 0);
    }
    
    /*________________________________________________________________________________________________________*/

}
