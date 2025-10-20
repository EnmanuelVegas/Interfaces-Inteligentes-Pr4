using UnityEngine;
// EJERCICIO 1 Y 2

public class BallHumanoidAnswer : MonoBehaviour
{
  public NotifyCollisionCylinder notifier;
  private Transform tr;
  private Transform targetTr;
  bool pursueTarget = false;
  public float speed = 5f;

  void Start()
  {
    notifier.OnCollisionWithCylinder += ballHumanoidAnswer;
    tr = transform;
    GameObject targetObj = null;
    if (gameObject.tag == "tipo1") {
      targetObj = GameObject.Find("Objetivo");
    }
    else if (gameObject.tag == "tipo2") {
      targetObj = GameObject.Find("Cylinder");
    }
    if (targetObj != null) {
      targetTr = targetObj.GetComponent<Transform>();
    }
  }

  // Update is called once per frame
  void Update()
  {
    if (pursueTarget && targetTr != null) {
      Vector3 direction = (targetTr.position - tr.position).normalized;
      tr.position += direction * speed * Time.deltaTime;
    }
  }

  void ballHumanoidAnswer() {
    if (tr != null && targetTr != null) {
      pursueTarget = !pursueTarget;
    }
  }
}
