using UnityEngine;
// EJERCICIO 3

public class ChangeShieldColor : MonoBehaviour
{
  private Renderer rd;

  void Start()
  {
    rd = gameObject.GetComponentInChildren<Renderer>();
  }

  // Update is called once per frame
  void Update()
  {
  }

  void OnTriggerEnter(Collider other) {
    if (rd != null && other.gameObject.tag == "tipo1") {
      Debug.Log("colorsito");
      rd.material.color = new Color(
        Random.Range(0f, 1f),
        Random.Range(0f, 1f),
        Random.Range(0f, 1f)
      );
    }
  }

}
