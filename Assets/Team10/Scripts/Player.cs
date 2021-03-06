using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MatrixJam.Team10
{
    public class Player : MonoBehaviour
    {
        public float speed;
        
        private Rigidbody2D myRigidBody;
        private Vector3 change;
        
        // Start is called before the first frame update
        void Start()
        {
            myRigidBody = GetComponent<Rigidbody2D>();            
        }

        // Update is called once per frame
        void Update()
        {
            change = Vector3.zero;
            change.x = Input.GetAxisRaw("Horizontal");
            change.y = Input.GetAxisRaw("Vertical");
            if(change != Vector3.zero){
                moveCharacter();
            }   
        }

        void moveCharacter(){
            myRigidBody.MovePosition(
                transform.position + change.normalized * speed * Time.deltaTime
            );
        }
    }
}
