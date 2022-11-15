using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PW_Lab5
{
    public partial class Form1 : Form
    {
        string sekwencja;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                sekwencja = File.ReadAllText(ofd.FileName);
                richTextBox1.Text = sekwencja;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string listakoniec = "";
            List<string> list1 = new List<string>();
            List<int> list2 = new List<int>();
            for (int i = sekwencja.Length; i > 3; i--)
            {
                string str = (sekwencja[i - 4].ToString() + sekwencja[i - 3].ToString() + sekwencja[i - 2].ToString() + sekwencja[i - 1].ToString());
                if (list1.Contains(str))
                { 
                    list2[list1.IndexOf(str)] = list2[list1.IndexOf(str)] + 1;
                }
                else
                {
                    list1.Add(str);
                    list2.Add(1);
                }
            }

            for (int n = list2.Count; n > 0; n--)
            {
                if (list2[n - 1] >= 1)
                {
                    listakoniec = listakoniec + list1[n - 1] + " " + list2[n - 1] + "\t";
                }
            }
            textBox1.Text = listakoniec;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            sekwencja = richTextBox1.Text;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
    
