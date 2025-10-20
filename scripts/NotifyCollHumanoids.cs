using UnityEngine;
// EJERCICIO 3

public class NotifyCollHumanoids : MonoBehaviour
{
  public delegate void message();
  public event message OnCollisionWithHumanoid1;
  public event message OnCollisionWithHumanoid2;

  // void OnCollisionEnter(Collision collision)
  // {
  //   // string tag = collision.gameObject.tag;
  // }

  void OnTriggerEnter(Collider collision) {
    string tag = collision.gameObject.tag;
    if (tag == "tipo1")
    {
      OnCollisionWithHumanoid1();
    }
    if (tag == "tipo2")
    {
      OnCollisionWithHumanoid2();
    }
  }
}
