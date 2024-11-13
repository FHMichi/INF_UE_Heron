namespace INF_UE_Heron
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

        private void btStart_Click(object sender, EventArgs e)
        {
            try
            {

                lbAnzeige.Items.Clear(); ;

                double a = Int32.Parse(tbEingabe.Text);
                double an = a;
                double an_next;
                double error = 0;

                if(a < 0) throw new Exception("Wurzel bei negativer Zahl nicht möglich! " );

                if (rbAnz.Checked)
                {
                    int iterations = Int32.Parse(tbIterations.Text);
                    if (iterations <= 0) throw new Exception("Iterationen Anzahl muss >0 && !=0 sein! "); 

                    for (int i = 0; i < iterations; i++)
                    {
                        an_next = 0.5 * (an + a / an);
                        error = Math.Abs(an_next - an);
                        an = an_next;
                        lbAnzeige.Items.Insert(0, "a" + (i) + " = " + +an);
                    }
                    lblFalse.Text = "Der Fehler beträgt: " + error;

                }
                else if (rbSize.Checked)
                {
                    double ErrorLimit = Double.Parse(tbSmallerAs.Text);
                    if (ErrorLimit <= 0) throw new Exception("Anzunehmender Fehler muss >0 && !=0 sein!  ");

                    int counter = 0;
                    do
                    {
                        counter++;
                        an_next = 0.5 * (an + a / an);
                        error = Math.Abs(an_next - an);
                        an = an_next;

                        lbAnzeige.Items.Insert(0, "a" + (counter - 1) + " = " + +an);

                    } while (ErrorLimit < error);


                    lblFalse.Text = "Es wurden " + counter + " Schritte benötigt";

                }
            }catch (Exception ex)
            {
                MessageBox.Show("Fehler: " + ex.Message); 
            }
            
            


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
