using UnityEngine;
using UnityEngine.InputSystem;

public class CameraDrag : MonoBehaviour
{
    private Vector3 _origin;
    private Vector3 _difference;

    private Camera _mainCamera;

    private bool _isDragingg;

    private void Awake(){
        _mainCamera = Camera.main;
    }

    public void OnDrag(InputAction.CallbackContext ctx){
        if (ctx.started) _origin = GetMousePosition;
        _isDragingg = ctx.started || ctx.performed;
    }

    private void LateUpdate(){
        if (!_isDragingg) return;

        _difference = GetMousePosition - transform.position;
        transform.position = _origin - _difference;
    }

    private Vector3 GetMousePosition => _mainCamera.ScreenToWorldPoint(Touchscreen.current.primaryTouch.position.ReadValue());
    //private Vector3 GetMousePosition => _mainCamera.ScreenToWorldPoint(Mouse.current.position.ReadValue());
    // For mouse ^

    // set boundaries for the camera
}
