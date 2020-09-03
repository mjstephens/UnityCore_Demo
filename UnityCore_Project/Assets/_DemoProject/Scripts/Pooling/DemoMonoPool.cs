using SharpCore.Utility.Pooling;
using UnityCore.Instantiation;
using UnityEngine;

public class DemoMonoPool : MonoBehaviour
{
    [Header("References")]
    public Transform pooledInstanceSpawnTrans;
    public GameObject pooledInstancePrefab;

    [Header("Pool Options")] 
    public int poolCapacityMin;
    public int poolCapacityMax;

    private IPool _pool;

    #region Initialization

    private void Awake()
    {
        Instantiator.SetObjectPoolCapacity(pooledInstancePrefab, poolCapacityMin, poolCapacityMax);
    }

    #endregion Initialization
    
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnPooledInstance();
        }
    }

    private void SpawnPooledInstance()
    {
        Instantiator.Pooled(pooledInstancePrefab, pooledInstanceSpawnTrans.position, Quaternion.identity);
    }
}
