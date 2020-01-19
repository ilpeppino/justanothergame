using UnityEngine;

public class Rocket : MonoBehaviour
{

    [SerializeField] private RocketSettings rocketSettings;
    private IInputManager inputManager;
    private RocketControllerDI rocketController;

    private void Awake()
    {
        var rigidbody = GetComponent<Rigidbody>();
        inputManager = new InputManager();
        rocketController = new RocketControllerDI(inputManager, rocketSettings, transform);
    }

    private void Update()
    {
        inputManager.ReadInput();
        rocketController.Move(GetComponent<Rigidbody>());
    }

}
