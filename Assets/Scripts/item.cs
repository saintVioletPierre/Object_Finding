using UnityEngine;
using UnityEngine.InputSystem;

public class item : MonoBehaviour
{
    public bool goodness = false;
    bool foundness = false;

    public void find(){
        if(foundness) return;

        foundness = true;
        print("YOU FOUND ME");

        // play sound
        // maybe have object fade out slightly before it disappears

        

        Destroy(gameObject);
    }
}
