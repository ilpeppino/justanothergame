using UnityEngine;

public class RocketControllerDI 
{

    private readonly RocketSettings rocketSettings;
    private readonly Transform transform;
    private readonly IInputManager inputManager;


    public RocketControllerDI (IInputManager inputManager, RocketSettings rocketSettings, Transform transform)
    {
        this.rocketSettings = rocketSettings;
        this.transform = transform;
        this.inputManager = inputManager;
    }

    public void Move(Rigidbody rb)
    {
        
        transform.Rotate(-1 * Vector3.forward * Time.deltaTime * rocketSettings.TurnSpeed * inputManager.Rotation);
        // transform.position += transform.position * Time.deltaTime * rocketSettings.MoveSpeed * inputManager.Thrust;
        rb.AddForce(Vector3.up * rocketSettings.MoveSpeed * Time.deltaTime * inputManager.Thrust);
    }
}    
