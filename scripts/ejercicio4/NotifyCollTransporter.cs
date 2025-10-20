using UnityEngine;
// EJERCICIO 4

public class NotifyCollTransporter : MonoBehaviour
{
  public delegate void message();
  public event message OnCollisionWithTransporter;

  void OnTriggerEnter(Collider collision) {
    string tag = collision.gameObject.tag;
    if (tag == "cilindroTransportador") 
    {
      OnCollisionWithTransporter();
    }
  }
}
