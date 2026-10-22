using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Game_Manager : MonoBehaviour
{
    public int p1;
    public int p2;
    public string pointsCount;
    public TextMeshProUGUI marcadorText;
    public void UpdatePointsText()
    {
        pointsCount = p1 + "|" + p2;
        marcadorText.text = pointsCount;
    }
}
