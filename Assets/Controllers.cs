using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit; 
using UnityEngine.SceneManagement; 

public class Controllers : MonoBehaviour
{
    public InputActionProperty primaryButton;
    private float timer = 132f;

    void Start()
    {
        StartCoroutine(SceneLoadTimer()); // Start the countdown as soon as the script runs
    }
    
    void Update()
    {
        if (primaryButton == null)
        {
            Debug.Log(primaryButton);
            Debug.LogError("XRController for the right hand is not assigned!");
            return;
        }
        // else if (primaryButton != null)
        // {
        //     Debug.Log(primaryButton.reference.name);
        //     Debug.Log("XRController for the right hand is assigned!");
        //     Debug.Log(primaryButton.action.ReadValue<float>());
        //     return;
        // }

        bool isPressed = primaryButton.action.ReadValue<float>() > 0.5f;

        if (isPressed)
        {
            Debug.Log("Button pressed: " + primaryButton);
            // Reload the scene
            UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
        }
    }

     IEnumerator SceneLoadTimer()
    {
        yield return new WaitForSeconds(timer); // Wait for 135 seconds
        SceneManager.LoadScene("1 Start Scene"); // Load the "Start" scene
    }
}
