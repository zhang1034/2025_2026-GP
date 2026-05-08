// using UnityEngine;
// using System.Collections.Generic;

// public class Enemy : MonoBehaviour
// {
//     public int health = 100;

//     public void TakeDamage(int damage)
//     {
//         health -= damage;
//     }
// }
// ////////////////////////////////////////////
// public class Player : MonoBehaviour
// {
//     public void Attack(Enemy enemy)
//     {
//         enemy.TakeDamage(20);
//     }
// }




// public class Item : MonoBehaviour
// {
//     public string itemName;
// }
// ////////////////////////////////////////////
// public class Inventory : MonoBehaviour
// {
//     public List<Item> items = new List<Item>();

//     public void AddItem(Item item)
//     {
//         items.Add(item);
//     }
// }




// public class Weapon
// {
//     public int damage = 10;
// }
// ////////////////////////////////////////////
// public class Player : MonoBehaviour
// {
//     private Weapon weapon;

//     void Awake()
//     {
//         weapon = new Weapon();
//     }

//     public void Attack()
//     {
//         Debug.Log();
//     }
// }