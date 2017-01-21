using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Code))]
public class CodeEditor : Editor
{
    enum Tool
    {
        AddCodeButton, AddToggle
    };
    Tool tool = Tool.AddCodeButton;

    public override void OnInspectorGUI()
    {
        serializedObject.Update();

        if (GUILayout.Toggle((tool == Tool.AddCodeButton) ? true : false, "Add CodeButton", "Button"))
            tool = Tool.AddCodeButton;
        if (GUILayout.Toggle((tool == Tool.AddToggle) ? true : false, "Add Toggle", "Button"))
            tool = Tool.AddToggle;
        serializedObject.ApplyModifiedProperties();
    }

    public void OnSceneGUI()
    {
        int ControlID = GUIUtility.GetControlID(FocusType.Passive);
        HandleUtility.AddDefaultControl(ControlID);

        Code code = target as Code;
        Handles.color = new Color(255, 0, 0);
        for (int i = 0; i < code.buttons.Count; i++)
            Handles.DrawLine(code.transform.position, code.buttons[i].transform.position);
        Handles.color = new Color(0, 255, 0);
        for (int i = 0; i < code.togglers.Count; i++)
            Handles.DrawLine(code.transform.position, code.togglers[i].transform.position);

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