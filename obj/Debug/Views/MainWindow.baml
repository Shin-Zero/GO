   M S B A M L   `   `   `  ����C  ?WPFSpark, Version=1.2.0.1, Culture=neutral, PublicKeyToken=null5(clr-namespace:WPFSpark;assembly=WPFSparkWPFSpark  5      D @GO, Version=1.0.5998.22359, Culture=neutral, PublicKeyToken=null%clr-namespace:GO.Models	GO.Models 5         GO.MainWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      =wpfspark(clr-namespace:WPFSpark;assembly=WPFSpark     5      Fav9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      (modelsclr-namespace:GO.Models    5      -   5           WPFSpark.SparkWindow   Name$  window��5       � Title$ GO��5	      $	��650��6   $	��600��6    � WindowStartupLocation$ CenterScreen=�6)    � 
ResizeMode$ 	CanResize=�5       � SizeToContent$ WidthAndHeight=�6.      TitleEffect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5   
      
BlurRadius$ 16Q�6      Color$ #FFFFFF��5         	Direction$ 0Q�5      	   ShadowDepth$	 1Q�5      
   RenderingBias$
 Quality=�5      65      
TitleImage 5      �� 5   
   $-��'/GO;component/Resources/Stone1Black.png��6   $��24��5      $��24��5      $��Center=�5      $��Center=�5      6-    � 	Resources 5      )   #WPFSpark.ContentVisibilityConverter   ContentVisibilityHelper  ListBoxItemTemplate  ChessBoardBrush j� Stretch j� TileMode j� Viewport j� ViewportUnits L� Drawing � Brush � Geometry �� Rect  GoBoardBrush �� ImageSource  
StoneStyle �� 
TargetType �� Triggers ^� 
Conditions  GO.Models.StoneType   Black �� Value �� Binding �� Property �� Value   White��%�  &	        &	      &	 L    &	 �    &	 �      5   
   6P   �� 5   
   .R�5      �� .+�5       �� $��Segoe UI)�6   $��Light"�5!      $��28(�5"      
�������
������ ��5%      �� *
MainText+68   �� 5&      $��Segoe UI)�6   $��Light"�5'      $��16(�5(      
�������
������ ��5+      �� *	SubText+67   5,      5-      L� 5.   
   $
 None=�6/   $
 Tile=�6>   $ 0,0,200,200�6N   $ Absolute=�6e    5/      I� 50      .��51      � 
 ����� 52      �� 53      $ 0,0,200,200�60   55      � 56      
 �**�� 57      � 58      .��59   "   �� $ 0,0,100,100�64   �� 5:   "   $ 100,100,100,100�64   5;      5=      5>      5@      �� 5A   
   $ ../Resources/Board1.png��6*   6R   �� 5B   
   " ��6#    5C      ^� 5D       5E      �� 5F      # Z 6=    6$   �� *Type+6=   0�5H      �� 5I       � ��$" ../Resources/Stone1Black.png��69   5K      ^� 5L       5M      �� 5N      # Z 6=    6$   �� *Type+6=   0�5P      �� 5Q       � ��$" ../Resources/Stone1White.png��69   5S      5U      5V      .��5W      � -   5         �Name$ RootGrid��5W      ���	#DBE6ECF0  � RowDefinitions  5Y   
   �� 5[      $��* �6   6)   ! � ColumnDefinitions! 5]   
   �� 5^      $��48 �6   6,   �� 5_      $��* �6   6+   .+�5n   
   �� $��1��6   $��10,0,0,0q�5o      $��32(�5p      $��Light"�5q      $��Bottom=�5s      ��5r      �� *
AppTitle+5s   1   � 5t   
   -   5        $ GameBoardGrid��5t      $��0��5u      $��1��5v      $��0,15,0,0q�5w      
���   �y�5x      �� *CurrentAppMode+" �� 	Converter#" [  # �� ConverterParameter$# 	GameBoard��.+�5z      �� $ � DataContext$ 6   �� *GameBoardPanel+.+�5{      ]� $��Center=�6   
���������65   �� *	BoardSize+.+�5|      �� $��Белые камни��6   $
��Left=�6.   �� 5}      $
��Left=�6   $
��Left=�6T   $��Center=�6o   ��62   �� *WhiteStonesCount+6o   �� 5~      $��Черные камни��6   $��Right=�6/   $��Right=�6F   �� 5      $��Right=�6   $��Right=�6U   $��Center=�6q   ��63   �� *BlackStonesCount+6q   5�      ]� 5�      $��Center=�6   
���������65   �� *	BoardSize+.+�5�      �� $��Белый игрок��6   $
��Left=�6.   �� 5�      $
��Left=�6   $
��Left=�6N   $��Center=�6i   ��62   �� *
WhiteScore+6i   �� 5�      $��Черный игрок��6   $��Right=�6/   $��Right=�6F   �� 5�      $��Right=�6   $��Right=�6O   $��Center=�6k   ��63   �� *
BlackScore+6k   5�      (� 5�      .��5�      �� -   5        $��GoBoard��5�      ��6.   �� *Stones+��5�      �� 5�      .R�5�   "   �� -   5        $	��400��5�   )   $	��400��65   #��[ 6B   6m   5�      ��5�      �� 5�      .R�5�      � $��20��6#   $��20��6.   .+�5�   "   �� $��20��6(   $��20��63   #��[ 6?   5�      5�      ��5�      �� 5�      .�5�      ��  �@��Left 6<   �� *
Position.X+�� 5�       �@��Top 6;   �� *
Position.Y+5�      5�      5�      5�      5�      � 5�   
   -   5        $ SplitViewMenu��5�      % K� ZIndex$% 4��5�      $��2��5�      $��2��5�      $��48��5�      $
��Left=�5�      $��Stretch=�5�      ���#2f2f2f.+�5�      �� $��Stretch=�6   $��Stretch=�5�      ���#222222.+�5�      	� -   5          SplitViewMenuButtonStyle#��[ 5�      $��0q�5�      
& � Tag$& 
Menu.Glyph��5�      	� 5�      -   5        ' 	�Name$' GBButton��5�      $��	GameBoard��5�      ( J� SnapsToDevicePixels( .   SplitViewNavButtonStyle#��[ 5�      $��0q�5�      ) � ToolTip$) 	GameBoard��5�      $& FluidPivotPanel.Glyph��5�      5�      5�      5�      5�      5�      