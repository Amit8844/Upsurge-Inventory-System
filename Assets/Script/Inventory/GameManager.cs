
using UnityEngine;


namespace UpSurge
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager instance;
        public ItemManager itemManager;
        

        private void Awake()
        {
            if(instance != null && instance != this)
            {
                Destroy(this.gameObject);
            }
            else
            {
                instance = this;
            }
            DontDestroyOnLoad(this.gameObject);

            itemManager = GetComponent<ItemManager>();
        }
       

    }
}
