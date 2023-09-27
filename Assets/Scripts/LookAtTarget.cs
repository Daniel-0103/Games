using System;
using UnityEngine;

namespace SolarSystem
{
    public class LookAtTarget : MonoBehaviour
    {
         public static Transform target;
        
        private void Start()
        {
            if(target != null) return;
            
            target = gameObject.transform;
            Debug.Log("Target não especificado no ChageLookAtTarget, padronizando");
        
        }

        void Update()
        {

            if (target)
            {
                transform.LookAt(target);
            }
        }
    }
}
