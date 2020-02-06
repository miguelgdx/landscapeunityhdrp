// GENERATED AUTOMATICALLY FROM 'Assets/Input.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Input"",
    ""maps"": [
        {
            ""name"": ""Play"",
            ""id"": ""cef78cfe-a7b2-4705-a648-553bdff9c7c0"",
            ""actions"": [
                {
                    ""name"": ""CameraH"",
                    ""type"": ""Value"",
                    ""id"": ""15a8b6b2-accb-4a07-97c9-52c07b4e8395"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CameraV"",
                    ""type"": ""Value"",
                    ""id"": ""1c2dacb0-ab7b-4e36-833d-e80e83a84084"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CameraZoom"",
                    ""type"": ""Value"",
                    ""id"": ""4ffc3cde-5c14-4091-be0c-870ba37045c0"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""cb574cd9-f516-4813-ade9-ad7fab6dea44"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraH"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f081d347-6445-4d55-a2c2-45b982c07ad8"",
                    ""path"": ""<Mouse>/delta/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraV"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4e9d90ee-b067-4868-8d8f-a5e1082fe9eb"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraZoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Play
        m_Play = asset.FindActionMap("Play", throwIfNotFound: true);
        m_Play_CameraH = m_Play.FindAction("CameraH", throwIfNotFound: true);
        m_Play_CameraV = m_Play.FindAction("CameraV", throwIfNotFound: true);
        m_Play_CameraZoom = m_Play.FindAction("CameraZoom", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Play
    private readonly InputActionMap m_Play;
    private IPlayActions m_PlayActionsCallbackInterface;
    private readonly InputAction m_Play_CameraH;
    private readonly InputAction m_Play_CameraV;
    private readonly InputAction m_Play_CameraZoom;
    public struct PlayActions
    {
        private @PlayerInput m_Wrapper;
        public PlayActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @CameraH => m_Wrapper.m_Play_CameraH;
        public InputAction @CameraV => m_Wrapper.m_Play_CameraV;
        public InputAction @CameraZoom => m_Wrapper.m_Play_CameraZoom;
        public InputActionMap Get() { return m_Wrapper.m_Play; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayActions set) { return set.Get(); }
        public void SetCallbacks(IPlayActions instance)
        {
            if (m_Wrapper.m_PlayActionsCallbackInterface != null)
            {
                @CameraH.started -= m_Wrapper.m_PlayActionsCallbackInterface.OnCameraH;
                @CameraH.performed -= m_Wrapper.m_PlayActionsCallbackInterface.OnCameraH;
                @CameraH.canceled -= m_Wrapper.m_PlayActionsCallbackInterface.OnCameraH;
                @CameraV.started -= m_Wrapper.m_PlayActionsCallbackInterface.OnCameraV;
                @CameraV.performed -= m_Wrapper.m_PlayActionsCallbackInterface.OnCameraV;
                @CameraV.canceled -= m_Wrapper.m_PlayActionsCallbackInterface.OnCameraV;
                @CameraZoom.started -= m_Wrapper.m_PlayActionsCallbackInterface.OnCameraZoom;
                @CameraZoom.performed -= m_Wrapper.m_PlayActionsCallbackInterface.OnCameraZoom;
                @CameraZoom.canceled -= m_Wrapper.m_PlayActionsCallbackInterface.OnCameraZoom;
            }
            m_Wrapper.m_PlayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @CameraH.started += instance.OnCameraH;
                @CameraH.performed += instance.OnCameraH;
                @CameraH.canceled += instance.OnCameraH;
                @CameraV.started += instance.OnCameraV;
                @CameraV.performed += instance.OnCameraV;
                @CameraV.canceled += instance.OnCameraV;
                @CameraZoom.started += instance.OnCameraZoom;
                @CameraZoom.performed += instance.OnCameraZoom;
                @CameraZoom.canceled += instance.OnCameraZoom;
            }
        }
    }
    public PlayActions @Play => new PlayActions(this);
    public interface IPlayActions
    {
        void OnCameraH(InputAction.CallbackContext context);
        void OnCameraV(InputAction.CallbackContext context);
        void OnCameraZoom(InputAction.CallbackContext context);
    }
}
