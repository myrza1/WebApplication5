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

namespace WpfApplication1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            WpfApplication1.eAirlinesDataSet eAirlinesDataSet = ((WpfApplication1.eAirlinesDataSet)(this.FindResource("eAirlinesDataSet")));
            // Загрузить данные в таблицу vArrivalFlight. Можно изменить этот код как требуется.
            WpfApplication1.eAirlinesDataSetTableAdapters.vArrivalFlightTableAdapter eAirlinesDataSetvArrivalFlightTableAdapter = new WpfApplication1.eAirlinesDataSetTableAdapters.vArrivalFlightTableAdapter();
            eAirlinesDataSetvArrivalFlightTableAdapter.Fill(eAirlinesDataSet.vArrivalFlight);
            System.Windows.Data.CollectionViewSource vArrivalFlightViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("vArrivalFlightViewSource")));
            vArrivalFlightViewSource.View.MoveCurrentToFirst();
        }
    }
}
