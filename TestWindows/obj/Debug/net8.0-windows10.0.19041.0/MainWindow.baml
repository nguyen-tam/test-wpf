   M S B A M L   `   `   `  ����F  BTestWindows, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:TestWindowsTestWindows  5   	       TestWindows.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:TestWindows     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � WindowStyle$
 None=�5	   	    � AllowsTransparency$
 True��5
   	    � 
ResizeMode$ CanResizeWithGrip=�5   	   $��0q�5   	   
������ '  !System.Windows.Shell.WindowChrome   WindowChrome 5        5   
      CaptionHeight$ 32Q�6      ResizeBorderThickness$ 8q�5         GlassFrameThickness$ 0q�5         CornerRadius$ 0��5      	   UseAeroCaptionButtons$	 False��5      
   NonClientFrameEdges$

 None=�5      .��5      �� $��1q�6   ���#CCCCCC
�������._�5   
   �  � RowDefinitions 5      �� 5      $��32 �6    �� 5      $��* �6    .+�5      � -   5         �Name$ AppTitleBar��5      $��0��6(      TitleBarBackgroundBrush#��[  65   $��0,0,0,-1q�6k    � ColumnDefinitions 5       �� 5!      $
��Auto �6'   �� 5"      $��* �6'   �� 5#      $
��Auto �6'   �� 5$      $
��Auto �6'   .+�5(      ��  �� Orientation$ 
Horizontal=�6   $��Center=�66   $��10,0,0,0q�6Q   .+�5)      �� -   5         ��Name$ AppTitle��5)       $��Your App Title��62   $��SemiBold"�6H   $��Center=�6^   5*      �� 5-      -   5         ��Name$ YourComboBox��5-   +   $��1��6   $	��200��6A   $
��20,4q�6M   $��Center=�6[    �� 
IsEditable$
 True��5.       �� 
IsReadOnly$
 True��6-    �� Text$ Select an option��6?      IsHitTestVisibleInChrome$
 True��5/      �� 52      -   5         ��Name$ 
YourButton��52   )   $��2��6   $��Action��6=   $��80��6N   $	��5,0q�6Y   $��Center=�53        StandardButtonStyle#��[ 64   $
 True��54      �� 57      $��3��6   $ 
Horizontal=�6-   $��Right=�6F   .+�58      �� -   5        $ MinimizeButton��58      $��46��65   $��32��6@     WindowControlButtonStyle#��[ 6L   $
 True��59      .��5:      F� -   5         F�Name$ MinimizeIcon��5:      $��10��65   $��1��6@    ! WindowControlsForegroundBrush#��[ 6K   $	��1.5��6�   5;      �� 5<      -   5        $ MaximizeButton��5<      $��46��65   $��32��6@   #��[ 6L   $
 True��5=      .��5>      F� -   5        $ MaximizeIcon��5>      $��10��65   $��10��6@   #��[ 6L   $	��1.5��6�   +����        р��     р�� ��� �    ��� 	6�   5?      �� 5@      -	   5        $ CloseButton��5@      $��46��62   $��32��6=   #��[ 6I   $
 True��5A      .��5B      F� -
   5        $ 	CloseIcon��5B      $��10��62   $��10��6=   #��[ 6I   $	��1.5��6�   +����        р�� ��� �    ��� р��     	6�   5C      5D      5E      � 5H      $��1��6   $��10q�6    5J      5K      5L      5M      