namespace fibonnaci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i2 = Convert.ToInt32(txtPosicao.Text);
            int[] fibo = new int[i2];

            fibo[0] = 1;
            fibo[1] = 1;

            for(int i = 2; i <  fibo.Length; i++) {
                fibo[i] = fibo[i - 1] + fibo[i - 2];
                
            }
            lblResultado.Text = Convert.ToString(fibo[i2-1]);

        } //lero lero
    }
}