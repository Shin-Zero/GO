using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
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

namespace GO.Test
{
    /// <summary>
    /// Interaction logic for ChessWindow.xaml
    /// </summary>
    public partial class ChessWindow : Window
    {
        public ChessWindow()
        {
            InitializeComponent();
            this.ChessBoard.ItemsSource = new ObservableCollection<ChessPiece>
            {
                new ChessPiece {Pos = new Point(0, 600), Type = PieceType.Pawn, Player = Player.White},
                new ChessPiece {Pos = new Point(100, 600), Type = PieceType.Pawn, Player = Player.White},
                new ChessPiece {Pos = new Point(200, 600), Type = PieceType.Pawn, Player = Player.White},
                new ChessPiece {Pos = new Point(300, 600), Type = PieceType.Pawn, Player = Player.White},
                new ChessPiece {Pos = new Point(400, 600), Type = PieceType.Pawn, Player = Player.White},
                new ChessPiece {Pos = new Point(500, 600), Type = PieceType.Pawn, Player = Player.White},
                new ChessPiece {Pos = new Point(600, 600), Type = PieceType.Pawn, Player = Player.White},
                new ChessPiece {Pos = new Point(700, 600), Type = PieceType.Pawn, Player = Player.White},
                new ChessPiece {Pos = new Point(0, 700), Type = PieceType.Rook, Player = Player.White},
                new ChessPiece {Pos = new Point(100, 700), Type = PieceType.Knight, Player = Player.White},
                new ChessPiece {Pos = new Point(200, 700), Type = PieceType.Bishop, Player = Player.White},
                new ChessPiece {Pos = new Point(300, 700), Type = PieceType.King, Player = Player.White},
                new ChessPiece {Pos = new Point(400, 700), Type = PieceType.Queen, Player = Player.White},
                new ChessPiece {Pos = new Point(500, 700), Type = PieceType.Bishop, Player = Player.White},
                new ChessPiece {Pos = new Point(600, 700), Type = PieceType.Knight, Player = Player.White},
                new ChessPiece {Pos = new Point(700, 700), Type = PieceType.Rook, Player = Player.White},
                new ChessPiece {Pos = new Point(0, 100), Type = PieceType.Pawn, Player = Player.Black},
                new ChessPiece {Pos = new Point(100, 100), Type = PieceType.Pawn, Player = Player.Black},
                new ChessPiece {Pos = new Point(200, 100), Type = PieceType.Pawn, Player = Player.Black},
                new ChessPiece {Pos = new Point(300, 100), Type = PieceType.Pawn, Player = Player.Black},
                new ChessPiece {Pos = new Point(400, 100), Type = PieceType.Pawn, Player = Player.Black},
                new ChessPiece {Pos = new Point(500, 100), Type = PieceType.Pawn, Player = Player.Black},
                new ChessPiece {Pos = new Point(600, 100), Type = PieceType.Pawn, Player = Player.Black},
                new ChessPiece {Pos = new Point(700, 100), Type = PieceType.Pawn, Player = Player.Black},
                new ChessPiece {Pos = new Point(0, 0), Type = PieceType.Rook, Player = Player.Black},
                new ChessPiece {Pos = new Point(100, 0), Type = PieceType.Knight, Player = Player.Black},
                new ChessPiece {Pos = new Point(200, 0), Type = PieceType.Bishop, Player = Player.Black},
                new ChessPiece {Pos = new Point(300, 0), Type = PieceType.King, Player = Player.Black},
                new ChessPiece {Pos = new Point(400, 0), Type = PieceType.Queen, Player = Player.Black},
                new ChessPiece {Pos = new Point(500, 0), Type = PieceType.Bishop, Player = Player.Black},
                new ChessPiece {Pos = new Point(600, 0), Type = PieceType.Knight, Player = Player.Black},
                new ChessPiece {Pos = new Point(700, 0), Type = PieceType.Rook, Player = Player.Black}
            };
        }
    }
}
