using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UpSurge
{
    public class ItemManager : MonoBehaviour
    {
        public Collectable[] collectableItems;
        private Dictionary<CollectableType,Collectable> collectableItemsDict = new Dictionary<CollectableType,Collectable>();

        private void Awake()
        {
            foreach (Collectable item in collectableItems)
            {
                AddItems(item);
            }
        }
        private void AddItems(Collectable item)
        {
            if(!collectableItemsDict.ContainsKey(item.type))
            {
                collectableItemsDict.Add(item.type, item);
            }
        }
        public Collectable GetItemByType(CollectableType type)
        {
            if(collectableItemsDict.ContainsKey(type))
            {
                return collectableItemsDict[type];

            }
            return null;
        }
    }
}
