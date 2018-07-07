﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

    [SerializeField] List<Block> path;

	// Use this for initialization
	void Start () {
        printAllWaypoints();
	}

    private void printAllWaypoints()
    {
        foreach (Block block in path)
        {
            print(block.name);
        }
    }

    // Update is called once per frame
    void Update () {

	}
}
