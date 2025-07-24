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
using ChessBot.Model.Game;

namespace ChessBot.View
{
    /// <summary>
    /// Interaction logic for ButtonWindow.xaml
    /// </summary>
    public partial class ButtonWindow : Window
    {
        public ButtonWindow()
        {
            InitializeComponent();
            var game = new Game();
            //TB1.Text = game.Board.ToString();

            int count = 1;


            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Button MyControl1 = new Button();
                    MyControl1.FontSize = 64;
                    var pos = new Position(i, j).ToString();
                    MyControl1.Content = game.Board.GetPiece(pos)?.ToString() ?? " ";
                    MyControl1.Name = pos;

                    Grid.SetColumn(MyControl1, j);
                    Grid.SetRow(MyControl1, i);
                    GridButtons.Children.Add(MyControl1);

                    count++;
                }

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;

        }

    }    
}