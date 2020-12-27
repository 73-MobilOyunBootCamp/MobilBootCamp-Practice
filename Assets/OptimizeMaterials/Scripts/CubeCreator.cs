using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class CubeCreator : MonoBehaviour
{

    public static CubeCreator instance;

    bool isColorA;

    public GameObject Cube;

    public Color ColorA = Color.white;
    public Color ColorB = Color.white;

    public bool optimize;
    public MaterialPropertyBlock MaterialPropertyBlock;

    private List<MaterialChanger> materialChangers = new List<MaterialChanger>();

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        MaterialPropertyBlock = new MaterialPropertyBlock();
        for (int i = 0; i < 1000; i++)
        {
             materialChangers.Add(Instantiate(Cube, Random.insideUnitSphere * 100, Quaternion.identity).GetComponent<MaterialChanger>());
        }
    }

    private void Update()
    {

        foreach (var changer in materialChangers)
        {
            if (!optimize)
            {
                if (isColorA)
                {
                    Material mat = changer.MeshRenderer.material;
                    mat.color = ColorB;
                    changer.MeshRenderer.sharedMaterial = mat;
                }
                else
                {
                    Material mat = changer.MeshRenderer.material;
                    mat.color = ColorA;
                    changer.MeshRenderer.sharedMaterial = mat;
                }
            }
            else
            {
                if (isColorA)
                {
                    MaterialPropertyBlock.SetColor("_Color", ColorB);
                }
                else
                {
                    MaterialPropertyBlock.SetColor("_Color", ColorA);
                }
                changer.MeshRenderer.SetPropertyBlock(MaterialPropertyBlock);
            }
        }

        isColorA = !isColorA;

    }
}
