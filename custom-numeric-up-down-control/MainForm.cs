using System.ComponentModel;

namespace custom_inumeric_increment_control
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            numericUpDown.ValueChanged += (sender, e) =>
            {
                Text = $"Main Form - Modifier: {ModifierKeys}";
            };
        }
    }
    class CustomNumericUpDown : NumericUpDown
    {
        public CustomNumericUpDown() => DecimalPlaces = 1;
        public override void UpButton()
        {
            if(ModifierKeys.Equals(Keys.Control))
            {
                Value += 0.1m;
            }
            else
            {
                // Call Default
                base.UpButton();
            }
        }
        public override void DownButton()
        {
            if (ModifierKeys.Equals(Keys.Control))
            {
                Value -= 0.1m;
            }
            else
            {
                // Call Default
                base.DownButton();
            }
        }
    }
}