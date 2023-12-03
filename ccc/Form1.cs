namespace ccc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnresult_Click(object sender, EventArgs e)
        {
            int Firstnumber, Secondnumber, bscnnlabel;

            if (!int.TryParse(txtst1.Text.ToString(), out Firstnumber) || !int.TryParse(txtst2.Text.ToString(), out Secondnumber))
            {
                MessageBox.Show("Vui long nhap so nguyen hop li.", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bscnnlabel = (Firstnumber > Secondnumber) ? Firstnumber : Secondnumber;

            while (true)
            {
                if (bscnnlabel % Firstnumber == 0 && bscnnlabel % Secondnumber == 0)
                {
                    txtbscnn.Text = $"Boi chung nho nhat cua {Firstnumber} và {Secondnumber} là {bscnnlabel}";

                    break;
                }

                bscnnlabel++;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            string message = "Are you sure ?";
            string title = "Message";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;
            DialogResult result = MessageBox.Show(message, title, buttons, icon);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}