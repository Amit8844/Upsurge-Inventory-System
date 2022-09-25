
using UnityEngine;



namespace UpSurge
{
    public class PlayerController : MonoBehaviour
    {
       [SerializeField] private float       f_MoveSpeed;
       [SerializeField] private Rigidbody2D m_RigidBody;
       [SerializeField] private Animator    a_Animator;
       

       
        void Update()
        {
            Inputs();
        }
        
        private void Inputs()
        {
            

            float moveX = Input.GetAxisRaw("Horizontal");
            float moveY = Input.GetAxisRaw("Vertical");

            a_Animator.SetFloat("Speed", Mathf.Abs(moveX));
          

            transform.localPosition += f_MoveSpeed * moveX * Time.deltaTime * Vector3.right;
            transform.localPosition += f_MoveSpeed * moveY * Time.deltaTime * Vector3.up;
            Flip(moveX);


        }

        private void Flip(float moveX )
        {
            if (moveX < 0)
            {
                transform.rotation = Quaternion.Euler(transform.rotation.x, 180, transform.rotation.z);
            }
            else if (moveX > 0)
            {
                transform.rotation = Quaternion.Euler(transform.rotation.x, 0, transform.rotation.z);
            }
            
        }
       

    }
}
       
      

        

      

        


        

