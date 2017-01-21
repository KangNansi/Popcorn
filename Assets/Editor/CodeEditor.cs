using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Code))]
public class CodeEditor : Editor
{
    enum Tool
    {
        AddCodeButton, AddToggle, AddPictos
    };
    Tool tool = Tool.AddCodeButton;

    public override void OnInspectorGUI()
    {
        serializedObject.Update();

        EditorGUILayout.PropertyField(serializedObject.FindProperty("buttons"), true);
        EditorGUILayout.PropertyField(serializedObject.FindProperty("togglers"), true);
        EditorGUILayout.PropertyField(serializedObject.FindProperty("pictos"), true);
        serializedObject.ApplyModifiedProperties();
    }

    public void OnSceneGUI()
    {
        int ControlID = GUIUtility.GetControlID(FocusType.Passive);
        HandleUtility.AddDefaultControl(ControlID);

        Code code = target as Code;

        switch (Event.current.type)
        {
            case EventType.MouseDown:
                if (Event.current.button == 0 && !Event.current.alt)
                {
                    RaycastHit hit;
                    Ray ray = HandleUtility.GUIPointToWorldRay(Event.current.mousePosition);
                    
                    if (!Physics.Raycast(ray, out hit))
                        return;
                    switch (tool)
                    {
                        case Tool.AddCodeButton:
                            CodeButton cb = hit.collider.GetComponent<CodeButton>();
                            if(cb!=null)
                            {
                                if (!code.buttons.Contains(cb))
                                    code.buttons.Add(cb);
                                else
                                    code.buttons.Remove(cb);
                                HandleUtility.Repaint();
                            }
                            break;

                        case Tool.AddToggle:
                            State tog = hit.collider.GetComponent<State>();
                            if (tog != null)
                            {
                                if (!code.togglers.Contains(tog))
                                    code.togglers.Add(tog);
                                else
                                    code.togglers.Remove(tog);
                                HandleUtility.Repaint();
                            }
                            break;

                        case Tool.AddPictos:
                            Pictogramme pic = hit.collider.GetComponent<Pictogramme>();
                            if (pic != null)
                            {
                                if (!code.pictos.Contains(pic))
                                    code.pictos.Add(pic);
                                else
                                    code.pictos.Remove(pic);
                                HandleUtility.Repaint();
                            }
                            break;

                        default:
                            break;
                    }
                }
                break;
            default:
                break;
        }
        
        
    }
}