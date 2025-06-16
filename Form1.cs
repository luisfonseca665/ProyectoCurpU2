namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CurpLibrery.Curp curp = new CurpLibrery.Curp();
            this.Controls.Add(curp);
            curp.Location = new System.Drawing.Point(20, 120);
        }
    }
}
