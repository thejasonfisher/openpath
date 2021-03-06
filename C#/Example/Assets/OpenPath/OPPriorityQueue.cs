﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class OPPriorityQueue : IComparer {

    List<OPNode> nodes = new List<OPNode>();

    public List<OPNode> GetAllNodes()
    {
        return nodes;
    }

    public int GetLength()
    {
        return nodes.Count;
    }

    public int Compare(object nodeA, object nodeB)
    {
        OPNode nA = (OPNode)nodeA;
        OPNode nB = (OPNode)nodeB;
        if (nA.estimatedTotalCost < nB.estimatedTotalCost) { return -1; }
        else if (nA.estimatedTotalCost > nB.estimatedTotalCost) { return 1; }
        else { return 0; }
    }

    public int Push(OPNode node)
    {
        nodes.Add(node);
        nodes.Sort();
        return nodes.Count;
    }

    public OPNode Front()
    {
        if (nodes.Count > 0) { return (OPNode)nodes[0]; }
        else { return null; }
    }

    public OPNode Pop()
    {
        if (nodes.Count == 0) { return null; }

        OPNode mn = (OPNode)nodes[0];
        nodes.RemoveAt(0);
        return mn;
    }

    public bool Contains(OPNode node)
    {
        return nodes.Contains(node);
    }

    public void Remove(OPNode node)
    {
        nodes.Remove(node);
        nodes.Sort();
    }
}
