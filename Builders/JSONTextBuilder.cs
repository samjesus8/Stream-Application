using System;
using System.IO;
using Newtonsoft.Json; //Make sure to install NEWTONSOFT.JSON using the Package Manager

namespace StreamLab.Builders
{
    internal class JSONTextBuilder
    {
        public string MemberProperty1 { get; set; } //Initialising the Properties that the JSON file uses
        public string MemberProperty2 { get; set; } //This MUST be the same as what you are using in the JSON file
        public string MemberProperty3 { get; set; } //Each member of a category MUST have the name property names

        public JSONTextBuilder() 
        {
            using (StreamReader sr = new StreamReader("JSONData.json")) //Open a Streamreader to your JSON file
            {
                var jsonData = sr.ReadToEnd(); //Read the whole JSON File to the last line

                JSONObject obj = JsonConvert.DeserializeObject<JSONObject>(jsonData);
                //This is the line that filters out all your members and its associated properties so that we can use it in code
                //It uses Deserialize and it uses the JSONObject template that we created

                var random = new Random(); //We can use random to get a member at random
                var data = obj.members[random.Next(0, obj.members.Length)]; //Draws a member in the JSON file between entry 0 and the amount of members in the JSON file

                //Now we can set the properties for use in the class

                this.MemberProperty1 = data.memberProperty1;
                this.MemberProperty2 = data.memberProperty2;
                this.MemberProperty3 = data.memberProperty3;

                //In your main code when you call this constructor you can now read this JSON file
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
        public string memberProperty1 { get; set; } //Each property MUST have the same name as it is in the JSON file or else it will not read
        public string memberProperty2 { get; set; }
        public string memberProperty3 { get; set; }
    }
}
