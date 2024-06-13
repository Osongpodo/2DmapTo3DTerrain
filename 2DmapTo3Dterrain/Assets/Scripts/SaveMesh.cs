using UnityEngine;
using UnityEditor;

public class SaveMesh : MonoBehaviour
{
    public GameObject obj;

    public void save()
    {
        // MeshFilter ������Ʈ�� �����ɴϴ�.
        MeshFilter meshFilter = obj.GetComponent<MeshFilter>();

        if (meshFilter == null)
        {
            Debug.LogError("������ ������Ʈ�� MeshFilter�� �����ϴ�.");
            return;
        }

        // Mesh�� �����ɴϴ�.
        Mesh mesh = meshFilter.sharedMesh;

        if (mesh == null)
        {
            Debug.LogError("MeshFilter�� �޽��� �����ϴ�.");
            return;
        }

        // ������ ��θ� �����մϴ�.
        string path = EditorUtility.SaveFilePanelInProject("Save Mesh", mesh.name, "asset", "Save your mesh");

        if (string.IsNullOrEmpty(path))
        {
            Debug.LogWarning("���� ������ ��ҵǾ����ϴ�.");
            return;
        }

        // Mesh�� ���ο� Asset���� �����մϴ�.
        AssetDatabase.CreateAsset(mesh, path);
        AssetDatabase.SaveAssets();

        Debug.Log("�޽��� ����Ǿ����ϴ�: " + path);
    }
}
