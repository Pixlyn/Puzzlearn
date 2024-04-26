using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class temelMenuManager : MonoBehaviour
{
    [SerializeField] private GameObject temelMenu,temel2Menu,audioMenu;
    [SerializeField] Image soundOnIcon;
    [SerializeField] Image soundOffIcon;
    private bool muted = false; 

    void Start()
    {
        temelMenu.SetActive(true);
        temel2Menu.SetActive(false);
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
        temelMenu.GetComponent<CanvasGroup>().DOFade(1, 1f);
        temelMenu.GetComponent<CanvasGroup>().interactable = true;
        audioMenu.GetComponent<CanvasGroup>().DOFade(1, 1f);
        audioMenu.GetComponent<CanvasGroup>().interactable = true;
    }
    
    /*________________________________________________________________________________________________________*/
    
    public void Page2()
    {
        temelMenu.GetComponent<CanvasGroup>().DOFade(0, 1f);
        temelMenu.GetComponent<CanvasGroup>().interactable = false;
        temelMenu.SetActive(false);
        //---------------------------------------------------------------------
        temel2Menu.SetActive(true);
        temel2Menu.GetComponent<CanvasGroup>().DOFade(1, 1f);
        temel2Menu.GetComponent<CanvasGroup>().interactable = true;
    }
    
    /*________________________________________________________________________________________________________*/
    
    public void Page1()
    {
        temel2Menu.GetComponent<CanvasGroup>().DOFade(0, 1f);
        temel2Menu.GetComponent<CanvasGroup>().interactable = false;
        temel2Menu.SetActive(false);
        //---------------------------------------------------------------------
        temelMenu.SetActive(true);
        temelMenu.GetComponent<CanvasGroup>().DOFade(1, 1f);
        temelMenu.GetComponent<CanvasGroup>().interactable = true;
    }
    /*________________________________________________________________________________________________________*/
     
    public void Hayvanlar()
    {
        SceneManager.LoadScene("Hayvanlar");
    }
    /*________________________________________________________________________________________________________*/
     
    public void Meyveler()
    {
        SceneManager.LoadScene("Meyveler");
    }
    /*________________________________________________________________________________________________________*/
     
    public void Sebzeler()
    {
        SceneManager.LoadScene("Sebzeler");
    }
    /*________________________________________________________________________________________________________*/
     
    public void Sayilar()
    {
        SceneManager.LoadScene("Sayilar");
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
