using UnityEngine;

public class Rocket : MonoBehaviour
{

    [SerializeField] private RocketSettings rocketSettings;
    private Rigidbody rb;
    private IInputManager inputManager;
    private RocketControllerDI rocketController;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        Debug.Log(rb.name);
        inputManager = new InputManager();
        rocketController = new RocketControllerDI(inputManager, rocketSettings, transform);
    }

    private void Update()
    {
        inputManager.ReadInput();
        rocketController.Move(rb);
    }

}
