using UnityEngine;
// EJERCICIO 1 Y 2

public class NotifyCollisionCylinder : MonoBehaviour
{
  public delegate void message();
  public event message OnCollisionWithCylinder;

  // Start is called once before the first execution of Update after the MonoBehaviour is created
  void Start()
  {
      
  }

  // Update is called once per frame
  void Update()
  {
      
  }

  void OnTriggerEnter(Collider collision)
  {
    string name = collision.gameObject.name;
    if (name == "Cylinder")
    {
      OnCollisionWithCylinder();
    }
  }
}
