using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace UpSurge
{
    public class Player : MonoBehaviour
    {
        public Inventory inventory;

        private void Awake()
        {
            inventory = new Inventory(27);
        }
        public void DropItem(Collectable item)
        {
            Vector2 spawnLocation = transform.position;
            Vector2 spawnOffset = Random.insideUnitCircle * 2.2f;
            
            Collectable droppedItem = Instantiate(item, spawnLocation + spawnOffset, Quaternion.identity);

            droppedItem.rb2D.AddForce(spawnOffset * 1f, ForceMode2D.Impulse);

        }
    }
}
