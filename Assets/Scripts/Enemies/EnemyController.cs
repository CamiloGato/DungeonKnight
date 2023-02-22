using System;
using UnityEngine;

namespace Enemies
{
    public class EnemyController : MonoBehaviour
    {
        
        public float speed = 5f;
        public string enemyName = "Enemy";
        public int enemyHealth = 100;
        public bool isAlive = true;
        public float enemyDamage = 10f;

        private void Start()
        {
            print("Enemy name: " + enemyName);
        }
    }
}