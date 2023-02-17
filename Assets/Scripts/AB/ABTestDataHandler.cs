using UnityEngine;

namespace Assets.Scripts.AB
{
    
    public class ABTestDataHandler
    {

        public int? GroupNumber(string testName)
        {
            if (IsSaved(testName))
            {
                string jsonData = PlayerPrefs.GetString(testName);
                Data data = JsonUtility.FromJson<Data>(jsonData);
                return data.groupNumber;
            }
            
            return null;
        }

        public void Save(string testName, int groupNumber)
        {
            Data data = new Data();

            data.testName = testName;
            data.groupNumber = groupNumber;

            string dataJson = JsonUtility.ToJson(data);
            PlayerPrefs.SetString(testName,dataJson);
        }
        
        private bool IsSaved(string testName)
        {
            if (PlayerPrefs.HasKey(testName))
            {
                return true;
            }

            return false;
        }
    }

    [System.Serializable]
    public class Data
    {
        public string testName;
        public int groupNumber;
    }
}