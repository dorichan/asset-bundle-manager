using UnityEngine;
using UnityEngine.SceneManagement;
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
	/// <summary>
	/// Manages the creation and unloading of asset bundle elements.
	/// </summary>
	public class AssetBundleManager : MonoBehaviour 
	{
		public const string AssetBundlesOutputPath = "AssetBundles";

		/// <summary>
		/// Builds the asset bundles.
		/// </summary>
		public static void BuildAssetBundles()
		{
			string outputPath = CreateAssetBundleDirectory();
			var options = BuildAssetBundleOptions.None;

			BuildPipeline.BuildAssetBundles(outputPath, options, EditorUserBuildSettings.activeBuildTarget);
		}
			
		/// <summary>
		/// Creates the asset bundle directory in the root folder of the Unity project.
		/// </summary>
		/// <returns>The asset bundle directory.</returns>
	    public static string CreateAssetBundleDirectory()
		{
			string outputPath = Path.Combine(AssetBundlesOutputPath, EditorUserBuildSettings.activeBuildTarget.ToString());
			Debug.Log (outputPath);

			if (!Directory.Exists(outputPath)) {
				Directory.CreateDirectory(outputPath);
			}

			return outputPath;
		}
	}
}
