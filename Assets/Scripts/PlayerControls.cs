// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""ActionMap1"",
            ""id"": ""a7975258-a96c-4860-ac07-aa37d5bc1c62"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""649426a7-064f-4a7c-bb23-5b06e2c6ea25"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""ef1e2fff-7588-4b4e-8381-05207baff9c1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""63585b65-8581-4ba5-9d7b-a3c64c89f35c"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""83a46552-d2f1-4847-bbfc-62e7c360546f"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""f585c339-3996-4cb3-9ceb-7955996c75e0"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""411471f3-51b3-49d9-a8d2-786c0abe1f26"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""efdbddff-a0ff-431b-b6a3-988d4d89e8e9"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""2b8ba7a6-20c9-4e18-9164-7907eed7af79"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // ActionMap1
        m_ActionMap1 = asset.FindActionMap("ActionMap1", throwIfNotFound: true);
        m_ActionMap1_Move = m_ActionMap1.FindAction("Move", throwIfNotFound: true);
        m_ActionMap1_Jump = m_ActionMap1.FindAction("Jump", throwIfNotFound: true);
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

    // ActionMap1
    private readonly InputActionMap m_ActionMap1;
    private IActionMap1Actions m_ActionMap1ActionsCallbackInterface;
    private readonly InputAction m_ActionMap1_Move;
    private readonly InputAction m_ActionMap1_Jump;
    public struct ActionMap1Actions
    {
        private @PlayerControls m_Wrapper;
        public ActionMap1Actions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_ActionMap1_Move;
        public InputAction @Jump => m_Wrapper.m_ActionMap1_Jump;
        public InputActionMap Get() { return m_Wrapper.m_ActionMap1; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ActionMap1Actions set) { return set.Get(); }
        public void SetCallbacks(IActionMap1Actions instance)
        {
            if (m_Wrapper.m_ActionMap1ActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_ActionMap1ActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_ActionMap1ActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_ActionMap1ActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m_ActionMap1ActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_ActionMap1ActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_ActionMap1ActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_ActionMap1ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public ActionMap1Actions @ActionMap1 => new ActionMap1Actions(this);
    public interface IActionMap1Actions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
}
