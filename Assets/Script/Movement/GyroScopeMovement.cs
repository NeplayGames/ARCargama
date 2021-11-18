using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AR.Movement
{
    public class GyroScopeMovement : MonoBehaviour
    {
        private Gyroscope gyroscope;
        private bool gyroIsActive = false;


        //Add Player Character to this field
        [SerializeField] Transform player;

        ///Used to store the initial gyro value to make the player face correct direction on beginnig
        //This is done by deducting the initial value in actual value
        float initialRotationX;
        private void Start()
        {
            EnableGyro();
        }
        ///<summary>
        ///THis check if it is possible to get any gyro from the device it supports
        ///</summary>

        void EnableGyro()
        {
            if (gyroIsActive)
                return;
            if (SystemInfo.supportsGyroscope)
            {
                gyroscope = Input.gyro;
                gyroscope.enabled = true;
                gyroIsActive = gyroscope.enabled;
                initialRotationX= gyroscope.attitude.eulerAngles.x;

            }
        }


        private void Update()
        {
            if (gyroIsActive)
            {
                Vector3 rotation = gyroscope.attitude.eulerAngles;
                ///Rotate the player according to the rotation of the gyroscope 
                player.rotation = Quaternion.Euler(transform.eulerAngles.x, rotation.x - initialRotationX, transform.eulerAngles.z);
            }
        }

    }
}
