   M S B A M L   `   `   `  ����E  AProjektWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:ProjektWPF.RozgrywkiProjektWPF.Rozgrywki  5   	   *    $ProjektWPF.Rozgrywki.FilterRozgrywka   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:ProjektWPF.Rozgrywki     5   	     � Title$  FilterRozgrywka��5   	   $	��355��6!   $	��360��6.   $��16(�6:    � 	Resources 5	         szablon �� 
TargetType �� CornerRadius �� StrokeDashArray �� StrokeDashCap J� SnapsToDevicePixels �� Triggers P� Property	 P� Value
 �� 
TargetName �� Property �� Value��%b  &	        �� 5
   
   " ��6*   .R�5      �� $��Border��6   
��� d �$��3q�6;   $ 10 10 10 10��5      
���2͚�
���   �._�5      � .+�5      �� $��FocusCue��6    $y� Hidden=�60   
���   �$��3��5   0   $	 1 2R�5       $ Round=�67   $
 True��5       �� 5      $
��True��6'   $��Center=�6B   #��z��5   '   5      5       5      P� 5       �@J�IsMouseOver$
	 True��61   . �5      �� $
 Border��6    � ��
 � ���5      5      P� 5       � ��$
	 True��6/   . �5      �� $
 Border��6    � ��
 � d �5      �� 5      $
 Border��6    � ��
 �2͚�5       5!      P� 5"       � {�$	 False��6/   . �5#      �� $
 Border��6    � ��
 �����5%      �� 5&      $
 Border��6    � ��
 ���p�5'      5(      5+      5,      .��5-      � -   5        $��	FiltrGrid��5-       � ColumnDefinitions 5.   
   �� 5/      $
��auto �6   �� 50       � RowDefinitions 52   
   �� 53      $
��auto �6   �� 54      $
��auto �6   �� 55      $
��auto �6   �� 56      $
��auto �6   �� 57      $
��auto �6   �� 58      $
��auto �6   �� 59      $
��auto �6   �� 5:      $��* �6   �� 5;      $
��auto �6   .+�5@   
   �� $��4��6   $��5q�6   .��6(   
Miejsce:62   �� 5A   
   $��5��6   $��5q�6   .��6(   
Sędzia:61   � 5C   
   $��7��6   $��1��6   $��2��6-    5D      �� 5E      �� 5F      .+�5I      �� $��0��6   $��15,15,15,15q�6%   ��6;   ��  �� Path$ SelectedItem.ImagePath� �� ElementName$ Team1��6   �� 5J      $��1��6   $��20q�6&   $��../Files/vs.jpg��63    J� RenderTransformOrigin$ 0.5,0.5&�6M   z�5K      �� 5L      -   5        MyAnimatedTransform�� �� Angle$ 0Q�5L   C    � Triggers 5N      :� 5O       :� RoutedEvent$ Image.Loaded��6#   .[�5P      �� .��5Q      �� .��5R   "   W�  �� 
TargetName$ MyAnimatedTransform��5S       �� TargetProperty$ (RotateTransform.Angle)�5T       W� From 0.05U      	 W� To 3606    g� Duration$ 0:0:6D�6%    g� RepeatBehavior$ Forever��66   5V      5W      5X      5Z      5\      �� 5^   
   $��5q�6   .��6   	Drużyna:6%   �� 5a   
   -   5        $��Team1��5a      $��1��6!   $��5q�61    �� SelectedIndex$ 0��6<   5c      �� 5h   
   $��1��6   $��4��6#   $��5q�60   $ 0��6;    �� Text 6M   �� $ Place�.@�5i      �� .��6    Stadion Miejski w Białymstoku6:   �� 5j      .��6   &$Drugi Stadion Miejski w Białymstoku6@   �� 5k      .��6   Stadion Miejski w Suwałkach68   �� 5l      .��6   Stadion Miejski w Łomży64   �� 5m      .��6   %#Stadion Miejski w Bielsku Podlaskim6@   �� 5n      .��6   Stadion Miejski w Zambrowie68   �� 5o      .��6   '%Stadion Miejski w Wysokim Mazowieckiu6B   �� 5p      .��6   Stadion Miejski w Grajewie67   5q      �� 5r   
   $��5q�6   $��5��6   $��1��6*   ��6:   �� $ Sedziaglowny�6_   �� 5s   
   $��Center=�6    �� Orientation$ 
Horizontal=�62   $��8��6L   $��2��6Y   .+�5t      �� -   5        #��[  5t      $��10,10,40,10q�6G   $
��20,6q�6\   .��6k   Zastosuj Filtr6{   �� 5u      -   5        #��[  5u      $��10q�6G   $
��20,6q�6S   .��6b   Zresetuj Filtr6r   5v      5w      5x      