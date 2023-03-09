using System;
using UnityEngine;

namespace Player
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class PlayerController : MonoBehaviour
    {
        // Variables for Dungeon player game
        [Header("Player Customization")]
        public string playerName = "Player";
        
        [Space]
        [Header("Stats")]
        public float speed = 5f;
        public int playerHealth = 100;
        public bool isAlive = true;
        public float playerDamage = 10f;
        
        #region Components
        private Rigidbody2D _rigidbody2D;
        #endregion
        
        #region Variables for Player Movement
        
        private int _horizontalInput;
        private int _verticalInput;

        #endregion

        private void Awake()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
        }

        private void Start()
        {
            
        }

        private void Update()
        {
            // Set horizontal and vertical input
            _horizontalInput = (int) Input.GetAxisRaw("Horizontal");
            _verticalInput = (int) Input.GetAxisRaw("Vertical");
            
            // Diection
            Vector2 direction = new Vector2(_horizontalInput, _verticalInput);

            // Move player using physics and velocity
            _rigidbody2D.velocity = direction * speed;
        }

    }
}
