using UnityEngine;

namespace SolarSystem
{
    public class ChangeLookAtTarget : MonoBehaviour
    {
        public Transform target;
        
        private void Start()
        {
            if(target != null) return;

            target = gameObject.transform;
            Debug.Log("Target não especificado no ChageLookAtTarget, padronizando");
        }

        private void OnMouseDown()
        {
            LookAtTarget.target = target;
            
            if(Camera.main == null) return;
            var fieldOfView = 8 * target.transform.localScale.x;
            Camera.main.fieldOfView = Mathf.Clamp(fieldOfView, 10, 100);
        }
        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
