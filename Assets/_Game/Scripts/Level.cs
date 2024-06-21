using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] Transform startPos, endPos;

    public void InitLevel()
    {
        this.PostEvent(EventID.OnInitLevel, startPos.position);
    }
}
