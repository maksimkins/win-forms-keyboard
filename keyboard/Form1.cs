namespace keyboard
{
    public partial class Form1 : Form
    {
        private List<Button> listOfButtons;
        public Form1()
        {
            InitializeComponent();
            listOfButtons = new List<Button>();
            listOfButtons.Add(button1);
            listOfButtons.Add(button2);
            listOfButtons.Add(button3);
            listOfButtons.Add(button4);
            listOfButtons.Add(button5);
            listOfButtons.Add(button6);
            listOfButtons.Add(button7);
            listOfButtons.Add(button8);
            listOfButtons.Add(button9);
            listOfButtons.Add(button10);
            listOfButtons.Add(button11);
            listOfButtons.Add(button12);
            listOfButtons.Add(button13);
            listOfButtons.Add(button14);
            listOfButtons.Add(button15);
            listOfButtons.Add(button16);
            listOfButtons.Add(button17);
            listOfButtons.Add(button18);
            listOfButtons.Add(button19);
            listOfButtons.Add(button20);
            listOfButtons.Add(button21);
            listOfButtons.Add(button22);
            listOfButtons.Add(button23);
            listOfButtons.Add(button24);
            listOfButtons.Add(button25);
            listOfButtons.Add(button26);
            listOfButtons.Add(button27);
            listOfButtons.Add(button28);
            listOfButtons.Add(button29);
            listOfButtons.Add(button30);
            listOfButtons.Add(button31);
            listOfButtons.Add(button32);
            listOfButtons.Add(button33);
            listOfButtons.Add(button34);
            listOfButtons.Add(button35);
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            if (!(sender is Button))
            {
                return;
            }

            Button button = sender as Button;

            if (button.Text.Length > 1)
            {
                FuncButton(button);
                return;
            }

            labelLine.Text += button.Text;
        }


        private void FuncButton(Button button)
        {
            switch(button.Text)
            {
                case "up":
                    foreach(Button b in listOfButtons)
                    {
                        if (b.Text.Length == 1)  b.Text = b.Text.ToUpper();
                    }
                    break;

                case "down":
                    foreach (Button b in listOfButtons)
                    {
                        if(b.Text.Length == 1) b.Text = b.Text.ToLower();
                    }
                    break;

                case "enter":
                    labelLine.Text += "\n";
                    break;

                case "backspace":
                    if (labelLine.Text.Length == 0)
                        return;
                    labelLine.Text = labelLine.Text.Substring(0, labelLine.Text.Length - 1);
                    break;
            }
        }


    }
}