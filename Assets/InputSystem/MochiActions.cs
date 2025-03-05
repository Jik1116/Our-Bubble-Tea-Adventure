//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.11.2
//     from Assets/InputSystem/MochiActions.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @MochiActions: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @MochiActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""MochiActions"",
    ""maps"": [
        {
            ""name"": ""TopDown"",
            ""id"": ""89533fa1-3851-40b5-ba5e-0ad8196461bd"",
            ""actions"": [
                {
                    ""name"": ""move"",
                    ""type"": ""Value"",
                    ""id"": ""eb75e12d-3068-48dd-bc53-a2909a77080b"",
                    ""expectedControlType"": ""Dpad"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""roll"",
                    ""type"": ""Button"",
                    ""id"": ""35b8e36a-6d95-405d-a823-7fe4c09ff492"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Tap"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""roll_charge"",
                    ""type"": ""Button"",
                    ""id"": ""9f278d2c-94cf-4a8f-b0a6-16727cf40186"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Hold"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""565ace65-b092-41bd-a82f-b0f285164f95"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""19adad49-86e7-49b8-878e-ce3b2b910042"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""8cd363c7-bf80-4880-af0d-021da51ab0b5"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""c3fdcda5-5095-4c60-af41-0c84ea011bfc"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""4b1695b4-34da-4479-a981-cedd9786435e"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""209bb86a-f4ae-4aa6-a931-cb5eefa4e2fd"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""67a53fe3-d98c-4aa6-ae6e-2a163c70ffd9"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""26703173-c89c-403e-ad3c-5f3e446facdc"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""9cb04a3a-0af6-4c75-9063-2161397c2726"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""62ab2e1f-126b-434f-90d3-2b43c6d37c43"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""9f88a285-dfe0-4095-b4e1-773152789fc4"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""eb83a392-2d50-4867-a520-98464ed123a4"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""roll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c2bcdd50-4121-44fb-b7c1-4d55a14ed9de"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""roll_charge"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""327ee62d-75c4-4194-9ced-659c014b4b28"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""2D_Platformer"",
            ""id"": ""bb302e11-c0a1-4cae-a8ab-add3d8fb047e"",
            ""actions"": [
                {
                    ""name"": ""move"",
                    ""type"": ""Value"",
                    ""id"": ""eed16f79-5e00-4ee1-b99c-c0a9fd3f1a82"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""jump"",
                    ""type"": ""Button"",
                    ""id"": ""cc1cc102-3d6c-4766-8c56-e127f4f8614c"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""e701f9e7-d6d3-4144-8a8e-ab3df9f63d0b"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""875cc92b-5bb8-40b6-a6bd-8b760fc2223f"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""a68d8c0e-9457-414a-9ede-11e9468a2f6f"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""04f34e52-7389-4cae-b59a-2df9f564cdba"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // TopDown
        m_TopDown = asset.FindActionMap("TopDown", throwIfNotFound: true);
        m_TopDown_move = m_TopDown.FindAction("move", throwIfNotFound: true);
        m_TopDown_roll = m_TopDown.FindAction("roll", throwIfNotFound: true);
        m_TopDown_roll_charge = m_TopDown.FindAction("roll_charge", throwIfNotFound: true);
        m_TopDown_Interact = m_TopDown.FindAction("Interact", throwIfNotFound: true);
        // 2D_Platformer
        m__2D_Platformer = asset.FindActionMap("2D_Platformer", throwIfNotFound: true);
        m__2D_Platformer_move = m__2D_Platformer.FindAction("move", throwIfNotFound: true);
        m__2D_Platformer_jump = m__2D_Platformer.FindAction("jump", throwIfNotFound: true);
    }

    ~@MochiActions()
    {
        UnityEngine.Debug.Assert(!m_TopDown.enabled, "This will cause a leak and performance issues, MochiActions.TopDown.Disable() has not been called.");
        UnityEngine.Debug.Assert(!m__2D_Platformer.enabled, "This will cause a leak and performance issues, MochiActions._2D_Platformer.Disable() has not been called.");
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

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // TopDown
    private readonly InputActionMap m_TopDown;
    private List<ITopDownActions> m_TopDownActionsCallbackInterfaces = new List<ITopDownActions>();
    private readonly InputAction m_TopDown_move;
    private readonly InputAction m_TopDown_roll;
    private readonly InputAction m_TopDown_roll_charge;
    private readonly InputAction m_TopDown_Interact;
    public struct TopDownActions
    {
        private @MochiActions m_Wrapper;
        public TopDownActions(@MochiActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @move => m_Wrapper.m_TopDown_move;
        public InputAction @roll => m_Wrapper.m_TopDown_roll;
        public InputAction @roll_charge => m_Wrapper.m_TopDown_roll_charge;
        public InputAction @Interact => m_Wrapper.m_TopDown_Interact;
        public InputActionMap Get() { return m_Wrapper.m_TopDown; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TopDownActions set) { return set.Get(); }
        public void AddCallbacks(ITopDownActions instance)
        {
            if (instance == null || m_Wrapper.m_TopDownActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_TopDownActionsCallbackInterfaces.Add(instance);
            @move.started += instance.OnMove;
            @move.performed += instance.OnMove;
            @move.canceled += instance.OnMove;
            @roll.started += instance.OnRoll;
            @roll.performed += instance.OnRoll;
            @roll.canceled += instance.OnRoll;
            @roll_charge.started += instance.OnRoll_charge;
            @roll_charge.performed += instance.OnRoll_charge;
            @roll_charge.canceled += instance.OnRoll_charge;
            @Interact.started += instance.OnInteract;
            @Interact.performed += instance.OnInteract;
            @Interact.canceled += instance.OnInteract;
        }

        private void UnregisterCallbacks(ITopDownActions instance)
        {
            @move.started -= instance.OnMove;
            @move.performed -= instance.OnMove;
            @move.canceled -= instance.OnMove;
            @roll.started -= instance.OnRoll;
            @roll.performed -= instance.OnRoll;
            @roll.canceled -= instance.OnRoll;
            @roll_charge.started -= instance.OnRoll_charge;
            @roll_charge.performed -= instance.OnRoll_charge;
            @roll_charge.canceled -= instance.OnRoll_charge;
            @Interact.started -= instance.OnInteract;
            @Interact.performed -= instance.OnInteract;
            @Interact.canceled -= instance.OnInteract;
        }

        public void RemoveCallbacks(ITopDownActions instance)
        {
            if (m_Wrapper.m_TopDownActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ITopDownActions instance)
        {
            foreach (var item in m_Wrapper.m_TopDownActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_TopDownActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public TopDownActions @TopDown => new TopDownActions(this);

    // 2D_Platformer
    private readonly InputActionMap m__2D_Platformer;
    private List<I_2D_PlatformerActions> m__2D_PlatformerActionsCallbackInterfaces = new List<I_2D_PlatformerActions>();
    private readonly InputAction m__2D_Platformer_move;
    private readonly InputAction m__2D_Platformer_jump;
    public struct _2D_PlatformerActions
    {
        private @MochiActions m_Wrapper;
        public _2D_PlatformerActions(@MochiActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @move => m_Wrapper.m__2D_Platformer_move;
        public InputAction @jump => m_Wrapper.m__2D_Platformer_jump;
        public InputActionMap Get() { return m_Wrapper.m__2D_Platformer; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(_2D_PlatformerActions set) { return set.Get(); }
        public void AddCallbacks(I_2D_PlatformerActions instance)
        {
            if (instance == null || m_Wrapper.m__2D_PlatformerActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m__2D_PlatformerActionsCallbackInterfaces.Add(instance);
            @move.started += instance.OnMove;
            @move.performed += instance.OnMove;
            @move.canceled += instance.OnMove;
            @jump.started += instance.OnJump;
            @jump.performed += instance.OnJump;
            @jump.canceled += instance.OnJump;
        }

        private void UnregisterCallbacks(I_2D_PlatformerActions instance)
        {
            @move.started -= instance.OnMove;
            @move.performed -= instance.OnMove;
            @move.canceled -= instance.OnMove;
            @jump.started -= instance.OnJump;
            @jump.performed -= instance.OnJump;
            @jump.canceled -= instance.OnJump;
        }

        public void RemoveCallbacks(I_2D_PlatformerActions instance)
        {
            if (m_Wrapper.m__2D_PlatformerActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(I_2D_PlatformerActions instance)
        {
            foreach (var item in m_Wrapper.m__2D_PlatformerActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m__2D_PlatformerActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public _2D_PlatformerActions @_2D_Platformer => new _2D_PlatformerActions(this);
    public interface ITopDownActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnRoll(InputAction.CallbackContext context);
        void OnRoll_charge(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
    }
    public interface I_2D_PlatformerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
}
