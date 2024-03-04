using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ExampleListener : MonoBehaviour
{
    public ButtonHandler primaryButtonHandler = null;
    
    public void OnEnable()
    {
        primaryButtonHandler.OnButtonDown += PrintPrimaryButtonDown;
    }

    public void OnDisable()
    {
        primaryButtonHandler.OnButtonDown -= PrintPrimaryButtonDown;
    }

    private void PrintPrimaryButtonDown(XRController controller)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);

    }

    private void PrintPrimaryButtonUp(XRController controller)
    {

    }

    private void PrintPrimaryAxis(XRController controller, Vector2 value)
    {

    }

    private void PrintTrigger(XRController controller, float value)
    {

    }
}