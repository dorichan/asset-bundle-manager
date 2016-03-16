using UnityEngine;
using UnityEditor;
using System.Collections;

namespace AssetBundles 
{
	public class ABMenuItems : MonoBehaviour 
	{
		[MenuItem("Assets/AssetBundles/Build Asset Bundles")]
		public static void BuildAssetBundles()
		{
			AssetBundleManager.BuildAssetBundles();
		}

		[MenuItem ("Assets/TestSelected")]
		public static void TestSelection()
		{
			AssetImporter.GetAtPath (AssetDatabase.GetAssetPath (Selection.activeInstanceID)).assetBundleName = "testBundle";
		}
	}
}
