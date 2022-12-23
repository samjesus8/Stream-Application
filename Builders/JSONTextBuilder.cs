using Newtonsoft.Json; //Make sure to install NEWTONSOFT.JSON using the Package Manager
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;

namespace StreamLab.Builders
{
    public class JSONTextBuilder
    {
        public string MemberProperty1 { get; set; } //Initialising the Properties that the JSON file uses
        public string MemberProperty2 { get; set; } //This MUST be the same as what you are using in the JSON file
        public string MemberProperty3 { get; set; } //Each member of a category MUST have the name property name

        public Dictionary<int, JSONTextBuilder> MemberProperties = new Dictionary<int, JSONTextBuilder>();

        public JSONTextBuilder() 
        {

        }

        public void Write(string member1, string member2, string member3) 
        {
            var path = System.AppDomain.CurrentDomain.BaseDirectory + "/Data/JSONData.json";
            var json = File.ReadAllText(path);

            var jsonObj = JObject.Parse(json);
            var members = jsonObj["members"].ToObject<List<JSONTextBuilder>>();

            var thingsToWrite = new JSONTextBuilder
            {
                MemberProperty1 = member1,
                MemberProperty2 = member2,
                MemberProperty3 = member3
            };

            members.Add(thingsToWrite);

            jsonObj["members"] = JArray.FromObject(members);

            File.WriteAllText(path, jsonObj.ToString());
        }

        public void Load() 
        {
            using (StreamReader sr = new StreamReader(System.AppDomain.CurrentDomain.BaseDirectory + "/Data/JSONData.json")) //Open a Streamreader to your JSON file
            {
                int count = 0;
                var jsonData = sr.ReadToEnd(); //Read the whole JSON File to the last line

                JSONObject obj = JsonConvert.DeserializeObject<JSONObject>(jsonData);
                //This is the line that filters out all your members and its associated properties so that we can use it in code
                //It uses Deserialize and it uses the JSONObject template that we created

                foreach (var item in obj.members) 
                {
                    var tempClass = new JSONTextBuilder
                    {
                        MemberProperty1 = item.MemberProperty1,
                        MemberProperty2 = item.MemberProperty2,
                        MemberProperty3 = item.MemberProperty3
                    };

                    MemberProperties.Add(count, tempClass);
                    count++;
                }
            }
        }
    }

    class JSONObject //This class represents your JSON file. This is what allows it to read your category and its members
    {
        public string categoryName { get; set; } //Gets the category name
        public Member[] members { get; set; } //Gets all members in the category. Notice we are using an array since you may have multiple members
    }

    class Member //This class allows you to access each property in a member
    {
        public string MemberProperty1 { get; set; } //Each property MUST have the same name as it is in the JSON file or else it will not read
        public string MemberProperty2 { get; set; }
        public string MemberProperty3 { get; set; }
    }
}
