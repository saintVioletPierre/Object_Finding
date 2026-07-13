using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputHandler: MonoBehaviour
{
    private Camera _mainCamera;

    private void Awake(){
        _mainCamera = Camera.main;
    }

    public void OnClick(InputAction.CallbackContext context){
        if (!context.started) return;

        var ray = Physics2D.GetRayIntersection(_mainCamera.ScreenPointToRay(Mouse.current.position.ReadValue()));
        if(!ray.collider) return;

        if(ray.collider.tag == "item"){
            ray.collider.transform.gameObject.GetComponent<item>().find();
        }
    }
}
