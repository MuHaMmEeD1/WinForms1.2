namespace WinForms_C__LESSON_1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     

        private void Form1_Load(object sender, EventArgs e)
        {
           this.MouseHover += Form1_Tutammazsankiii;
            

        }
        private void Form1_Tutammazsankiii(object sender, EventArgs e)
        {

            label1.Location = new Point(Random.Shared.Next(this.Width-50), Random.Shared.Next(this.Height-50));

        }


        private void Label_MouseDown(object sender, MouseEventArgs e)
        {
           

           
        }


    }
}