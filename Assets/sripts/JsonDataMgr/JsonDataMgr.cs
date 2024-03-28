using LitJson;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class JsonDataMgr
{
    public enum JsonType
    {
        JsonUtility,
        LitJson,
    }
    public class JsonMgr
    {
        private static JsonMgr instance = new JsonMgr();
        public static JsonMgr Instance => instance; 
        private JsonMgr() { }
        public void SavaData(object data,string fileName,JsonType type = JsonType.LitJson)
        {
            string json = "";
            switch (type)
            {
                case JsonType.JsonUtility:
                    json = JsonUtility.ToJson(data);
                    break;
                case JsonType.LitJson:
                    json = JsonMapper.ToJson(data);
                    break;
            }
            File.WriteAllText(Application.streamingAssetsPath + "/" + fileName + ".json", json);
        }
        public T LoadData<T>(string fileName,JsonType type = JsonType.LitJson)
        {
            string json = "";
            json = File.ReadAllText(Application.streamingAssetsPath + "/" + fileName + ".json");
            switch (type)
            {
                case JsonType.JsonUtility:
                    return JsonUtility.FromJson<T>(json);
                case JsonType.LitJson:
                    return JsonMapper.ToObject<T>(json);
            }
            return default(T);
        }
    }
}
