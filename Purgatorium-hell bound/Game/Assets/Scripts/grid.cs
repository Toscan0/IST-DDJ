using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grid : MonoBehaviour {
    private int _g1 = 0; //pos na grid
    private int _g2 = 0;
    private Vector3 _pos1;
    private Vector3 _pos2;
    private string _name1 = null;
    private string _name2 = null;

    private bool _changed = false;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GameObject chestOpen = GameObject.Find("FinalChest").gameObject;
        if (chestOpen.GetComponent<FinalChest>().Open == true) {
            if (_pos1 != null && _pos2 != null && _pos1 != _pos2 &&
            _name1 != null && _name2 != null && _name1 != _name2 &&
            _g1 != 0 && _g2 != 0 && _g1 != _g2 &&
            _changed == true)
            {
                GameObject p1 = GameObject.Find(_name1).gameObject;
                GameObject p2 = GameObject.Find(_name2).gameObject;

                Debug.Log("-----" + p1.name + " " + _g1 + "   " + p2.name + " " + _g2);

                p1.transform.position = _pos2;
                p2.transform.position = _pos1;

                p1.GetComponent<pieces>().MyPos = _g2;
                p2.GetComponent<pieces>().MyPos = _g1;     

                _name1 = null;
                _name2 = null;
                _changed = false;
            }
        }
            
    }

    public Vector3 Pos1
    {
        get
        {
            return _pos1;
        }

        set
        {
            _pos1 = value;
        }
    }

    public Vector3 Pos2
    {
        get
        {
            return _pos2;
        }

        set
        {
            _pos2 = value;
        }
    }

    public string Name1
    {
        get
        {
            return _name1;
        }

        set
        {
            _name1 = value;
        }
    }

    public string Name2
    {
        get
        {
            return _name2;
        }

        set
        {
            _name2 = value;
        }
    }

    public int PosG1
    {
        get
        {
            return _g1;
        }

        set
        {
            _g1 = value;
        }
    }

    public int PosG2
    {
        get
        {
            return _g2;
        }

        set
        {
            _g2 = value;
        }
    }

    public bool Changed
    {
        get
        {
            return _changed;
        }

        set
        {
            _changed = value;
        }
    }
}
