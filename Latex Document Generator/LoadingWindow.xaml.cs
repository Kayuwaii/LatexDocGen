using LatexDocGen.Core.BlockManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace LatexDocGen
{
    /// <summary>
    /// Lógica de interacción para LoadingWindow.xaml
    /// </summary>
    public partial class LoadingWindow : Window
    {
        private BlockManager man;

        public LoadingWindow()
        {
            InitializeComponent();
            ConfigureBlockManager();
        }

        private void ConfigureBlockManager()
        {
            man = new BlockManager();
            man.OnLoadingStarted += Man_OnLoadingStarted;
            man.OnSingleBlockLoaded += Man_OnSingleBlockLoaded;
        }

        private async Task Man_OnSingleBlockLoaded(string name)
        {
            await Task.Delay(10);
            this.Bar.Value++;
        }

        private void Man_OnLoadingStarted(int total)
        {
            this.Bar.Maximum = total;
        }

        private void WindowLoaded(object sender, EventArgs e)
        {
            man.LoadBlocks();
        }
    }
}