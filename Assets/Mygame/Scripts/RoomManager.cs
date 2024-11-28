using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomManager : MonoBehaviour
{
    [SerializeField] private TableLayoutData tablelLayout; // Ref zu Tablelayout script
    [SerializeField] private StudentData[] students;
    [SerializeField] private GameObject tablePrefab;  //Prefab für Tisch
    [SerializeField] private GameObject chairPrefab; //Prefab für Stuhl  

    void Start()
    {
        for (int row = 0; row < tablelLayout.rows; row++) {
            for(int col = 0; col < tablelLayout.columns; col++){
                GameObject table = Instantiate(tablePrefab, new Vector3(col * tablelLayout.tableSpacing, 0, row * tablelLayout.tableSpacing), Quaternion.identity, transform); // transform macht dass alles am manager clebt

                //Transform[] 
            
            }
                
            }

        }

    

    void Update()
    {
        
    }
}
