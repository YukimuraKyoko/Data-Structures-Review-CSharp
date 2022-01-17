using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

class HashTables
{
    /*
    static Hashtable table;
    static List<UserInfo> userInfoList;
    static Stopwatch sw;

    struct UserInfo
    {
        public int userId;
        public string userName;
        //Constructor
        public UserInfo(int id, string name)
        {
            userId = id;
            userName = name;
        }
    }
    
    static void Main(string[] args)
    {
        table = new Hashtable();
        userInfoList = new List<UserInfo>();
        sw = new Stopwatch();
        //Adding
        for(int i = 0; i < 4000000; i++)
        {
            table.Add(i, "user" + i);
            userInfoList.Add(new UserInfo(i, "user" + i));
        }

        
        //Removing
        if (table.ContainsKey(0))
        {
            table.Remove(0);
        }
        

        //Setting
        if (table.ContainsKey(1))
        {
            //table[key] = "value"
            table[1] = "replacementName";
        }

        
        //Looping
        foreach(DictionaryEntry entry in table)
        {
            Console.WriteLine("Key: " + entry.Key + " / Value: " + entry.Value);
        }
        

        //Access
        Random randomUserGen = new Random();
        int randomUser = 1;

        sw.Start();
        float startTime = 0;
        float endTime = 0;
        float deltaTime = 0;

        int cycles = 5;
        int cycle = 0;
        string userName = string.Empty;

        while (cycle < cycles)
        {
            randomUser = randomUserGen.Next(3000000, 4000000);

            startTime = sw.ElapsedMilliseconds;
            //access from list
            userName = GetUserFromList(randomUser);
            endTime = sw.ElapsedMilliseconds;
            deltaTime = endTime - startTime;
            Console.WriteLine("Time taken to retrieve " + userName + " from list took " + string.Format("{0:0.##}", deltaTime) + "ms");
            startTime = sw.ElapsedMilliseconds;

            //access from hashtable
            userName = (string)table[randomUser];
            endTime = sw.ElapsedMilliseconds;
            deltaTime = endTime - startTime;
            Console.WriteLine("Time taken to retrieve " + userName + " from hashtable took " + string.Format("{0:0.##}", deltaTime) + "ms");
            cycle++;
        }
    
    }
    
    static string GetUserFromList(int userId)
    {
        for(int i = 0; i < userInfoList.Count; i++)
        {
            if (userInfoList[i].userId == userId)
            {
                return userInfoList[i].userName;
            }
        }
        return string.Empty;
    }
    */
}
