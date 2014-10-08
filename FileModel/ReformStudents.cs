using System.Collections.Generic;
using PASaveEditor;

namespace FileModel {
    internal class ReformStudents : Node{
        public readonly Dictionary<int, ReformStudent> Students = new Dictionary<int, ReformStudent>();

        public ReformStudents(string label)
            : base(label) {}


        public override Node CreateNode(string label) {
            if (label.Equals("i")) {
                return new ReformStudent(label);
            } else {
                return base.CreateNode(label);
            }
        }


        public override void FinishedReadingNode(Node node) {
            var studentNode = node as ReformStudent;
            if (studentNode != null) {
                Students.Add(studentNode.Id, studentNode);
            }
        }


        public override void WriteStuff(Writer writer) {
            writer.WriteProperty("Size",Students.Count);
            foreach (ReformStudent student in Students.Values) {
                writer.WriteNode(student);
            }
        }
    }
}