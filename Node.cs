using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node
{
    public Vector3Int position;
    public Node parent;
    public float gCost;
    public float hCost;

    public Node(Vector3Int position)
    {
        this.position = position;
    }

    public float FCost => gCost + hCost;
}
