namespace CurrencyConverter
{
    public partial class CurrencyConverter : Form
    {
        private readonly Dictionary<string, decimal> exchangeRates;

        public CurrencyConverter()
        {
            InitializeComponent();

            exchangeRates = new Dictionary<string, decimal>
            {
                { "USD-EUR", 0.91M },
                { "EUR-USD", 1.10M },
                { "USD-NGN", 1579.17M },
                { "NGN-USD", 0.000633M },
                { "EUR-NGN", 1730.00M },
                { "NGN-EUR", 0.000578M }
            };

            var listofCurrencies = exchangeRates.Keys.Select(x => x.Split('-')).SelectMany(x => x).Distinct().ToList();

            FromComboBox.Items.AddRange(listofCurrencies.ToArray());
            ToComboBox.Items.AddRange(listofCurrencies.ToArray());
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AmountTextBox.Text))
            {
                MessageBox.Show("Please enter an amount to convert.");
                return;
            }
            if (FromComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a currency to convert from.");
                return;
            }
            if (ToComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a currency to convert to.");
                return;
            }
            var fromCurrency = FromComboBox.SelectedItem?.ToString();
            var toCurrency = ToComboBox.SelectedItem?.ToString();
            if (fromCurrency == toCurrency)
            {
                MessageBox.Show("Please select different currencies to convert.");
                return;
            }
            decimal amount;
            if (!decimal.TryParse(AmountTextBox.Text, out amount))
            {
                MessageBox.Show("Please enter a valid amount to convert.");
                return;
            }
            var exchangeRate = exchangeRates[$"{fromCurrency}-{toCurrency}"];
            var convertedAmount = amount * exchangeRate;
            ConvertedLabel.Text = $"{amount} {fromCurrency} = {convertedAmount} {toCurrency}";
            ConvertedLabel.Visible = true;
        }
    }
}