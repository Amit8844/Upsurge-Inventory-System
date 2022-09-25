using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace UpSurge
{
    public class Inventory_UI : MonoBehaviour
    {
        public GameObject inevntoryPanel;
        public Player     player;

        public List<Slots_Ui> slots = new List<Slots_Ui>();
        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.I))
            {
                ToggleInventory();
            }
        }
        public void ToggleInventory()
        {
            if(!inevntoryPanel.activeSelf)
            {
                inevntoryPanel.SetActive(true);
                Referesh();
            }
            else
            {
                inevntoryPanel.SetActive(false);
            }
        }
      void Referesh()
      {
            if(slots.Count == player.inventory.slots.Count)
            {
                for (int i = 0; i < slots.Count; i++)
                {
                    if (player.inventory.slots[i].type != CollectableType.NONE)
                    {
                        slots[i].SetItem(player.inventory.slots[i]);
                    }
                    else
                    {
                        slots[i].SetEmpty();
                    }
                }
            }
      }
        public void Remove(int slotID)
        {
            Collectable itemToDrop = GameManager.instance.itemManager.GetItemByType(player.inventory.slots[slotID].type);
            if(itemToDrop != null)
            {
                player.DropItem(itemToDrop);
                player.inventory.Remove(slotID);
                Referesh();
            }
           
        }
    }
}
