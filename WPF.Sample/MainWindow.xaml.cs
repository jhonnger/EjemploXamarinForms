using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.WPF;

namespace WPF.Sample
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : FormsApplicationPage
    {
        public MainWindow()
        {
            InitializeComponent();
            Forms.Init();
            LoadApplication(new Ejemplo1.App());
        }
    }
}
