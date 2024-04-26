using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionGenerator : MonoBehaviour
{
    public List<Soru> Sorular; 

    void Start()
    {
        for(int i = 0; i < Sorular.Count; i++)
        {
            Sorular[i].isTrue = false;
        }
    }
}
