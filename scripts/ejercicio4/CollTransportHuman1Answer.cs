using UnityEngine;
// EJERCICIO 4

public class CollTransportHuman1Answer : MonoBehaviour
{
  public NotifyCollTransporter notifier;
  private Transform tr;
  private Transform targetTr;

  void Start()
  {
    notifier.OnCollisionWithTransporter += answerHumanoid1;
    tr = transform;
    GameObject targetObj = null;
    targetObj = GameObject.Find("ObjetivoEscudo");
    if (targetObj != null) {
      targetTr = targetObj.GetComponent<Transform>();
    }
  }

  // void Update()
  // {
  //   if (pursueTarget && targetTr != null) {
  //     Vector3 direction = (targetTr.position - tr.position).normalized;
  //     tr.position += direction * speed * Time.deltaTime;
  //   }
  // }

  void answerHumanoid1() {
    if (tr != null && targetTr != null) {
      tr.position = targetTr.position;
    }
  }

}
