using UnityEditor;
using System.IO;

public class BuildScript
{
    public static void PerformAndroidBuild()
    {
        string buildPath = "build/Android";

        if (!Directory.Exists(buildPath))
        {
            Directory.CreateDirectory(buildPath);
        }

        BuildPlayerOptions options = new BuildPlayerOptions();
        options.scenes = new[] { "Assets/Scenes/SampleScene.unity" };
        options.locationPathName = buildPath + "/MyApp.apk";
        options.target = BuildTarget.Android;
        options.options = BuildOptions.None;

        BuildPipeline.BuildPlayer(options);
    }
}