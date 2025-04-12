using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    void Update()
    {
        GetComponent<MeshFilter>().mesh.RecalculateBounds();
    }
}
