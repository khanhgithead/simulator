﻿/**
 * Copyright (c) 2018 LG Electronics, Inc.
 *
 * This software contains code licensed as described in LICENSE.
 *
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PedestrianManager : MonoBehaviour
{
    #region Singleton
    private static PedestrianManager _instance = null;
    public static PedestrianManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = GameObject.FindObjectOfType<PedestrianManager>();
                if (_instance == null)
                    Debug.LogError("<color=red>PedestrianManager Not Found!</color>");
            }
            return _instance;
        }
    }
    #endregion

    #region vars
    public bool isOptimizing = true;
    public int perPedSpawnerCount = 3;
    public GameObject pedPrefab;
    public List<GameObject> pedestrians; //source prefabs

    private List<PedestrianSpawnerComponent> pedSpawners = new List<PedestrianSpawnerComponent>();
    
    private List<GameObject> npcGOs = new List<GameObject>();
    private float distToUser;
    private float pedRendDistanceThreshold = 150.0f;
    private int performanceUpdateRate = 60;
    private int frameCount = 0;
    #endregion

    #region mono
    private void Start()
    {
        GetPedSpawners();
    }

    private void Update()
    {
        frameCount++;
        if (isOptimizing && frameCount >= performanceUpdateRate)
        {
            frameCount = 0;
            OptimizePedestrians();
        }
    }

    private void OnApplicationQuit()
    {
        _instance = null;
        DestroyImmediate(gameObject);
    }
    #endregion

    #region methods
    private void GetPedSpawners()
    {
        pedSpawners.Clear();
        pedSpawners = new List<PedestrianSpawnerComponent>(FindObjectsOfType<PedestrianSpawnerComponent>());
    }
    #endregion

    #region npcPed
    public void SpawnNPCPedestrians()
    {
        KillNPCPedestrians();
        StartCoroutine(SpawnNPCPeds());
    }

    private IEnumerator SpawnNPCPeds()
    {
        npcGOs.Clear();
        for (int i = 0; i < pedSpawners.Count; i++)
        {
            for (int j = 0; j < perPedSpawnerCount; j++)
            {
                GameObject ped = Instantiate(pedPrefab, Vector3.zero, Quaternion.identity, pedSpawners[i].transform);
                npcGOs.Add(ped);
                Instantiate(pedestrians[(int)Random.Range(0, pedestrians.Count)], ped.transform);
                PedestrianComponent pedC = ped.GetComponent<PedestrianComponent>();
                if (pedC != null)
                    pedC.InitPed(pedSpawners[i].targets);
                yield return new WaitForEndOfFrame();
            }
            yield return new WaitForEndOfFrame();
        }
    }

    public void KillNPCPedestrians()
    {
        npcGOs.ForEach(p => { if (p != null) Destroy(p); });
        npcGOs.Clear();
        StopAllCoroutines(); //clean all 
    }
    #endregion

    #region optimize
    private void OptimizePedestrians()
    {
        for (int i = 0; i < npcGOs.Count; i++)
        {
            distToUser = TrafPerformanceManager.Instance.DistanceToNearestPlayerCamera(npcGOs[i].transform.position);
            npcGOs[i].SetActive(distToUser < pedRendDistanceThreshold);
        }
    }
    #endregion
}
