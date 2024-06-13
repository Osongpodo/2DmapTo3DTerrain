using UnityEngine;
using UnityEditor;

public class SaveMesh : MonoBehaviour
{
    public GameObject obj;

    public void save()
    {
        // MeshFilter 컴포넌트를 가져옵니다.
        MeshFilter meshFilter = obj.GetComponent<MeshFilter>();

        if (meshFilter == null)
        {
            Debug.LogError("선택한 오브젝트에 MeshFilter가 없습니다.");
            return;
        }

        // Mesh를 가져옵니다.
        Mesh mesh = meshFilter.sharedMesh;

        if (mesh == null)
        {
            Debug.LogError("MeshFilter에 메쉬가 없습니다.");
            return;
        }

        // 저장할 경로를 설정합니다.
        string path = EditorUtility.SaveFilePanelInProject("Save Mesh", mesh.name, "asset", "Save your mesh");

        if (string.IsNullOrEmpty(path))
        {
            Debug.LogWarning("파일 저장이 취소되었습니다.");
            return;
        }

        // Mesh를 새로운 Asset으로 저장합니다.
        AssetDatabase.CreateAsset(mesh, path);
        AssetDatabase.SaveAssets();

        Debug.Log("메쉬가 저장되었습니다: " + path);
    }
}
