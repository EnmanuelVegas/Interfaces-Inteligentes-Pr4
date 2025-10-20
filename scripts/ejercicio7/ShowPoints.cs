// using UnityEngine;

// public class IncreasePoints : MonoBehaviour
// {
//   public int points = 0;

//   void Start()
//   {
      
//   }

//   // Update is called once per frame
//   void Update()
//   {
//     // TextMeshProUGUI 
      
//   }

//   void OnTriggerEnter(Collider other) 
//   {
//     if (other == null) return;
//     string tag = other.gameObject.tag;
//     if (tag.StartsWith("escudo_"))
//     {
//       string tipo = tag.Substring("escudo_".Length);
//       switch (tipo)
//       {
//         case "1":
//           points += 5;
//           break;

//         case "2":
//           points += 10;
//           break;
//         default:
//           break;
//       }
//       Debug.Log($"Puntos incrementados: {points} (tipo: {tipo})");
//       Destroy(other.gameObject);
//     }
//   }
// }
