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
            ""name"": ""InGame"",
            ""id"": ""9375c9db-e765-4908-949d-e2d195f14fed"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""b967f23f-c65f-4daf-905c-c03842db32e3"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PrimaryFire"",
                    ""type"": ""PassThrough"",
                    ""id"": ""d4382a4a-0c4f-4a93-8d71-be7f018e8bfa"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SecondaryFire"",
                    ""type"": ""PassThrough"",
                    ""id"": ""1e6afb06-ad6f-4127-b6df-7e9e01d23ba9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Boost"",
                    ""type"": ""PassThrough"",
                    ""id"": ""97bec513-18e2-4ffa-ae8c-19c345cc9304"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PauseMenu"",
                    ""type"": ""PassThrough"",
                    ""id"": ""0a492abd-413f-4b0e-855a-cfa0e6bbe9b5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""PassThrough"",
                    ""id"": ""31c6bb4d-92cd-4e79-abb2-cf2b7ba20ab5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Confirm"",
                    ""type"": ""PassThrough"",
                    ""id"": ""364f5676-e83b-45c4-835b-f918cf21cf7e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Utility"",
                    ""type"": ""PassThrough"",
                    ""id"": ""3cfeb9d9-01f2-452d-a431-cc8927b2f6df"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Turning"",
                    ""type"": ""Value"",
                    ""id"": ""5659213e-286c-452e-9393-30a43cf2d48e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""11392bf0-a546-4c5f-896c-851c2904d97f"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""D-Pad"",
                    ""id"": ""9c9b1eb2-ec20-4ac2-a3ef-1c785328c849"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""46fcc4eb-3c5c-4173-b129-cc9e26bc2251"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""6ca85d3e-ad40-4b0b-a2db-db9491022b7a"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""bc1f0942-fc21-4a3b-a2d0-051767737532"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""3c6385a9-ab4a-4af0-a135-2d9eae5b50e4"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""cb568291-1c73-44d0-9f65-c2de41a1dc49"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9acc48c5-6fad-48c6-8021-4d337af3872f"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""PrimaryFire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""14776578-e673-46a1-88f1-35c8c1e539ff"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""SecondaryFire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""43fb74f6-0557-40d4-84cb-15f8ed9c50f0"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Boost"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c3543c86-330e-4495-af72-1aa64d12ec51"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""PauseMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ce6a9c9b-c8e9-458f-8f3c-c14db73a3148"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b640bae2-6a96-4c1d-bfb0-8e1fdb8bd5c4"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""afd177dc-fc18-48b5-8106-69494cec983c"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Utility"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d66b31d4-0dba-4436-8dbf-2b475dded296"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Turning"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Menu"",
            ""id"": ""737cd7f0-ea9e-4429-be64-8184c68b4749"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""af9d8158-125b-409d-990b-35b12edfad87"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""462686ea-6530-4f85-ad7f-f9361d7c6fd6"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""GamePad"",
            ""bindingGroup"": ""GamePad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // InGame
        m_InGame = asset.FindActionMap("InGame", throwIfNotFound: true);
        m_InGame_Movement = m_InGame.FindAction("Movement", throwIfNotFound: true);
        m_InGame_PrimaryFire = m_InGame.FindAction("PrimaryFire", throwIfNotFound: true);
        m_InGame_SecondaryFire = m_InGame.FindAction("SecondaryFire", throwIfNotFound: true);
        m_InGame_Boost = m_InGame.FindAction("Boost", throwIfNotFound: true);
        m_InGame_PauseMenu = m_InGame.FindAction("PauseMenu", throwIfNotFound: true);
        m_InGame_Cancel = m_InGame.FindAction("Cancel", throwIfNotFound: true);
        m_InGame_Confirm = m_InGame.FindAction("Confirm", throwIfNotFound: true);
        m_InGame_Utility = m_InGame.FindAction("Utility", throwIfNotFound: true);
        m_InGame_Turning = m_InGame.FindAction("Turning", throwIfNotFound: true);
        // Menu
        m_Menu = asset.FindActionMap("Menu", throwIfNotFound: true);
        m_Menu_Newaction = m_Menu.FindAction("New action", throwIfNotFound: true);
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

    // InGame
    private readonly InputActionMap m_InGame;
    private IInGameActions m_InGameActionsCallbackInterface;
    private readonly InputAction m_InGame_Movement;
    private readonly InputAction m_InGame_PrimaryFire;
    private readonly InputAction m_InGame_SecondaryFire;
    private readonly InputAction m_InGame_Boost;
    private readonly InputAction m_InGame_PauseMenu;
    private readonly InputAction m_InGame_Cancel;
    private readonly InputAction m_InGame_Confirm;
    private readonly InputAction m_InGame_Utility;
    private readonly InputAction m_InGame_Turning;
    public struct InGameActions
    {
        private @PlayerControls m_Wrapper;
        public InGameActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_InGame_Movement;
        public InputAction @PrimaryFire => m_Wrapper.m_InGame_PrimaryFire;
        public InputAction @SecondaryFire => m_Wrapper.m_InGame_SecondaryFire;
        public InputAction @Boost => m_Wrapper.m_InGame_Boost;
        public InputAction @PauseMenu => m_Wrapper.m_InGame_PauseMenu;
        public InputAction @Cancel => m_Wrapper.m_InGame_Cancel;
        public InputAction @Confirm => m_Wrapper.m_InGame_Confirm;
        public InputAction @Utility => m_Wrapper.m_InGame_Utility;
        public InputAction @Turning => m_Wrapper.m_InGame_Turning;
        public InputActionMap Get() { return m_Wrapper.m_InGame; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InGameActions set) { return set.Get(); }
        public void SetCallbacks(IInGameActions instance)
        {
            if (m_Wrapper.m_InGameActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnMovement;
                @PrimaryFire.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnPrimaryFire;
                @PrimaryFire.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnPrimaryFire;
                @PrimaryFire.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnPrimaryFire;
                @SecondaryFire.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnSecondaryFire;
                @SecondaryFire.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnSecondaryFire;
                @SecondaryFire.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnSecondaryFire;
                @Boost.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnBoost;
                @Boost.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnBoost;
                @Boost.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnBoost;
                @PauseMenu.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnPauseMenu;
                @PauseMenu.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnPauseMenu;
                @PauseMenu.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnPauseMenu;
                @Cancel.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnCancel;
                @Cancel.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnCancel;
                @Cancel.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnCancel;
                @Confirm.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnConfirm;
                @Confirm.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnConfirm;
                @Confirm.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnConfirm;
                @Utility.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnUtility;
                @Utility.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnUtility;
                @Utility.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnUtility;
                @Turning.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnTurning;
                @Turning.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnTurning;
                @Turning.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnTurning;
            }
            m_Wrapper.m_InGameActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @PrimaryFire.started += instance.OnPrimaryFire;
                @PrimaryFire.performed += instance.OnPrimaryFire;
                @PrimaryFire.canceled += instance.OnPrimaryFire;
                @SecondaryFire.started += instance.OnSecondaryFire;
                @SecondaryFire.performed += instance.OnSecondaryFire;
                @SecondaryFire.canceled += instance.OnSecondaryFire;
                @Boost.started += instance.OnBoost;
                @Boost.performed += instance.OnBoost;
                @Boost.canceled += instance.OnBoost;
                @PauseMenu.started += instance.OnPauseMenu;
                @PauseMenu.performed += instance.OnPauseMenu;
                @PauseMenu.canceled += instance.OnPauseMenu;
                @Cancel.started += instance.OnCancel;
                @Cancel.performed += instance.OnCancel;
                @Cancel.canceled += instance.OnCancel;
                @Confirm.started += instance.OnConfirm;
                @Confirm.performed += instance.OnConfirm;
                @Confirm.canceled += instance.OnConfirm;
                @Utility.started += instance.OnUtility;
                @Utility.performed += instance.OnUtility;
                @Utility.canceled += instance.OnUtility;
                @Turning.started += instance.OnTurning;
                @Turning.performed += instance.OnTurning;
                @Turning.canceled += instance.OnTurning;
            }
        }
    }
    public InGameActions @InGame => new InGameActions(this);

    // Menu
    private readonly InputActionMap m_Menu;
    private IMenuActions m_MenuActionsCallbackInterface;
    private readonly InputAction m_Menu_Newaction;
    public struct MenuActions
    {
        private @PlayerControls m_Wrapper;
        public MenuActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_Menu_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_Menu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
        public void SetCallbacks(IMenuActions instance)
        {
            if (m_Wrapper.m_MenuActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_MenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public MenuActions @Menu => new MenuActions(this);
    private int m_GamePadSchemeIndex = -1;
    public InputControlScheme GamePadScheme
    {
        get
        {
            if (m_GamePadSchemeIndex == -1) m_GamePadSchemeIndex = asset.FindControlSchemeIndex("GamePad");
            return asset.controlSchemes[m_GamePadSchemeIndex];
        }
    }
    public interface IInGameActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnPrimaryFire(InputAction.CallbackContext context);
        void OnSecondaryFire(InputAction.CallbackContext context);
        void OnBoost(InputAction.CallbackContext context);
        void OnPauseMenu(InputAction.CallbackContext context);
        void OnCancel(InputAction.CallbackContext context);
        void OnConfirm(InputAction.CallbackContext context);
        void OnUtility(InputAction.CallbackContext context);
        void OnTurning(InputAction.CallbackContext context);
    }
    public interface IMenuActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
}
