using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    class Task
    {
        private string name;
        private TaskStatus status;

        public string Name
        {
            get => name;
            set { name = value; }
        }

        public TaskStatus Status
        {
            get => status;
            set { status = value; }
        }

        public Task(string name, TaskStatus status)
        {
            Name = name;
            Status = status;
        }

        public override string ToString()
        {
            return "Task's name: " + Name + "\tTask's status: " + Status + "\n";
        }

        public override bool Equals(object obj)
        {
            if (obj != null && obj.GetType() == this.GetType())
            {
                Task other = obj as Task;
                if (other.Name.Equals(this.Name) && other.Status == this.Status)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
