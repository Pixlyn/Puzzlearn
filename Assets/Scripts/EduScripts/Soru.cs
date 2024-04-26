using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Soru")]
public class Soru : ScriptableObject
{
    public string name;
    public Sprite question;
    public string answer;
    public bool isTrue;
    public GameObject piece;
    public string pieceNum;
}
