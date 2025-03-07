using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float Hmovement;
    public float Vmovement;
    public float Velocity;
    CharacterController controller;
    Transform player;
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

        controller.Move(move*Velocity*Time.deltaTime);
    }

    public void Playermovement()
    {
        transform.Translate(new Vector3(Hmovement, 0, Vmovement));
    }
}
