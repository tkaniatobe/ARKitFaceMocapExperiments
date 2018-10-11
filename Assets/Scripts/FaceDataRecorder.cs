using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class FaceDataRecorder : MonoBehaviour {

	public JSONObject j;
	
	// Use this for initialization
	void Start () {
		j = new JSONObject(JSONObject.Type.OBJECT);
		//number
		j.AddField("field1", 0.5f);
		//string
		j.AddField("field2----------", "sampletext");
		//array
		JSONObject arr = new JSONObject(JSONObject.Type.ARRAY);
		j.AddField("field3", arr);
		
		arr.Add(1);
		arr.Add(2);
		arr.Add(3);
		
		string encodedString = j.Print();
		Debug.Log(j);
	}
	
	public void SaveJsonToTextFile() { 
		Debug.Log(Application.dataPath);
		//File.WriteAllText (Application.dataPath + "/IdList.txt", saveText);
		File.WriteAllText(Application.dataPath + "/FaceMocapData.txt", j.ToString());
		/*
#if UNITY_IOS
         File.WriteAllText (Application.persistentDataPath + "/IdList.txt", saveText); // Writes it into the file ( iOs version)
#else
        File.WriteAllText (Application.dataPath + "/IdList.txt", saveText); // Writes it into the file
#endif
*/
		Debug.Log("File Should Save.");
	}

	void OnGUI(){
        if (GUI.Button(new Rect(500, 10, 150, 100), "Save JSON to Iphone"))
        {
            SaveJsonToTextFile();
        }
    }

	// Update is called once per frame
	void Update () {
		
	}
}


