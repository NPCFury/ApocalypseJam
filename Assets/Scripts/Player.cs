using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

        float playerSpeed; //speed character moves
        private float upBound, downBound, leftBound, rightBound; // boundaries for character movement
        Vector3 screenCenter;
        void Start()
        {
                playerSpeed = 10f;

                // lol maybe these will be constants declared somewhere someday
                //upBound = 5f;
                //downBound = -3f;
                //leftBound = -4f;
                //rightBound = 4f;
                screenCenter = new Vector3(Screen.width/2, Screen.height/2, Camera.main.nearClipPlane);//new Vector3(Screen.width / 2, Screen.height / 2, 0);
        }

        void Update () 
        {


                // I don't think this is the best way to do this haha
                //UpdateRadius();
                
				//MoveCheck();
	
				UpdatePos();
                //SwitchFireCheck();
        }


        void MoveCheck()
        {
                if(Input.GetKey("w"))
                {
                        //if (transform.position.y < upBound)
                                transform.Translate(0, playerSpeed * Time.deltaTime, 0);
                }
                if(Input.GetKey("s"))
                {
                        //if (transform.position.y > downBound)
                                transform.Translate(0, -playerSpeed * Time.deltaTime, 0);
                }
                if(Input.GetKey("a"))
                {
                        //if (transform.position.x > leftBound)
							transform.RotateAround(screenCenter, Vector3.forward, -20 * Time.deltaTime);
                }
                if(Input.GetKey("d"))
                {
						//if (transform.position.x > leftBound)
                        	transform.RotateAround(screenCenter, Vector3.forward, 20 * Time.deltaTime);
                }
        }

        void ChangePlayerRadius()
        {
			
        }

        void ChangePlayerAngularVelocity()
        {
			
        }

	void UpdatePos()
	{
		transform.position = screenCenter;
	}
}
