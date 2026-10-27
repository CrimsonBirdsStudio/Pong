using DG.Tweening;
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
        string lastPoints = pointsCount; //ESTO NO LO COPIES
        pointsCount = p1 + "|" + p2;
        marcadorText.text = pointsCount;
        if(lastPoints!=pointsCount)AnimatePointsText(); //ESTO TAMPOCO LOL
    }

    private void AnimatePointsText()
    {
        marcadorText.DOKill();
        marcadorText.transform.DOKill();

        Transform textTransform = marcadorText.transform;
        Vector3 originalScale = textTransform.localScale;

        marcadorText.alpha = 0f;
        textTransform.localScale = Vector3.zero;

        Sequence sequence = DOTween.Sequence();

        sequence.Join(textTransform.DOScale(originalScale, 0.5f).SetEase(Ease.OutBack));
        sequence.Join(marcadorText.DOFade(.5f, 0.5f));

        sequence.AppendInterval(1f);

        sequence.Append(marcadorText.DOFade(0f, 0.5f));
    }
}
