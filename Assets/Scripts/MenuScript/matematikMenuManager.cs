using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class matematikMenuManager : MonoBehaviour
{
    [SerializeField] private GameObject matematikMenu,matematik2Menu,audioMenu;
    [SerializeField] Image soundOnIcon;
    [SerializeField] Image soundOffIcon;
    private bool muted = false; 

    void Start()
    {
        matematikMenu.SetActive(true);
        matematik2Menu.SetActive(false);
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
        matematikMenu.GetComponent<CanvasGroup>().DOFade(1, 1f);
        matematikMenu.GetComponent<CanvasGroup>().interactable = true;
        audioMenu.GetComponent<CanvasGroup>().DOFade(1, 1f);
        audioMenu.GetComponent<CanvasGroup>().interactable = true;
    }
    
    /*________________________________________________________________________________________________________*/
    
    public void Page2()
    {
        matematikMenu.GetComponent<CanvasGroup>().DOFade(0, 1f);
        matematikMenu.GetComponent<CanvasGroup>().interactable = false;
        matematikMenu.SetActive(false);
        //---------------------------------------------------------------------
        matematik2Menu.SetActive(true);
        matematik2Menu.GetComponent<CanvasGroup>().DOFade(1, 1f);
        matematik2Menu.GetComponent<CanvasGroup>().interactable = true;
    }
    
    /*________________________________________________________________________________________________________*/
    
    public void Page1()
    {
        matematik2Menu.GetComponent<CanvasGroup>().DOFade(0, 1f);
        matematik2Menu.GetComponent<CanvasGroup>().interactable = false;
        matematik2Menu.SetActive(false);
        //---------------------------------------------------------------------
        matematikMenu.SetActive(true);
        matematikMenu.GetComponent<CanvasGroup>().DOFade(1, 1f);
        matematikMenu.GetComponent<CanvasGroup>().interactable = true;
    }
    /*________________________________________________________________________________________________________*/
     
    public void Toplama()
    {
        SceneManager.LoadScene("Toplama");
    }
    /*________________________________________________________________________________________________________*/
     
    public void Cikarma()
    {
        SceneManager.LoadScene("Cikarma");
    }
    /*________________________________________________________________________________________________________*/
     
    public void Carpma()
    {
        SceneManager.LoadScene("Carpma");
    }
    /*________________________________________________________________________________________________________*/
     
    public void Bolme()
    {
        SceneManager.LoadScene("Bolme");
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
