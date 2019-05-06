using System;
using System.Collections.Generic;
// <copyright file="Person.cs">
// Copyright (c) 2018 All Rights Reserved
// </copyright>
// <author>Sorokin Dmitrii</author>
// <date>08/30/2018 12:10:53 AM </date>
// <summary>Person class</summary>
namespace Life
{
    public class Person
    {
        static int max_age = 70;

        private string name;
        private bool gender;
        private int age;
        private int money;
        private bool alive;
        private List<Int32> meetings = new List<Int32>();
        private List<Meeting> advMeetings = new List<Meeting>();

        public string getName()
        {
            return this.name;
        }
        public int getAge()
        {
            return this.age;
        }
        public int getMoney()
        {
            return this.money;
        }
        public bool getAlive()
        {
            return this.alive;
        }
        public void Kill()
        {
            this.alive = false;
        }
        public void Tick()
        {
            Random random = new Random(SecureRandom.Next());
            for (int i = 0; i < random.Next(0, this.advMeetings.Count); i++)
            {
                this.advMeetings[i].addRelation(random.Next(-20, 20));
                string t = LifeNameSpace.Properties.Resources.Conjunction;
                if (this.advMeetings[i].getRelation() >= 50)
                {
                    string x = LifeNameSpace.Properties.Resources.Friends;
                    new Event(4, this.name + " " + t + " " + this.advMeetings[i].getPartner().name + " " + x).print();
                }
                if (this.advMeetings[i].getRelation() >= 100)
                {
                    string x = LifeNameSpace.Properties.Resources.BestFriends;
                    new Event(4, this.name + " " + t + " " + this.advMeetings[i].getPartner().name + " " + x).print();
                }
                if (this.advMeetings[i].getRelation() <= -50)
                {
                    string x = LifeNameSpace.Properties.Resources.Disobedient;
                    new Event(4, this.name + " " + t + " " + this.advMeetings[i].getPartner().name + " " + x).print();
                }
                if (this.advMeetings[i].getRelation() <= -100)
                {
                    string x = LifeNameSpace.Properties.Resources.Enemies;
                    new Event(4, this.name + " " + t + " " + this.advMeetings[i].getPartner().name + " " + x).print();
                }
            }
        }
        public bool isAlive()
        {
            this.age++;
            if (this.age > max_age)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool isMeet(int index)
        {
            if (this.meetings.Contains(index))
            {
                return true;
            }
            else { return false; }
        }
        public void AddMeeting(int index, Person partner)
        {
            this.meetings.Add(index);
            this.advMeetings.Add(new Meeting(index, partner));
        }
        public void debugInfo()
        {
            Console.WriteLine(this.name);
            string q = LifeNameSpace.Properties.Resources.Gender;
            Console.WriteLine(q + ": " + this.gender);
            q = LifeNameSpace.Properties.Resources.Age;
            Console.WriteLine(q + ": " + this.age);
            q = LifeNameSpace.Properties.Resources.Money;
            Console.WriteLine(q + ": " + this.money);
            q = LifeNameSpace.Properties.Resources.Alive;
            Console.WriteLine(q + ": " + this.alive);
        }
        public Person() { }
        public Person(string name, int age, int money, bool alive = true)
        {
            this.name = name;
            this.age = age;
            this.money = money;
            this.alive = alive;
            Random random = new Random(SecureRandom.Next());
            if (random.Next(1, 2) == 1)
            {
                this.gender = true;
            }
            else
            {
                this.gender = false;
            }
        }
    }
}
