using UnityEngine;
// EJERCICIO 4

public class CollTransportHuman2Answer : MonoBehaviour
{
  public NotifyCollTransporter notifier;
  private Transform tr;
  private Transform targetTr;

  void Start()
  {
    notifier.OnCollisionWithTransporter += answerHumanoid2;
    tr = transform;
    GameObject targetObj = null;
    targetObj = GameObject.Find("ObjetivoCentro");
    if (targetObj != null) {
      targetTr = targetObj.GetComponent<Transform>();
    }
  }

  void answerHumanoid2() {
    if (tr != null && targetTr != null) {
      tr.LookAt(targetTr.position);
    }
  }

}
