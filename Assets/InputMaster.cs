// GENERATED AUTOMATICALLY FROM 'Assets/InputMaster.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputMaster : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputMaster()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMaster"",
    ""maps"": [
        {
            ""name"": ""Player_1"",
            ""id"": ""2a4cd95a-7731-4485-b734-72962230bb44"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""8aa78ad1-9d9f-40b7-b246-362f24eb96c5"",
                    ""expectedControlType"": """",
                    ""processors"": ""StickDeadzone"",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""1360ac7a-1d56-4ccb-b88d-beafb2299217"",
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
                    ""id"": ""87b544f6-7cd3-4a25-bea2-33acbdefd38c"",
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
                    ""id"": ""f04c7e48-1128-4628-8167-e79012713911"",
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
                    ""id"": ""65dd1a98-21e8-46a6-af95-63fc69f87331"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a1b350d0-9729-4963-bfcb-424aae169f70"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Player_2"",
            ""id"": ""a468654e-4d23-4a80-8223-11e60d98b05f"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""4a3d1cfa-abcd-4c64-a28e-8e2f160b9444"",
                    ""expectedControlType"": """",
                    ""processors"": ""StickDeadzone"",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""87f30734-dea4-4d0c-9054-a208ed975afe"",
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
                    ""id"": ""3a89e32e-8d23-4104-8951-9c2a8a6d7f08"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""94c18365-a12b-45c4-9ef4-ee988310759a"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""c3be551e-8372-470e-a131-868c6814d51b"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ac5620b6-dadd-4fff-90e5-0b884d4e0085"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player_1
        m_Player_1 = asset.FindActionMap("Player_1", throwIfNotFound: true);
        m_Player_1_Move = m_Player_1.FindAction("Move", throwIfNotFound: true);
        // Player_2
        m_Player_2 = asset.FindActionMap("Player_2", throwIfNotFound: true);
        m_Player_2_Move = m_Player_2.FindAction("Move", throwIfNotFound: true);
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

    // Player_1
    private readonly InputActionMap m_Player_1;
    private IPlayer_1Actions m_Player_1ActionsCallbackInterface;
    private readonly InputAction m_Player_1_Move;
    public struct Player_1Actions
    {
        private @InputMaster m_Wrapper;
        public Player_1Actions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player_1_Move;
        public InputActionMap Get() { return m_Wrapper.m_Player_1; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player_1Actions set) { return set.Get(); }
        public void SetCallbacks(IPlayer_1Actions instance)
        {
            if (m_Wrapper.m_Player_1ActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_Player_1ActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_Player_1ActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_Player_1ActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_Player_1ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public Player_1Actions @Player_1 => new Player_1Actions(this);

    // Player_2
    private readonly InputActionMap m_Player_2;
    private IPlayer_2Actions m_Player_2ActionsCallbackInterface;
    private readonly InputAction m_Player_2_Move;
    public struct Player_2Actions
    {
        private @InputMaster m_Wrapper;
        public Player_2Actions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player_2_Move;
        public InputActionMap Get() { return m_Wrapper.m_Player_2; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player_2Actions set) { return set.Get(); }
        public void SetCallbacks(IPlayer_2Actions instance)
        {
            if (m_Wrapper.m_Player_2ActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_Player_2ActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_Player_2ActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_Player_2ActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_Player_2ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public Player_2Actions @Player_2 => new Player_2Actions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    public interface IPlayer_1Actions
    {
        void OnMove(InputAction.CallbackContext context);
    }
    public interface IPlayer_2Actions
    {
        void OnMove(InputAction.CallbackContext context);
    }
}
