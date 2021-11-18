using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace AR.Movement
{
    public class PlayerMovement : MonoBehaviour
    {
       

        // Update is called once per frame
        void Update()
        {
            transform.position += transform.forward * 10 * Time.deltaTime;
        }
    }
}

