using UnityEngine;

public class IncreaseUIPoints : MonoBehaviour
{
  public delegate void message(int points);
  public event message OnCollisionWithShields;
  public int points = 0;

  void OnTriggerEnter(Collider other) 
  {
    if (other == null) return;
    string tag = other.gameObject.tag;
    if (tag.StartsWith("escudo_"))
    {
      string tipo = tag.Substring("escudo_".Length);
      switch (tipo)
      {
        case "1":
          points += 5;
          break;
        case "2":
          points += 10;
          break;
        default:
          break;
      }
      Destroy(other.gameObject);
    }
    if (other.gameObject.tag == "monstruo")
    {
      points -= 10;
      Debug.Log($"Puntos deducidos: {points}");      
    }
    OnCollisionWithShields(points);
  }
}
