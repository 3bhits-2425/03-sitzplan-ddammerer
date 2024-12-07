using System.Collections;
using UnityEngine;
using TMPro;


public class RoomManager : MonoBehaviour
{
    [SerializeField] private TableLayoutData tableLayout; // Reference to TableLayout script
    [SerializeField] private StudentData[] students;
    [SerializeField] private GameObject tablePrefab;  // Prefab for table
    [SerializeField] private GameObject chairPrefab; // Prefab for chairs  

    void Start()
    {
        int currentStudent = 0; 

        for (int row = 0; row < tableLayout.rows; row++)
        {
            for (int col = 0; col < tableLayout.columns; col++)
            {
                // Table position
                Vector3 tablePosition = new Vector3(col * tableLayout.tableSpacing, 0, row * tableLayout.tableSpacing);

                // Instantiate table
                GameObject table = Instantiate(tablePrefab, tablePosition, Quaternion.identity, transform);

                // Chair positions relative to table
                Transform leftPos = table.transform.Find("ChairPos1");
                Transform rightPos = table.transform.Find("ChairPos2");



                // Add students to chairs
                if (currentStudent < students.Length)                   
                {
                    StudentToChair(leftPos, students[currentStudent]);
                    currentStudent++;
                }

                if (currentStudent < students.Length)
                {
                    StudentToChair(rightPos, students[currentStudent]);
                    currentStudent++;
                }
            }
        }
    }



    private void StudentToChair(Transform chairPosition, StudentData studentData)
    {
        // Instantiate chair
        GameObject chair = Instantiate(chairPrefab, chairPosition.position, Quaternion.identity, transform);

        // Get sprite position
        Transform spritePos = chair.transform.Find("SpritePos");


        if (studentData.studentImage != null)
        {
            SpriteRenderer spriteRenderer = spritePos.GetComponent<SpriteRenderer>();           // Get sprite renderer component
            spriteRenderer.sprite = studentData.studentImage;                                   // zuweisen des Bildes
            spriteRenderer.size = new Vector2(1.0f, 1.0f);

        }


    }
}