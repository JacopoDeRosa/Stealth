using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace UserInput
{
    /// <summary>
    /// Simple singleton class to easily access the player input from anywhere in the project.
    /// </summary>
    [RequireComponent(typeof(PlayerInput))]
    public class InputManager : MonoBehaviour
    {
        public static PlayerInput Input { get; private set; }
   
        [SerializeField, HideInInspector] private PlayerInput playerInput;

        private void OnValidate()
        {
            if (playerInput == null && TryGetComponent(out playerInput) == false)
            {
                Debug.LogWarning("The input manager is missing its player input component", this);
            }
            if(playerInput.actions == null)
            {
                Debug.LogWarning("The input manager is missing its player input actions", this);
            }
        }

        private void Awake()
        {
            if(Input == null)
            {
                Input = playerInput;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}
