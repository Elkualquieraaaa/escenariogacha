using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float Hmovement;
    public float Vmovement;
    public float Velocity;
    CharacterController controller;
    public float gravity = -9.8f;
    Transform player;
    Vector3 speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        controller = GetComponent<CharacterController>();
        player = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Hmovement = Input.GetAxis("Horizontal");
        Vmovement = Input.GetAxis("Vertical");

        Vector3 move = transform.right * Hmovement + transform.forward * Vmovement;
        speed.y += gravity * Time.deltaTime;

        controller.Move(move*Velocity*Time.deltaTime);
        controller.Move(speed);

    }

    public void Playermovement()
    {
        transform.Translate(new Vector3(Hmovement, 0, Vmovement));
    }
}
