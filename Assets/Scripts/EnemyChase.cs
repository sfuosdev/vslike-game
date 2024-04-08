using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class EnemyChase : MonoBehaviour
    {
        public Transform target; // The target that the enemy will chase (your player)
        public float speed = 5f;

        private void Start()
        {
            // Find the player by tag and set it as the target -7.41 0.88 0.5
            target = GameObject.FindGameObjectWithTag("Player").transform.Find("sprite_player");
        }

        void Update()
        {
            // Check if the target exists
            if (target != null)
            {
                // Move towards the target's current position
                transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            }
        }
    }
}