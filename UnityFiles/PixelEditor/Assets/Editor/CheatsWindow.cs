/*
 * Copyright (c) The Knights of Unity
 * http://theknightsofunity.com/
 */

using UnityEditor;
using UnityEngine;

public class CheatsWindow : EditorWindow
{
    Color[,] colArray;

    [MenuItem("My Game/PixelEditor")]
    public static void ShowWindow()
    {
        GetWindow<CheatsWindow>(false, "PixelEditor", true);
    }

    void OnGUI()
    {

        //CreateLine();
        //CreateLine();
        //CreateLine();
        //CreateLine();
        //CreateLine();
        //CreateLine();
        //CreateLine();
        //CreateLine();
        //CreateLine();

        ColourCreator(15, 15);

        //Cheats.MuteAllSounds =
        //    EditorGUILayout.Toggle("Mute All Sounds", Cheats.MuteAllSounds);
        //Cheats.PlayerLifes =
        //    EditorGUILayout.IntField("Player Lifes", Cheats.PlayerLifes);
        //Cheats.PlayerTwoName =
        //    EditorGUILayout.TextField("Player Two Name", Cheats.PlayerTwoName);

        //GUILayout.FlexibleSpace();

        //EditorGUILayout.BeginHorizontal();
        //GUILayout.FlexibleSpace();

        //GUI.backgroundColor = Color.red;

        //if (GUILayout.Button("Reset", GUILayout.Width(100), GUILayout.Height(30)))
        //{
        //    Cheats.MuteAllSounds = false;
        //    Cheats.PlayerLifes = 4;
        //    Cheats.PlayerTwoName = "John";
        //}
        EditorGUILayout.EndHorizontal();
    }
    void CreateLine()
    {
        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.ColorField(GUIContent.none, Color.grey, false, false, false, GUILayout.MaxWidth(20f), GUILayout.MaxHeight(20f));
        EditorGUILayout.ColorField(GUIContent.none, Color.grey, false, false, false, GUILayout.MaxWidth(20f), GUILayout.MaxHeight(20f));

        EditorGUILayout.ColorField(GUIContent.none, Color.grey, false, false, false, GUILayout.MaxWidth(20f), GUILayout.MaxHeight(20f));

        EditorGUILayout.ColorField(GUIContent.none, Color.grey, false, false, false, GUILayout.MaxWidth(20f), GUILayout.MaxHeight(20f));

        EditorGUILayout.ColorField(GUIContent.none, Color.grey, false, false, false, GUILayout.MaxWidth(20f), GUILayout.MaxHeight(20f));

        EditorGUILayout.ColorField(GUIContent.none, Color.grey, false, false, false, GUILayout.MaxWidth(20f), GUILayout.MaxHeight(20f));

        EditorGUILayout.ColorField(GUIContent.none, Color.grey, false, false, false, GUILayout.MaxWidth(20f), GUILayout.MaxHeight(20f));

        EditorGUILayout.ColorField(GUIContent.none, Color.grey, false, false, false, GUILayout.MaxWidth(20f), GUILayout.MaxHeight(20f));

        EditorGUILayout.ColorField(GUIContent.none, Color.grey, false, false, false, GUILayout.MaxWidth(20f), GUILayout.MaxHeight(20f));

        EditorGUILayout.ColorField(GUIContent.none, Color.grey, false, false, false, GUILayout.MaxWidth(20f), GUILayout.MaxHeight(20f));
        EditorGUILayout.EndHorizontal();
    }

    void ColourCreator(int x, int y)
    {
        colArray = new Color[x, y];

        for (int i = 0; i < x; i++)
        {
            EditorGUILayout.BeginHorizontal();
            for (int j = 0; j < y; j++)
            {
                colArray[i, j] = Color.red;
                EditorGUILayout.ColorField(GUIContent.none, colArray[i, j], false, false, false, GUILayout.MaxWidth(20f), GUILayout.MaxHeight(20f));
            }
            EditorGUILayout.EndHorizontal();
        }
    }
}