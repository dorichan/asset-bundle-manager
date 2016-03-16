using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using System.IO;
using System.Collections;

public class LoadAssetBundle : MonoBehaviour 
{
	public void OnClickLoadAssetBundle()
	{
		StartCoroutine (LoadAssetBundles());
	}

	/// <summary>
	/// Loads the asset bundles from a specified path.
	/// </summary>
	private static IEnumerator LoadAssetBundles()
	{
		string path = EditorUtility.OpenFilePanel ("Select Bundle", "", "");
		WWW www = new WWW ("file:///" + path);
		yield return www;

		string[] t = www.assetBundle.GetAllScenePaths ();
		foreach (var item in t) {
			Debug.Log (item);
		}

		SceneManager.LoadScene (Path.GetFileNameWithoutExtension (t [0]));
	}
}
