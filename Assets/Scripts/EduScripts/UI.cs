using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public Image questionImage;
    public InputField inputAnswer;
    public Text questName;


    public void QuestionUpdater(Sprite questionSprite, string questionName)
    {
        questionImage.sprite = questionSprite;
        questName.text = questionName.ToString();
        questionImage.color = new Color (1,1,1,255);
    }

    public void ClearQuestion()
    {
        questionImage.sprite = null;
        questName.text = null;
        questionImage.color = new Color (0,0,0,0);
        inputAnswer.Select();
        inputAnswer.text = "";
    }
}
