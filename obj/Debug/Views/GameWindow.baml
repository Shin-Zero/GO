   M S B A M L   `   `   `  ����D  @GO, Version=1.0.5998.22359, Culture=neutral, PublicKeyToken=null#clr-namespace:GO.ViewsGO.Views  5      %clr-namespace:GO.Models	GO.Models  5          GO.Views.GameWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:GO.Views     5      *modelsclr-namespace:GO.Models     5        � WindowStartupLocation$  CenterScreen=�5   3    � Title$ GO Game window��5       � 	Resources 5
         ChessBoardBrush j� Stretch j� TileMode j� Viewport j� ViewportUnits L� Drawing � Brush	 � Geometry
 �� Rect  GoBoardBrush �� ImageSource  
StoneStyle �� 
TargetType �� Triggers ^� 
Conditions   GO.Models.StoneType   Black �� Value �� Binding �� Property �� Value   White��%@  &	        &	 t    &	 �    L� 5   
   $
 None=�6/   $
 Tile=�6>   $ 0,0,200,200�6N   $ Absolute=�6e    5      I� 5      .��5      � 
 �����	 5      �� 5      $
 0,0,200,200�60   5      � 5      
 �**��	 5      � 5      .��5   "   �� $
 0,0,100,100�64   �� 5   "   $
 100,100,100,100�64   5      5      5      5      �� 5      $ ../Resources/Board1.png��6'   6O   �� 5   
   " ��6#    5       ^� 5!       5"      �� 5#      # Z 6=    6$   �� *Type+6=   0�5%      �� 5&       � ��$" ../Resources/Stone1Black.png��69   5(      ^� 5)       5*      �� 5+      # Z 6=    6$   �� *Type+6=   0�5-      �� 5.       � ��$" ../Resources/Stone1White.png��69   50      52      53      .��54      �� .+�55      ]� $��Center=�6   
���������6.   �� *	BoardSize+.+�56      �� $��Белые камни��6   $
��Left=�6$   �� 57      $
��Left=�6   $
��Left=�6J   $��Center=�6e   ��6(   �� *WhiteStonesCount+6e   �� 58      $��Черные камни��6   $��Right=�6%   $��Right=�6<   �� 59      $��Right=�6   $��Right=�6K   $��Center=�6g   ��6)   �� *BlackStonesCount+6g   5:      ]� 5;      $��Center=�6   
���������6+   �� *	BoardSize+.+�5<      �� $��Белый игрок��6   $
��Left=�6$   �� 5=      $
��Left=�6   $
��Left=�6D   $��Center=�6_   ��6(   �� *
WhiteScore+6_   �� 5>      $��Черный игрок��6   $��Right=�6%   $��Right=�6<   �� 5?      $��Right=�6   $��Right=�6E   $��Center=�6a   ��6)   �� *
BlackScore+6a   5@      �� 5A   
   -   5        $��GoBoard��5A      ��6&   �� *Stones+��5B      �� 5C      .R�5D      �� -   5        $	��700��5D      $	��700��6)   #��[ 66   6a   5E      ��5G      �� 5H      .R�5I      � $��40��6   $��40��6&   .+�5J      �� $��35��6    $��35��6+   #��[ 67   5K      5L      ��5N      �� 5O      .�5P      ��  �@��Left 64   �� *
Position.X+�� 5Q       �@��Top 63   �� *
Position.Y+5R      5T      5V      5W      