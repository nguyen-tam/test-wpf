   M S B A M L   `   `   `  ����F  BTestWindows, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:TestWindowsTestWindows  5          TestWindows.App   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      +localclr-namespace:TestWindows     5        �� 	Resources  5         TitleBarBackgroundBrush �� Color ! WindowControlsForegroundBrush  WindowControlButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType �� Triggers P� Property P� Value	 N� EnterActions
 �� TargetProperty	 �� To g� Duration  StandardButtonStyle �� CornerRadius��%�  &	        &	 !     &	 B     &	 �    �� 5   
   $ #F0F0F0��6:   �� 5   
   $ #333333��6@   �� 5
   
   " ��61   .�5      ��  � ��
 ���� 6+   �� 5       � ��$ 0q�60   �� 5       � ��$ 0q�6(   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� #��z��6!   ._�5      �� $��Center=�6/   $��Center=�6L   5       5      P� 5       �@J�IsMouseOver$
 True��6=   . �5   "   ��  � �� �#E0E0E06?   5      P� 5       � ��$ CloseButton��66   	 5   "   �� 5   &   .��5   *   �� .��5   .   �� $*
 $(Background).(SolidColorBrush.Color)�6=    Red6~   $ 0:0:0.1D�6�   5   +   5   '   5       5"      5$      5%      �� 5'   
   " ��6,   .�5(      ��  � �� �#F0F0F06+   �� 5)       � �� �#3333336+   �� 5*       � �� �#CCCCCC6,   �� 5+       � ��$ 1q�60   �� 5,       � ��$
 10,5q�6(   �� 5-       � �� 5.      �� 5/      " ��6&   .R�50      �� #��z��6!   #��z��51   !   #��z��52   !   $ 3��53   !   ._�54      �� $��Center=�6/   $��Center=�6L   55       56      P� 57       �@J�IsMouseOver$
 True��6=   . �58   "   ��  � �� �#E0E0E06?   59      P� 5:       � ��$
 True��6;   . �5;   "   ��  � �� �#CCCCCC6?   5<      5>      5@      5A      5B      5C      