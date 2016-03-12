using UnityEngine;
using System.Collections;

public class PlantController : MonoBehaviour {

    public GameObject[] levels;
    public float maxGrowTime;
    public float minGrowTime;

    private int noOfLevels;
    private int currentLevel;
    private GameObject model;
    private float nextGrow;

	void Start ()
    {
        noOfLevels = levels.Length - 1;
        model = Instantiate(levels[currentLevel]);
        model.transform.parent = transform;
        model.transform.localPosition = levels[currentLevel].transform.localPosition;
        nextGrow = GlobalVariables.gameTime + Random.Range(minGrowTime, maxGrowTime);
    }

    void Update()
    {
        if (GlobalVariables.gameTime >= nextGrow && transform.childCount > 0 && currentLevel < noOfLevels)
        {
            grow();
        }
    }

    void destroyChildren()
    {
        int childs = transform.childCount;
        for (int i = childs - 1; i >= 0; i--)
        {
            GameObject.Destroy(transform.GetChild(i).gameObject);
        }
    }

    void grow()
    {
        destroyChildren();
        currentLevel++;
        model = Instantiate(levels[currentLevel]);
        model.transform.parent = transform;
        model.transform.localPosition = levels[currentLevel].transform.localPosition;
        nextGrow = GlobalVariables.gameTime + Random.Range(minGrowTime, maxGrowTime);
    }
}
