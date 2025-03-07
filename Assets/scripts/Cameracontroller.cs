using Unity.Mathematics;
using UnityEngine;

public class Cameracontroller : MonoBehaviour
{
    [SerializeField] Transform m_Camera;

    public float mousex;
    public float mousey;
    public float sensibility;
    public float Yrotation;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        Movercamera();
    }

    public void Movercamera()
    {
        mousex = Input.GetAxis("Mouse X") * sensibility * Time.deltaTime;
        mousey = Input.GetAxis("Mouse Y") * sensibility * Time.deltaTime;

        m_Camera.Rotate(mousex * m_Camera.transform.up);
        Yrotation -= mousey;
        Yrotation = Mathf.Clamp(Yrotation, -75, 90);
        transform.localRotation = Quaternion.Euler(Yrotation, 0, 0);
    }
}
