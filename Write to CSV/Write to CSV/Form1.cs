using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Write_to_CSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public class Foo
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var records = new List<Foo>
            {
                new Foo { Id = 1, Name = "John", Age = 21 },
                new Foo { Id = 2, Name = "Matthew", Age = 18 }
            };

            using (var writer = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Eksport fra Flexi.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(records);


                writer.Flush();
            }
        }

        public class Test
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }
}
