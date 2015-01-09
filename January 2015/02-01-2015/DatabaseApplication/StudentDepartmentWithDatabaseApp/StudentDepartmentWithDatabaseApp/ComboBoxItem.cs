using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDepartmentWithDatabaseApp
{
    class ComboBoxItem:object
    {
        public string Text { get; private set; }
        public int Value { get; private set; }

        public void AddItem(int value, string text)
        {
            Text = text;
            Value = value;
        }
        public override string ToString()
        {
            return Text;
        }
    }
}
