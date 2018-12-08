using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;

public class EditorTools {

	[MenuItem("Excel's Tools/Run _F5", false, 001)]
    public static void RunGame()
    {
        GeneralTools.instance.RunGame();
    }

    [MenuItem("Excel's Tools/Pause _F6", false, 002)]
    public static void PauseGame()
    {
        GeneralTools.instance.PauseGame();
    }

    [MenuItem("Excel's Tools/Load Scene/Scene1 &1", false, 100)]
    public static void LoadScene1()
    {
        EditorSceneManager.OpenScene("Assets/Scenes/Scene1.unity");
    }

    [MenuItem("Excel's Tools/Load Scene/Scene2 &2", false, 101)]
    public static void LoadScene2()
    {
        EditorSceneManager.OpenScene("Assets/Scenes/Scene2.unity");
    }

    [MenuItem("Excel's Tools/Load Scene/Scene3 &3", false, 102)]
    public static void LoadScene3()
    {
        EditorSceneManager.OpenScene("Assets/Scenes/Scene3.unity");
    }

    [MenuItem("Excel's Tools/Load Scene/Scene4 &4", false, 103)]
    public static void LoadScene4()
    {
        EditorSceneManager.OpenScene("Assets/Scenes/Scene4.unity");
    }
    
    [MenuItem("Excel's Tools/Load Scene/Scene5 &5", false, 103)]
    public static void LoadScene5()
    {
        EditorSceneManager.OpenScene("Assets/Scenes/Scene5.unity");
    }
    
    [MenuItem("Excel's Tools/Load Scene/Title &6", false, 103)]
    public static void LoadSceneTitle()
    {
        EditorSceneManager.OpenScene("Assets/Scenes/Title.unity");
    }
}
