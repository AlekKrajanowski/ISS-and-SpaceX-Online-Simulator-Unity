using UnityEngine;

namespace Assets.Scripts.CameraScripts
{
    public class CreateCamera : MonoBehaviour
    {
        private const float Y_ANGLE_MIN = 0.0f;
        private const float Y_ANGLE_MAX = 50.0f;

        public Transform lookAt;
        public Transform camTransform;

        private Camera cam;

        private float distance = 50.0f;
        private float currentX = 0.0f;
        private float currentY = 0.0f;
        private float sensivityX = 4.0f;
        private float sensivityY = 1.0f;

        private void Start()
        {
            camTransform = transform;
            cam = Camera.main;
        }

        private void Update()
        {
            currentY += Input.GetAxis("Mouse Y");
            currentX += Input.GetAxis("Mouse X");

            //currentX = Mathf.Clamp(currentY, Y_ANGLE_MIN, Y_ANGLE_MAX);
        }

        private void LateUpdate()
        {
            Vector3 dir = new Vector3(0, 0, -distance);
            Quaternion rotation = Quaternion.Euler(currentX, currentY, 0);
            camTransform.position = lookAt.position + rotation * dir;
            camTransform.LookAt(lookAt.position);
        }
    }
}
