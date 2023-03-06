namespace JsonDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CTest obj = new CTest();
            obj.first_name = "Delia";
            obj.last_name = "Cirstea";
            obj.age = 32;

            string obj_json = Newtonsoft.Json.JsonConvert.SerializeObject(obj);
            textBox1.Text = obj_json;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Enrollment myEnrollment;
            myEnrollment = 
               (Enrollment)Newtonsoft.Json.JsonConvert.DeserializeObject(textBox2.Text,typeof(Enrollment));
            MessageBox.Show(myEnrollment.course);
        }
    }
}