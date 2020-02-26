using UnityEngine;

public class ISSMovement : MonoBehaviour
{
    [SerializeField] float positionX;
    [SerializeField] float positionY;
    [SerializeField] float positionZ;
    [SerializeField] float alpha;
    [SerializeField] float deltaAlpha;
    [SerializeField] Vector3 center;
    [SerializeField] Transform focusOn;
    [SerializeField] float Gravity;
    [SerializeField] float Mass;
    float radius;

    void Start()
    {

    }

    void Update()
    {
        center = new Vector3(focusOn.position.x + positionZ, 0, focusOn.position.z);
        radius = Vector3.Distance(focusOn.position, transform.position);

        transform.position = new Vector3(center.x + positionX * Mathf.Cos(alpha), 0, center.z + positionY * Mathf.Sin(alpha));
        positionZ = Mathf.Sqrt(Mathf.Abs(positionX * positionX - positionY * positionY));

        deltaAlpha = (Mathf.Sqrt(Mathf.Abs(2 * Gravity * Mass * (1 / radius - 1 / (2 * positionX))) * 100 * Time.deltaTime) / Mathf.PI * Mathf.Sqrt(Mathf.Abs((positionX * positionX + positionY * positionY) / 2)));

        alpha += deltaAlpha;
    }
}
