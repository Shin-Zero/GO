   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5      C ?WPFSpark, Version=1.2.0.1, Culture=neutral, PublicKeyToken=null5(clr-namespace:WPFSpark;assembly=WPFSparkWPFSpark 5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089$   WPFSpark.GeometryPathConverter   GeometryConverter  SplitViewBackgroundBrush  �� Color  SplitViewForegroundBrush  MenuButtonBackgroundBrush $  MenuButtonPressedBackgroundBrush " MenuButtonHoverBackgroundBrush $  MenuButtonCheckedBackgroundBrush + 'MenuButtonCheckedPressedBackgroundBrush ) %MenuButtonCheckedHoverBackgroundBrush 	 NavButtonBackgroundBrush #
 NavButtonPressedBackgroundBrush ! NavButtonHoverBackgroundBrush # NavButtonCheckedBackgroundBrush # NavButtonCheckedForegroundBrush * &NavButtonCheckedPressedBackgroundBrush ( $NavButtonCheckedHoverBackgroundBrush  DefaultForegroundBrush  SplitViewNormalNavFontSize  SplitViewLargeNavFontSize  SplitViewBackButtonHeight 2 .RadioButtonContentDisabledForegroundThemeBrush $  FocusVisualBlackStrokeThemeBrush $  FocusVisualWhiteStrokeThemeBrush �� 
TargetType  SplitViewTextBlockStyle �� Property �� Value  SplitViewMenuButtonStyle �� 
TargetType'  !System.Windows.VisualStateManager   VisualStateGroups%  System.Windows.VisualStateGroup   States   System.Windows.VisualState   
Storyboard �� TargetProperty	 �� 
TargetName
 R� KeyTime R� Value  System.Windows.Visibility � RowDefinitions � ColumnDefinitions � 	Resources �Name ��Name �� StrokeDashOffset J� Opacity �� StrokeDashArray �� StrokeEndLineCap F�Name J� SnapsToDevicePixels �� 	Converter  SplitViewNavButtonStyle ��Name�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      .sys&clr-namespace:System;assembly=mscorlib  5      5wpfspark(clr-namespace:WPFSpark;assembly=WPFSpark  5      %�   &	        &	      &	 6     &	 Y     &	 �     &	 �     &	 �     &	 �     &	     &		 C    &	
 j    &	 �    &	 �    &	 �    &	     &	 )    &	 P    &	 w    &	 �    &	 �    &	 �    &	 �    &	     &	 2    7  &	 �    7  7  7  7  7  7  7  7  7  7  7  7  7   &	 �    7 	 7  7  7  7  7  7 
 7  7  7  7  7  7   7  7     5      6A   �� 5       $  Black��5!      �� 5"      $  Black��5#      �� 5%      $  	#ff444444��5&      �� 5'      $  	#ff000000��5(      �� 5)      $  	#ff555555��5*      �� 5+      $  	#ff444444��5,      �� 5-      $  	#ff000000��5.      �� 5/      $  	#ff555555��50      �� 52      $  	#ff222222��53      �� 54      $  	#bb007aff��55      �� 56      $  	#99007aff��57      �� 58      $  	#ff007aff��59      �� 5:      $  White��5;      �� 5<      $  	#bb007aff��5=      �� 5>      $  	#99007aff��5?      �� 5@      $  	#ffffffff��5A      X�5C      14Q�68   X�5D      20Q�67   X�5E      32Q�67   �� 5F      $  	#66FFFFFF��5G      �� 5H      $  Black��5I      �� 5J      $  White��5K      �� 5M      " ��6   .�5O   
   ��  �@J�SnapsToDevicePixels . 5P       �� 5Q   
    � ��
 ���� 5R   '   �� 5S   
    � ��
 �   �5T   !   �� 5U   
    � ��$ Center=�5V      �� 5W   
    � ��$ Center=�5X      �� 5Y   
    � ��$ Segoe MDL2 Assets)�5Z      �� 5[   
    � ��$ Light"�5\      6!   �� 5]   
    � ��8   5^      5_      �� 5a      " 	�6   .�5c   
   ��  � ��8   5d      �� 5e   
    � ��8  5f      �� 5g   
    � ��$ 0,0,0,0q�5h      �� 5i   
    �@�FocusVisualStyle 5j      Z� �� 5k   
    � ��$ Stretch=�5l      �� 5m   
    � ��$ Center=�5n      �� 5o   
    � ��$
 Left=�5p      �� 5q   
    � ��$ Center=�5r      �� 5s   
    � �� 5t      �� 5u      " 	�6"   .R�5v      �� #��z��6   #��z��5w      #��z��5x       5y        5z      CommonStates��. 5{   "     
Normal��6.     5|   "   	MouseOver��. 5}   &   �� .��5~   *   T� $ (UIElement.Visibility)�6H   $	 HoverBackground��5   H   ..�5�   .   i� $
 0��6E    5�   2    5�   6   Visible=�6J   5�   /   5�   +   T� 5�   *   $ (UIElement.Visibility)�6H   $	 CheckedHoverBackground��5�   H   ..�5�   .   i� $
 0��6E    5�   2    5�   6   Visible=�6J   5�   /   5�   +   5�   '   5�   #     5�   "   Pressed��. 5�   &   �� .��5�   *   T� $ (UIElement.Visibility)�6H   $	 PressedBackground��5�   H   ..�5�   .   i� $
 0��6E    5�   2    5�   6   Visible=�6J   5�   /   5�   +   T� 5�   *   $ (UIElement.Visibility)�6H   $	 CheckedPressedBackground��5�   H   ..�5�   .   i� $
 0��6E    5�   2    5�   6   Visible=�6J   5�   /   5�   +   5�   '   5�   #     5�   "   Disabled��. 5�   &   �� .��5�   *   T� $	 Glyph��6H   $
 Fill�5�   H   ..�5�   .   i� $
 0��6E   8  5�   E   5�   +   T� 5�   *   $	 ContentPresenter��6H   $ 
Foreground�5�   H   ..�5�   .   i� $
 0��6E   8  5�   E   5�   +   5�   '   5�   #   5�        5�      CheckStates��. 5�   "     Checked��. 5�   &   �� .��5�   *   T� $ (UIElement.Visibility)�6H   $	 CheckedBackground��5�   H   ..�5�   .   i� $
 0��6E    5�   2    5�   6   Visible=�6J   5�   /   5�   +   5�   '   5�   #     5�   "   	Unchecked��6.     5�   "   Indeterminate��6.   5�        5�      FocusStates��. 5�   "     Focused��6.     5�   "   	Unfocused��6.     5�   "   PointerFocused��6.   5�      ._�5�      �  5�      �� 5�   "   $��48 �60    5�      �� 5�   "   $��48 �63   �� 5�   "   $��* �63   �� 5�   "   $��20 �63    5�      ��5�      .+�5�      � $ UnCheckedBackground��6#   $��3��5�   #   .+�5�   "   �� $ PressedBackground��6,   $y�	Collapsed=�5�   ,   8�� 5�   ,   �� 5�   "   $ HoverBackground��6,   $y�	Collapsed=�5�   ,   8�� 5�   ,   5�      � 5�      $ CheckedBackground��6#   $��3��5�   #   $y�	Collapsed=�5�   #   8�� .+�5�   "   �� $ CheckedPressedBackground��6,   $y�	Collapsed=�5�   ,   8�� 5�   ,   �� 5�   "   $ CheckedHoverBackground��6,   $y�	Collapsed=�5�   ,   8�� 5�   ,   5�      �� 5�      $ FocusVisualWhite��6(   8��	 $	 1.5Q�5�   (   $ 0Q�5�   (   $	 1,1R�5�   (   $ Square=�5�   (   �� 5�      $ FocusVisualBlack��6(   8��
 $	 0.5Q�5�   (   $ 0Q�5�   (   $	 1,1R�5�   (   $ Square=�5�   (   �� 5     $��24��6%   $��24��5  %   $��Center=�5  %   $��Center=�5  %   .+�5  "   F� $ Glyph��6'    . 8�� ��5
  '   �� *Tag+8  6t   5     5     5     5     5     5     �� 5     " 	�6   .�5  
   ��  � ��8   5     �� 5  
    � ��8  5     �� 5  
    � ��$ 8,-2,0,0q�5     �� 5  
    � ��$ Stretch=�5     �� 5  
    � ��$ Center=�5     �� 5  
    � ��$
 Left=�5      �� 5!  
    � ��$ Center=�5"     �� 5#  
    �@	�	GroupName$ Primary��5$     �� 5%  
    � �� 5&     �� 5'     " 	�6"   .R�5(     �� #��z��6   #��z��5)     #��z��5*      5+       5,     CommonStates��. 5-  "     
Normal��6.     5.  "   	MouseOver��. 5/  &   �� .��50  *   T� $ (UIElement.Visibility)�6H   $	 HoverBackground��51  H   ..�52  .   i� $
 0��6E    53  2    54  6   Visible=�6J   56  /   57  +   T� 58  *   $ (UIElement.Visibility)�6H   $	 CheckedHoverBackground��59  H   ..�5:  .   i� $
 0��6E    5;  2    5<  6   Visible=�6J   5>  /   5?  +   5@  '   5A  #     5B  "   Pressed��. 5C  &   �� .��5D  *   T� $ (UIElement.Visibility)�6H   $	 PressedBackground��5E  H   ..�5F  .   i� $
 0��6E    5G  2    5H  6   Visible=�6J   5J  /   5K  +   T� 5L  *   $ (UIElement.Visibility)�6H   $	 CheckedPressedBackground��5M  H   ..�5N  .   i� $
 0��6E    5O  2    5P  6   Visible=�6J   5R  /   5S  +   5T  '   5U  #     5V  "   Disabled��. 5W  &   �� .��5X  *   T� $	 Glyph��6H   $
 Fill�5Y  H   ..�5Z  .   i� $
 0��6E   8  5[  E   5\  +   T� 5]  *   $	 ContentPresenter��6H   $ 
Foreground�5^  H   ..�5_  .   i� $
 0��6E   8  5`  E   5a  +   5b  '   5c  #   5d       5e     CheckStates��. 5f  "     Checked��. 5g  &   �� .��5h  *   T� $ (UIElement.Visibility)�6H   $	 CheckedBackground��5i  H   ..�5j  .   i� $
 0��6E    5k  2    5l  6   Visible=�6J   5n  /   5o  +   T� 5p  *   $	 Glyph��6H   $
 Fill�5q  H   ..�5r  .   i� $
 0��6E   8  5s  E   5t  +   T� 5u  *   $	 TextContent��6H   $ 
Foreground�5v  H   ..�5w  .   i� $
 0��6E   8  5x  E   5y  +   5z  '   5{  #     5|  "   	Unchecked��6.     5}  "   Indeterminate��6.   5~       5     FocusStates��. 5�  "     Focused��6.     5�  "   	Unfocused��6.     5�  "   PointerFocused��6.   5�     ._�5�     �  5�     �� 5�  "   $��48 �60    5�     �� 5�  "   $��48 �63   �� 5�  "   $��* �63   �� 5�  "   $��20 �63   .+�5�     � $ UnCheckedBackground��6#   $��3��5�  #   .+�5�  "   �� $ PressedBackground��6,   $y�	Collapsed=�5�  ,   8�� 5�  ,   �� 5�  "   $ HoverBackground��6,   $y�	Collapsed=�5�  ,   8�� 5�  ,   5�     � 5�     $ CheckedBackground��6#   $��3��5�  #   $y�	Collapsed=�5�  #   8�� .+�5�  "   �� $ CheckedPressedBackground��6,   $y�	Collapsed=�5�  ,   8��	 5�  ,   �� 5�  "   $ CheckedHoverBackground��6,   $y�	Collapsed=�5�  ,   8��
 5�  ,   5�     �� 5�     $��24��6%   $��24��5�  %   $��Center=�5�  %   $��Center=�5�  %   .+�5�  "   F� $ Glyph��6'    . 8�� ��5�  '   �� *Tag+8  6t   5�     �� 5�     $ TextContent��6(   $��1��5�  (   #��z��5�  (   8�� #��z��5�  (   8�� #��z��5�  (   #��z��5�  (   5�     5�     5�     5�     5�     5�     