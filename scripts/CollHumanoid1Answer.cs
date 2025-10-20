using UnityEngine;
// EJERCICIO 3

public class CollHumanoid1Answer : MonoBehaviour
{
  public NotifyCollHumanoids notifier;
  private Transform tr;
  private Transform targetTr;
  bool pursueTarget = false;
  public float speed = 5f;

  void Start()
  {
    notifier.OnCollisionWithHumanoid1 += answerCollisionHumanoid1;
    tr = transform;
    GameObject targetObj = null;
    targetObj = GameObject.Find("ContenedorEscudos2");
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

  void answerCollisionHumanoid1() {
    if (tr != null && targetTr != null) {
      pursueTarget = true;
    }
  }

}
