using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit; 
public class Controllers : MonoBehaviour
{
    
    public InputActionProperty primaryButton;

    void Update()
    {
        if (primaryButton == null)
        {
            Debug.LogError("XRController for the right hand is not assigned!");
            return;
        }

        bool isPressed = primaryButton.action.ReadValue<float>() > 0.5f;

        if (isPressed)
        {
            Debug.Log("Button pressed: " + primaryButton);
            // Reload the scene
            UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
        }

        
    }
}
