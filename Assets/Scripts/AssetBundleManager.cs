using UnityEngine;
using UnityEditor;
using UnityEditor.Callbacks;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace AssetBundles 
{
	public class LoadedAssetBundle 
	{
		public AssetBundle m_AssetBundle;
		public int m_ReferencedCount;

		internal event Action unload;

		internal void OnUnload()
		{
			m_AssetBundle.Unload(false);
			if (unload != null)
				unload();
		}

		public LoadedAssetBundle(AssetBundle assetBundle)
		{
			m_AssetBundle = assetBundle;
			m_ReferencedCount = 1;
		}
	}

	public class AssetBundleManager : MonoBehaviour 
	{
		public static void BuildAssetBundles()
		{
			Debug.Log (System.DateTime.Today + " Building asset bundles.");

			// TODO : Hard code the path for now. See if it works.
			string outputPath = Path.Combine ("AssetBundles", "OSX");
			var options = BuildAssetBundleOptions.None;
		}
	}
}
