using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputManager : MonoBehaviour {
    public LayerMask _touchMask;
    public RectTransform _canvas;
    public GameObject _player;
    private Transform _playerTransform;
    public Light _flashlight;
    public Text _text;
    public GameObject _paperpopups;
    public GameObject _sidenote;
    public GameObject _escMenu;
    private int _counter = 1;
    public int _state = 0;
    private void Start()
    {
        _playerTransform = _player.transform;
    }

    private void Update()
    {
        if(_state >= 0)
        {
            Cursor.visible = false;
        }else
        {
            Cursor.visible = true;
        }
        Vector3 positionInWorlds = GetComponent<Camera>().ScreenToWorldPoint(_canvas.position);
        RaycastHit hits;
        Ray rays = new Ray(positionInWorlds, Camera.main.transform.forward);//, _player.forward, 99999f, _touchMask);
        Debug.DrawRay(positionInWorlds, _playerTransform.forward);
        if (Physics.Raycast(rays, out hits,5f,_touchMask))
        {
            if (hits.collider != null && !hits.collider.name.Contains("Wall"))
            {
                _text.text=hits.collider.name + " Press E to interact";

                if(Input.GetKeyDown("e"))
                {
                    Debug.Log("tried to interact");
                    hits.collider.gameObject.SendMessage("OnInteractionLP", _counter, SendMessageOptions.DontRequireReceiver);
                    hits.collider.gameObject.SendMessage("OnInteraction", hits.point, SendMessageOptions.DontRequireReceiver);
                    hits.collider.gameObject.SendMessage("OnPickUp", _player, SendMessageOptions.DontRequireReceiver);
                    hits.collider.gameObject.SendMessage("OnUnlock", _player.GetComponent<InventoryManager>(), SendMessageOptions.DontRequireReceiver);
                    hits.collider.gameObject.SendMessage("OnInteractionWithItem", _player.GetComponent<InventoryManager>(), SendMessageOptions.DontRequireReceiver);
                }
            }
            else
            {
                _text.text = " ";
            }
        }
        else
        {
            _text.text = " ";
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PressEscape();
        }
        if (Input.GetKeyDown("f"))
        {
            InventoryManager i = _player.GetComponent<InventoryManager>();
            if (i.InventoryHas("flashlight"))
            {
                _flashlight.enabled = !_flashlight.enabled;
                Debug.Log("flashlight: " + _flashlight.enabled);
            }
        }
        if (Input.GetKeyDown(KeyCode.Tab)&& _state >= 0)
        {
            _sidenote.SendMessage("OnTabDown", SendMessageOptions.DontRequireReceiver);
        }
        if (Input.GetKeyDown("i") && _state >= 0)
        {
            InventoryManager i = _player.GetComponent<InventoryManager>();
            i.GetInventoryPanel().SendMessage("OnInvDown", SendMessageOptions.DontRequireReceiver);
        }
        else
        {
           
        }
    }
    public void PressEscape()
    {
        if (_state == 0)
        {
            InventoryManager i = _player.GetComponent<InventoryManager>();
            _sidenote.SendMessage("OnTabOut", SendMessageOptions.DontRequireReceiver);
            i.GetInventoryPanel().SendMessage("OnInvOut", SendMessageOptions.DontRequireReceiver);
            _escMenu.active = true;
            Time.timeScale = 0f;
            _state = -1;
        }
        else if (_state == -1)
        {
            _escMenu.active = false;
            Time.timeScale = 1f;
            _state = 0;
        }else if (_state > 0)
        {
            foreach (Transform child in _paperpopups.transform)
            {
                child.gameObject.SendMessage("OnClose", SendMessageOptions.DontRequireReceiver);
            }
        }

    }
    public int Counter
    {
        get
        {
            return _counter;
        }

        set
        {
            _counter = value;
        }
    }
}
