using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 1_card_move : MonoBehaviour
{
    private void Awake()
    {
        transform.position = transform.position + new Vector3(1, 0, 0) * 1;
    }
}
