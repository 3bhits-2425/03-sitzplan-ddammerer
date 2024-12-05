using UnityEngine;

public class Manager : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    public GameObject parent;
    private int rows = 4;
    private int columns = 5;
    private float spacing = 110f;  

    void Start()
    {
        for (int i = 0; i < columns; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                Vector2 position = new Vector2(i * spacing, j * spacing);
                
                GameObject obj = Instantiate(prefab, position, Quaternion.identity, parent.transform);
                obj.transform.SetParent(parent.transform);
            }
        }
    }
}
