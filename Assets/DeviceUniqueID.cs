using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;

public class DeviceUniqueID : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string id = SystemInfo.deviceUniqueIdentifier;
        string path = Path.Combine(Application.persistentDataPath, "deviceId.txt");
        GetComponent<TextMeshPro>().text =$"Your device unique Id can be found at {path}.\n({id})";
        File.WriteAllText(path, id);
    }
}
