using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menuManager : MonoBehaviour
{
    [SerializeField] private GameObject mainMenu,playMenu,klasikMenu,kareMenu,learnMenu,audioMenu;
    [SerializeField] Image soundOnIcon;
    [SerializeField] Image soundOffIcon;
    private bool muted = false; 

    void Start()
    {
        mainMenu.SetActive(true);
        playMenu.SetActive(false);
        klasikMenu.SetActive(false);
        kareMenu.SetActive(false);
        learnMenu.SetActive(false);
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
        mainMenu.GetComponent<CanvasGroup>().DOFade(1, 1f);
        mainMenu.GetComponent<CanvasGroup>().interactable = true;
        audioMenu.GetComponent<CanvasGroup>().DOFade(1, 1f);
        audioMenu.GetComponent<CanvasGroup>().interactable = true;
    }
    
    /*________________________________________________________________________________________________________*/
    
    public void Play()
    {
        mainMenu.GetComponent<CanvasGroup>().DOFade(0, 1f);
        mainMenu.GetComponent<CanvasGroup>().interactable = false;
        mainMenu.SetActive(false);
        //---------------------------------------------------------------------
        playMenu.SetActive(true);
        playMenu.GetComponent<CanvasGroup>().DOFade(1, 1f);
        playMenu.GetComponent<CanvasGroup>().interactable = true;
    }
    
    /*________________________________________________________________________________________________________*/
    
    public void PlayGeri()
    {
        playMenu.GetComponent<CanvasGroup>().DOFade(0, 1f);
        playMenu.GetComponent<CanvasGroup>().interactable = false;
        playMenu.SetActive(false);
        //---------------------------------------------------------------------
        mainMenu.SetActive(true);
        mainMenu.GetComponent<CanvasGroup>().DOFade(1, 1f);
        mainMenu.GetComponent<CanvasGroup>().interactable = true;
    }
    
    /*________________________________________________________________________________________________________*/
    
    public void Klasik()
    {
        playMenu.GetComponent<CanvasGroup>().DOFade(0, 1f);
        playMenu.GetComponent<CanvasGroup>().interactable = false;
        playMenu.SetActive(false);
        //---------------------------------------------------------------------
        klasikMenu.SetActive(true);
        klasikMenu.GetComponent<CanvasGroup>().DOFade(1, 1f);
        klasikMenu.GetComponent<CanvasGroup>().interactable = true;
    }
    
    /*________________________________________________________________________________________________________*/
    
    public void KlasikGeri()
    {
        klasikMenu.GetComponent<CanvasGroup>().DOFade(0, 1f);
        klasikMenu.GetComponent<CanvasGroup>().interactable = false;
        klasikMenu.SetActive(false);
        //---------------------------------------------------------------------
        playMenu.SetActive(true);
        playMenu.GetComponent<CanvasGroup>().DOFade(1, 1f);
        playMenu.GetComponent<CanvasGroup>().interactable = true;
    }
    
    /*________________________________________________________________________________________________________*/
    
    public void Kare()
    {
        playMenu.GetComponent<CanvasGroup>().DOFade(0, 1f);
        playMenu.GetComponent<CanvasGroup>().interactable = false;
        playMenu.SetActive(false);
        //---------------------------------------------------------------------
        kareMenu.SetActive(true);
        kareMenu.GetComponent<CanvasGroup>().DOFade(1, 1f);
        kareMenu.GetComponent<CanvasGroup>().interactable = true;
    }
    
    /*________________________________________________________________________________________________________*/
    
    public void KareGeri()
    {
        kareMenu.GetComponent<CanvasGroup>().DOFade(0, 1f);
        kareMenu.GetComponent<CanvasGroup>().interactable = false;
        kareMenu.SetActive(false);
        //---------------------------------------------------------------------
        playMenu.SetActive(true);
        playMenu.GetComponent<CanvasGroup>().DOFade(1, 1f);
        playMenu.GetComponent<CanvasGroup>().interactable = true;
    }
    
    /*________________________________________________________________________________________________________*/
    
    public void Learn()
    {
        mainMenu.GetComponent<CanvasGroup>().DOFade(0, 1f);
        mainMenu.GetComponent<CanvasGroup>().interactable = false;
        mainMenu.SetActive(false);
        //---------------------------------------------------------------------
        learnMenu.SetActive(true);
        learnMenu.GetComponent<CanvasGroup>().DOFade(1, 1f);
        learnMenu.GetComponent<CanvasGroup>().interactable = true;
    }
    
    /*________________________________________________________________________________________________________*/
    
    public void LearnGeri()
    {
        learnMenu.GetComponent<CanvasGroup>().DOFade(0, 1f);
        learnMenu.GetComponent<CanvasGroup>().interactable = false;
        learnMenu.SetActive(false);
        //---------------------------------------------------------------------
        mainMenu.SetActive(true);
        mainMenu.GetComponent<CanvasGroup>().DOFade(1, 1f);
        mainMenu.GetComponent<CanvasGroup>().interactable = true;
    }
    
    /*________________________________________________________________________________________________________*/
    
    public void KlasikKolay()
    {
        SceneManager.LoadScene("klasikKolay");
    }
    
    /*________________________________________________________________________________________________________*/
    
    public void KlasikNormal()
    {
        SceneManager.LoadScene("klasikNormal");
    }
    
    /*________________________________________________________________________________________________________*/
    
    public void KlasikZor()
    {
        SceneManager.LoadScene("klasikZor");
    }
    
    /*________________________________________________________________________________________________________*/
    
    public void KareKolay()
    {
        SceneManager.LoadScene("kareKolay");
    }
    
    /*________________________________________________________________________________________________________*/
    
    public void KareNormal()
    {
        SceneManager.LoadScene("kareNormal");
    }
    
    /*________________________________________________________________________________________________________*/
    
    public void KareZor()
    {
        SceneManager.LoadScene("kareZor");
    }
    
    /*________________________________________________________________________________________________________*/
     
    public void TemelMenu()
    {
        SceneManager.LoadScene("TemelMenu");
    }
    
    /*________________________________________________________________________________________________________*/
     
    public void MatematikMenu()
    {
        SceneManager.LoadScene("MatematikMenu");
    }
    
    /*________________________________________________________________________________________________________*/
     
    public void EnglishMenu()
    {
        SceneManager.LoadScene("EnglishMenu");
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
    
    public void ExitGame()
    {
        Debug.Log("ExitGame");
        Application.Quit();
    }

}
