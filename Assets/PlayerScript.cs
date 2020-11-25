using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{
    int playerNo;

    void Start()
    {
        var playerInput = GetComponent<PlayerInput>();

        playerNo = playerInput.playerIndex;

        print($"Player {playerNo} joined the game.");

        playerInput.actions["Jump"].performed += FnJump;
    }

    void FnJump(InputAction.CallbackContext context)
    {
        print($"Player {playerNo} JUMPED");
    }
}
