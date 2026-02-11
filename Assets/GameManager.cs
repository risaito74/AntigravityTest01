using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    public Transform cubeTransform;
    public float rotationSpeed = 100f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void Update()
    {
        if (Mouse.current != null && cubeTransform != null)
        {
            if (Mouse.current.leftButton.isPressed)
            {
                // 反時計回り（左回り）
                cubeTransform.Rotate(0, -rotationSpeed * Time.deltaTime, 0);
            }
            else if (Mouse.current.rightButton.isPressed)
            {
                // 時計回り（右回り）
                cubeTransform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
            }
        }
    }
}
