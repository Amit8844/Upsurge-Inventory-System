
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UpSurge
{
    public class Slots_Ui : MonoBehaviour
    {
        public Image ItemIcon;
        public TextMeshProUGUI quantityText;

        public void SetItem(Inventory.Slot slot)
        {
            if(slot != null)
            {
                ItemIcon.sprite = slot.icon;
                ItemIcon.color = new Color(1, 1, 1, 1);
                quantityText.text = slot.count.ToString();
            }
            
        }
        public void SetEmpty()
        {
            ItemIcon.sprite = null;
            ItemIcon.color  = new Color( 1, 1, 1, 0);
            quantityText.text = "";
        }
    }
}
