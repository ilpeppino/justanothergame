using UnityEngine;

[CreateAssetMenu(menuName = "Rocket/Settings", fileName = "RocketData")]

// Defines the data model attached to the rocket

public class RocketSettings : ScriptableObject
{

    [SerializeField] [Range(0f, 1000f)] private float turnSpeed;   
    [SerializeField] [Range(0f, 1000f)] private float moveSpeed;

    public float TurnSpeed { get { return turnSpeed; } }
    public float MoveSpeed { get { return moveSpeed; } }

}
