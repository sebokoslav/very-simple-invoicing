using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using VerySimpleInvoicing.Desktop.Models;

namespace VerySimpleInvoicing.Desktop.UserControls
{
    /// <summary>
    /// Interaction logic for InvoiceControl.xaml
    /// </summary>
    public partial class InvoicesControl : UserControl
    {
        public InvoicesControl()
        {
            InitializeComponent();
            List<InvoiceModel> invoices = new List<InvoiceModel>();
            invoices.Add(new InvoiceModel() { CustomerName = "Company Inc." });
            invoices.Add(new InvoiceModel() { CustomerName = "Company Inc." });
            invoices.Add(new InvoiceModel() { CustomerName = "Company Inc." });
            invoices.Add(new InvoiceModel() { CustomerName = "Company Inc." });
            invoices.Add(new InvoiceModel() { CustomerName = "Company Inc." });
            invoices.Add(new InvoiceModel() { CustomerName = "Company Inc." });
            invoices.Add(new InvoiceModel() { CustomerName = "Company Inc." });
            invoices.Add(new InvoiceModel() { CustomerName = "Another Company Inc." });
            lvDataBinding.ItemsSource = invoices;
            dgItems.ItemsSource = invoices;
        }
    }
}
