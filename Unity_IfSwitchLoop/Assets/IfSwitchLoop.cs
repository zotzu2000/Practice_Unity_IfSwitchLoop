
using UnityEngine;

public class IfSwitchLoop : MonoBehaviour
{
    [Header("血量"), Range(0, 100)]
    public int hp = 100;
    [Header("道具")]
    public string prop = "紅水";

    public int i = 1;
    private int j = 1;

    [Header("地板")]
    public GameObject cube;

    private void CreateFloor(int length, int width)
    {
        for (int j = 0; j < width; j++)
        {
            for (int i = j; i < length; i++)
            {

                Instantiate(cube, new Vector3(j * 2, 0, i * 2), Quaternion.Euler(270, 0, 0));
            }
        }
    }
    private void Awake()
    {
        CreateFloor(10, 10);
    }
    private void Update()
    {
        if (hp >= 70)
        {
            print("安全");
        }
        else if (hp >= 20)
        {
            print("警告");
        }
        else
        {
            print("危險");
        }
    }        
}
