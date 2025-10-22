using UnityEngine;
using TMPro;

public class ShowPoints : MonoBehaviour
{
  public IncreaseUIPoints notifier;
  public GameObject rewardImage;
  public TMP_Text uiText;
  public int threshold = 0;
  private

  void Start()
  {
    // Texto
    if (uiText == null)
    {
      GameObject text = GameObject.Find("PointsDisplayer");
      if (text != null) uiText = text.GetComponent<TMP_Text>();
      notifier.OnCollisionWithShields += answerCounter;
    }
    // Imagen
    GameObject image = GameObject.Find("Reward");
    if (image != null) rewardImage = image;
    // Inicialización
    if (uiText != null) uiText.text = "Puntos: 0";
    if (rewardImage != null) rewardImage.SetActive(false);
  }
  
  void answerCounter(int points)
  {
    if (uiText != null) uiText.text = "Puntos: " + points;
    if (points >= 100)
    {
      rewardImage.SetActive(true);      
    }
  }
}
