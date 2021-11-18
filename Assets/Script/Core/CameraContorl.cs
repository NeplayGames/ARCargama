using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace AR.Core
{
    public class CameraContorl : MonoBehaviour
    {
       [SerializeField] Vector3 offset;
       [SerializeField] Transform player;
        void Start()
        {

        }

        // Update is called once per frame
        void LateUpdate()
        {
            transform.position  = player.position + offset;
        }
    }

}
