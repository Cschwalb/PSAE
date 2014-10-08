﻿using PASaveEditor;

namespace FileModel {
    internal class ReformProgram : Node {
        public ReformStudents Students;

        public ReformProgram(string label)
            : base(label) {}


        public override Node CreateNode(string label) {
            if ("Students".Equals(label)) {
                Students = new ReformStudents(label);
                return Students;
            } else {
                return base.CreateNode(label);
            }
        }


        public override void WriteStuff(Writer writer) {
            writer.WriteNode(Students);
        }
    }
}