using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

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

        bool buttonPressed = primaryButton.action.ReadValue<float>() > 0.5f;

        if(buttonPressed == true){
            Debug.Log("Botão pressionado");
            Scene cenaAtual = SceneManager.GetActiveScene();
            SceneManager.LoadScene(cenaAtual.name);
        }
    }
}
