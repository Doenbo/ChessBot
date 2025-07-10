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


            //KNIGHT
            var moves = game.GetPotentialMoves("B8");
            TB1.Text += "\nB8 can go to: ";
            moves.ForEach(square =>
            {
                TB1.Text += square.ToString() + ",";
            });

            //KING
            moves = game.GetPotentialMoves("E8");
            TB1.Text += "\nE8 can go to: ";
            moves.ForEach(square =>
            {
                TB1.Text += square.ToString() + ",";
            });


            //QUEEN
            moves = game.GetPotentialMoves("D8");
            TB1.Text += "\nD8 can go to: ";
            moves.ForEach(square =>
            {
                TB1.Text += square.ToString() + ",";
            });


            //ROOK
            moves = game.GetPotentialMoves("A8");
            TB1.Text += "\nA8 can go to: ";
            moves.ForEach(square =>
            {
                TB1.Text += square.ToString() + ",";
            });


            //BISHOP
            moves = game.GetPotentialMoves("C8");
            TB1.Text += "\nC8 can go to: ";
            moves.ForEach(square =>
            {
                TB1.Text += square.ToString() + ",";
            });


            //PAWN
            moves = game.GetPotentialMoves("C7");
            TB1.Text += "\nC7 can go to: ";
            moves.ForEach(square =>
            {
                TB1.Text += square.ToString() + ",";
            });

        }
    }
}