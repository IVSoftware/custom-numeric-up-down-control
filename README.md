One way to do this is by making a `CustomNumericUpDown` control and swapping out all instances of the regular `NumericUpDown` control in your designer file.

Then you can just override the methods that implement the value up-down at the source and call the base class or not depending on the static value of `Control.ModifierKeys` property.

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
                base.UpButton();
            }
        }
    }