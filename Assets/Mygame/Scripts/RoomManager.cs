using System.Collections;
using UnityEngine;

public class RoomManager : MonoBehaviour
{
    [SerializeField] private TableLayoutData tableLayout; // Reference to TableLayout script
    [SerializeField] private StudentData[] students;
    [SerializeField] private GameObject tablePrefab;  // Prefab for table
    [SerializeField] private GameObject chairPrefab; // Prefab for chairs  

    void Start()
    {
        for (int row = 0; row < tableLayout.rows; row++)
        {
            for (int col = 0; col < tableLayout.columns; col++)
            {
                // Table position
                Vector3 tablePosition = new Vector3(col * tableLayout.tableSpacing, 0, row * tableLayout.tableSpacing);

                // Instantiate table
                GameObject table = Instantiate(tablePrefab, tablePosition, Quaternion.identity, transform);

                // Chair positions relative to table
                Vector3 leftChairPosition = tablePosition + new Vector3(0.5f, 0, 1);  // Adjust offset for left chair
                Vector3 rightChairPosition = tablePosition + new Vector3(-0.5f, 0, 1);  // Adjust offset for right chair

                // Instantiate chairs
                Instantiate(chairPrefab, leftChairPosition, Quaternion.identity, transform);
                Instantiate(chairPrefab, rightChairPosition, Quaternion.identity, transform); //createAssetMenu : scriptableobject
            }
        }
    }
}
