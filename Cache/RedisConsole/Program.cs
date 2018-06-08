﻿using ServiceStack.Redis;
using System;

namespace RedisConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            People people = new People()
            {
                Age = 18,
                Id = "a",
                Name = "Test"
            };
            var client = RedisHelper.RedisClient;

            client.StoreAsHash(people);

            people = client.GetFromHash<People>(people.Id);
            Test();

            Console.ReadKey();
        }
        static void Test()
        {
            People people = new People()
            {
                Age = 18,
                Id = "a",
                Name = "Test"
            };
            var client = RedisHelper.RedisClient;
            client.StoreAsHash(people);
        }
    }
    class People
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }
    }
}
