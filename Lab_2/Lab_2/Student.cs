using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    class Student : Person
    {
        protected string group;
        protected List<Task> tasks;

        public string Group
        {
            get => group;
            set { group = value; }
        }

        public Student(string name, int age, string group): base(name, age)
        {
            Name = name;
            Age = age;
            Group = group;
            tasks = new List<Task>();
        }

        public Student(string name, int age, string group, List<Task> tasks) : base(name, age)
        {
            Name = name;
            Age = age;
            Group = group;
            this.tasks = tasks;
        }

        public void AddTask(string taskName, TaskStatus taskStatus)
        {
            tasks.Add(new Task(taskName, taskStatus));
        }

        public void RemoveTask(int index)
        {
            tasks.RemoveAt(index);
        }

        public void UpdateTask(int index, TaskStatus taskStatus)
        {
            tasks[index].Status = taskStatus;
        }

        public string RenderTasks(string prefix = "\t")
        {
            string display = "";
            int index = 1;
            foreach(Task task in tasks)
            {
                display += prefix + index.ToString() + ". " + task.ToString();
                index++;
            }
            return display;
        }

        public override string ToString()
        {
            return "Student's name: " + Name + "\nStudent's age: " + age + "\nStudent's group: " + Group +
                "\nStudent's Tasks:\n\n" + RenderTasks() + "\n";

        }

        public override bool Equals(object obj)
        {
            if (obj != null && obj.GetType() == this.GetType())
            {
                Student other = obj as Student;
                if (other.Name.Equals(this.Name))
                {
                    if (other.Age.Equals(this.Age))
                    {
                        if (this.tasks.Count == other.tasks.Count)
                        {
                            for (int i = 0; i < this.tasks.Count; i++)
                            {
                                if (!this.tasks[i].Equals(other.tasks[i]))
                                {
                                    return false;
                                }
                            }
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}
