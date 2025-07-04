using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ChessBot.src.game;

namespace ChessBot
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var game = new Game();
            TB1.Text = game.Board.ToString();

            var moves = game.GetPotentialMoves("B8");
            moves.ForEach(square =>
            {
                TB1.Text += square.ToString() + ",";
            });


        }
    }
}