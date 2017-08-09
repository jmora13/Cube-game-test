using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class NewBehaviourScript : MonoBehaviour
    {
        public float moveSpeed;
        // Use this for initialization
        void Start()
        {
            print("YOOOOOO");
            moveSpeed = 1f;
        }

        // Update is called once per frame
        void Update()
        {
        
            transform.Translate(moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime);
        }
        void OnCollisionEnter(Collision col)
        {
            
            if (col.gameObject.name == "switches")
            {

                Debug.Log(col.collider.name);
                print("FUCK SHIT UP!!!111!!!!1");
                Physics.gravity = new Vector3(0, -9.81F, -9.81F);
                //Application.LoadLevel("Level 2");
            }
        }

        void OnCollisionExit(Collision collisionInfo)
        {
            print("SWITCH END");
        }
    }


