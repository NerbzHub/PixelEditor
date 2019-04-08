/*
 * Copyright (c) The Knights of Unity
 * http://theknightsofunity.com/
 */

using UnityEditor;
using UnityEngine;

public class CheatsWindow : EditorWindow
{
    static Color[,] colArray;
    static string[,] hexColArray;

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

        if (colArray != null)
        {
            ColourUpdate(colArray.GetLength(0), colArray.GetLength(1));
        }
        else
        {
            ColourCreator(15, 15);
        }

        //Cheats.MuteAllSounds =
        //    EditorGUILayout.Toggle("Mute All Sounds", Cheats.MuteAllSounds);
        //Cheats.PlayerLifes =
        //    EditorGUILayout.IntField("Player Lifes", Cheats.PlayerLifes);
        //Cheats.PlayerTwoName =
        //    EditorGUILayout.TextField("Player Two Name", Cheats.PlayerTwoName);

        //GUILayout.FlexibleSpace();

        EditorGUILayout.BeginHorizontal();
        //GUILayout.FlexibleSpace();

        if (GUILayout.Button("Reset", GUILayout.Width(100), GUILayout.Height(30)))
        {
            //ColourCreator(15, 15);
        }


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
        hexColArray = new string[x, y];

        for (int i = 0; i < x; i++)
        {
            EditorGUILayout.BeginHorizontal();
            for (int j = 0; j < y; j++)
            {
                hexColArray[i, j] = "FFFF00";
                //GUI.Label(Rect.zero, i.ToString() )
                EditorGUILayout.ColorField(GUIContent.none, colArray[i, j], false, false, false, GUILayout.MaxWidth(20f), GUILayout.MaxHeight(20f));
            }
            EditorGUILayout.EndHorizontal();
        }
    }

    void ColourUpdate(int x, int y)
    {
        for (int i = 0; i < x; i++)
        {
            EditorGUILayout.BeginHorizontal();
            for (int j = 0; j < y; j++)
            {
                //Debug.Log(hexColArray[i, j].ToString());
                //Color color;
                //
                //if (ColorUtility.TryParseHtmlString("#" + hexColArray[i, j], out color))
                //{
                //    colArray[i, j].r = color.r;
                //    colArray[i, j].g = color.g;
                //    colArray[i, j].b = color.b;
                //}
                //    GUI.backgroundColor = colArray[i, j];
                //if (GUILayout.Button(i.ToString() + j.ToString(), GUILayout.Width(50), GUILayout.Height(50)))
                //{
                //    GUI.backgroundColor = Color.blue;
                //}
                colArray[i, j] = EditorGUILayout.ColorField(GUIContent.none, colArray[i, j], false, false, false, GUILayout.MaxWidth(20f), GUILayout.MaxHeight(20f));




            }
            EditorGUILayout.EndHorizontal();
        }
    }
}