using System;
using UnityEngine;

namespace Player
{
    public class PlayerController : MonoBehaviour
    {
        // Variables for Dungeon player game
        public float speed = 5f;
        public string playerName = "Player";
        public int playerHealth = 100;
        public bool isAlive = true;
        public float playerDamage = 10f;
        
        private void Start()
        {
            print("Player name: " + playerName);
        }
        
    }
}
