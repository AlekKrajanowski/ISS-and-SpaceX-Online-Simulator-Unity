using System.Globalization;
using UnityEngine;
using Assets.Scripts.ISS.ISSPosition;

namespace Assets.Scripts.ISS
{
    public class RealMovement : MonoBehaviour
    {
        [SerializeField] float positionX;
        [SerializeField] float alpha;
        [SerializeField] Vector3 center;
        [SerializeField] Transform focusOn;
        float positionY;
        float positionZ;
        float radius;
        private readonly ISSActions _iSSActions;
        private readonly ISSEntity _iSSParam = ISSMotherObject.GetParameters();

        public RealMovement()
        {
            _iSSActions = new ISSActions();
        }

        void Start()
        {

        }

        void Update()
        {
            positionZ = float.Parse(_iSSActions.ISSPositionGetter(_iSSParam.Latitude), CultureInfo.InvariantCulture.NumberFormat);
            positionY = float.Parse(_iSSActions.ISSPositionGetter(_iSSParam.Longitude), CultureInfo.InvariantCulture.NumberFormat);

            transform.position = new Vector3(positionX, positionY);
            //Debug.Log(transform.position);

            center = new Vector3(focusOn.position.x + positionZ, 0, focusOn.position.z);
            radius = Vector3.Distance(focusOn.position, transform.position);

            transform.position = new Vector3(center.x + positionX * Mathf.Cos(alpha), 0, center.z + positionY * Mathf.Sin(alpha));
            positionZ = Mathf.Sqrt(Mathf.Abs(positionX * positionX - positionY * positionY));
        }
    }
}
