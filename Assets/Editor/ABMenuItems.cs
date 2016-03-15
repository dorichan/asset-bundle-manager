using UnityEngine;
using UnityEditor;
using System.Collections;

namespace AssetBundles 
{
	public class ABMenuItems : MonoBehaviour 
	{
		[MenuItem("Assets/AssetBundles/Build Asset Bundles")]
		static public void BuildAssetBundles()
		{
			AssetBundleManager.BuildAssetBundles();
		}
	}
}
