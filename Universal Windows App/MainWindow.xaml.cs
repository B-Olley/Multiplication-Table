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



namespace Stringpractice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string repeat = "";
        string label;
        string dt1;
        object datetime1;

        public MainWindow()
        {
            InitializeComponent();
            label = "Multiplication Table";
            
            datetime1 = DateTime.Now.ToShortDateString();
            dt1 = datetime1.ToString();
            for (int i = 1; i != 11; i++)
            {
                for (int y = 1; y != 11; y++)
                {
                    int math1 = i * y;


                    repeat += math1 + "\t";
                }
                repeat += "\n";
            }






            labelBox.Text = repeat;

            textBox2.Text = label;
           
            date1.Text = dt1;


        }


        //public void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        //{
           
             
        //}
    }
}
