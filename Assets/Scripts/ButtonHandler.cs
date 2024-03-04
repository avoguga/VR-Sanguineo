using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

[CreateAssetMenu(fileName = "NewButtonHandler")]
public class ButtonHandler : InputHandler
{
    public InputHelpers.Button button = InputHelpers.Button.None;

    public delegate void ButtonAction(XRController controller);
    public ButtonAction OnButtonDown;
    public ButtonAction OnButtonUp;

    private bool previusPress = false;
    
    public override void HandleState(XRController controller)
    {
        if(controller.inputDevice.IsPressed(button, out bool pressed, controller.axisToPressThreshold)) 
        {
            if(previusPress != pressed)
            {
                previusPress = pressed;

                if(pressed)
                {
                    OnButtonDown?.Invoke(controller);
                }
                else
                {
                    OnButtonUp?.Invoke(controller);
                }
            }
        }
    }
}