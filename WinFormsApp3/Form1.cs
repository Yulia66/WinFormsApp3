namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        Plus plas;
        Mines mines;
        Multi multi;
        Divis divis;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();

            plas.Paint(g);
            mines.Paint(g);
            multi.Paint(g);
            divis.Paint(g);                     


        }
        public Form1()
        {
            InitializeComponent();
            plas = new Plus(20, 20, 200, 100, this);
            mines = new Mines(20, 200, 200, 100, this);
            multi = new Multi(500, 200, 200, 100, this);
            divis = new Divis(500, 20, 200, 100, this);
        }

       
    }
}