using ValuteLibrary;

namespace GetValuteUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGetInfo(object sender, EventArgs e)
        {
            var currents = Controller.GetValuteInfoFromUrl("");

            var current = currents.Valute.GetFullInfo();

            var btn = sender as Button;
            var result = Controller.GetValuteInfo(btn.Text, current);

            string text = string.Empty;

            if (AutoClear.Checked == true)
            {
                richTextBox.Text = string.Empty;
            }

            foreach (var item in result)
            {
                if (item.Key == "Название валюты:")
                {
                    text = item.Value;
                }
                richTextBox.Text += $"{item.Key} {item.Value}\n";
            }

            toolTip.SetToolTip(btn, text);
        }

        private void buttonClearInfo(object sender, EventArgs e)
        {
            richTextBox.Text = String.Empty;
        }


    }
}