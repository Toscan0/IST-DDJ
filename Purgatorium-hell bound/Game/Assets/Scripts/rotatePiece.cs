using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatePiece : MonoBehaviour
{
    public bool isBarra;
    public int _pos;
    private int _position = 1; //1,2,3,4
                               //pos1 = 0
                               //pos2 = 90
                               //pos3 = 180
                               //pos4 = 270
                               //pos5 = 360 = 0 = pos1

    /*GameObject piece = this.gameObject;
        piece.transform.localEulerAngles = new Vector3(
            piece.transform.localEulerAngles.x,
            piece.transform.localEulerAngles.y + 90.0f,
            piece.transform.localEulerAngles.z);*/

    public void OnInteraction(Vector3 point)
    {
        GameObject piece = this.gameObject;
        piece.GetComponentInChildren<Transform>().Rotate(0, 0, 90);

        _position++;
        if (_position == 5)
        {
            _position = 1;
        }

        if(isBarra == true)
        {
            if(_position == 3)
            {
                _position = 1;
            }
            if (_position == 4)
            {
                _position = 2;
            }
        }
    }

    public int Position
    {
        get
        {
            return _position;
        }

        set
        {
            _position = value;
        }
    }
}